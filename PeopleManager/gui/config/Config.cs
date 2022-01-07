using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PeopleManager.gui.config
{
    class Config
    {
        public Config()
        {
            if (!Directory.Exists("Config")) Directory.CreateDirectory("Config");
            if (!File.Exists(configfile)) File.Create(configfile).Close();
        }
        public static string configfile = "Config/config.ini";


    }
}
