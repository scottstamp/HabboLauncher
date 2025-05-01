using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabboLauncher
{
    public class UpdateResult
    {
        public bool FlashUpdate, UnityUpdate, HabboxUpdate, ShockwaveUpdate, Required;

        public UpdateResult() { }
        public UpdateResult(bool flashUpdate, bool unityUpdate, bool habboxUpdate, bool shockwaveUpdate, bool required = false)
        {
            FlashUpdate = flashUpdate;
            UnityUpdate = unityUpdate;
            HabboxUpdate = habboxUpdate;
            ShockwaveUpdate = shockwaveUpdate;
            Required = required;
        }
    }
}
