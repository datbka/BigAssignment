using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleManager.gui.form;
using PeopleManager.gui.config;
using PeopleManager.service;
using PeopleManager.service.DAO;

namespace PeopleManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Config config = new Config();
            IniFile inifile = new IniFile(Config.configfile);
            string username = inifile.Read("username");
            string pass = inifile.Read("password");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            if (UserDAO.Instance.Exist(username, pass))
                    Application.Run(new MainForm(username));
            
            else Application.Run(new LoginForm());
        }
    }
}
