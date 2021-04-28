using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabboLauncher.Utilities
{
    public class SelfUpdater
    {
        private readonly MainFrm MainFrm;

        public Version LocalVersion { get; set; }
        public Release Latest { get; set; }
        public Release Current { get; set; }

        public SelfUpdater(MainFrm mainFrm)
        {
            MainFrm = mainFrm;

            LocalVersion = new Version(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);
            MainFrm.SetVersionText(LocalVersion.ToString());

            var git = new GitHubClient(new ProductHeaderValue("HabboLauncher"));
            git.Repository.Release.GetAll("scottstamp", "HabboLauncher").ContinueWith(GrabbedReleases);
        }

        private void GrabbedReleases(Task<IReadOnlyList<Release>> getReleasesTask)
        {
            IReadOnlyList<Release> releases = getReleasesTask.Result;
            Latest = releases.FirstOrDefault();

            if (Latest == null) return;

            foreach (Release release in releases)
            {
                string version = release.TagName.Substring(1);
                if (version == LocalVersion.ToString())
                {
                    Current = release;
                    break;
                }
            }

            if (Current == null)
            {
                Current = Latest;
            }

            if (!Latest.Prerelease && new Version(Latest.TagName.Substring(1)) > LocalVersion)
            {
                if (Program.Settings.PromptSelfUpdate)
                {
                    MainFrm.DisableAutoLaunch();

                    if (MessageBox.Show($"A launcher update has been found, would you like to be taken to the download page? ({Latest.TagName})",
                        "HabboLauncher ~ Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Process.Start(Latest.HtmlUrl);
                    }
                }
            }
        }
    }
}
