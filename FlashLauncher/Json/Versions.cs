using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace HabboLauncher.Json
{
    public class Versions
    {
        public List<Installation> Installations { get; set; } = new List<Installation>();
        public LastCheck LastCheck { get; set; } = new LastCheck();
    }

    public class Installation
    {
        public string Version { get; set; }
        public string Path { get; set; }
        public string Client { get; set; }
        public long LastModified { get; set; }
    }

    public class LastCheck
    {
        public CheckInfo Unity { get; set; }
        public CheckInfo Air { get; set; }
        public long Time { get; set; }
    }

    public class CheckInfo
    {
        public string Version { get; set; }
        public string Path { get; set; }
    }
}
