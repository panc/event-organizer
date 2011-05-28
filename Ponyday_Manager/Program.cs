using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using log4net;

namespace PonydayManager
{
    static class Program
    {
        private static ILog _log = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _log.Info(new string('=', 80));
            _log.Info("PonydayManager - APPLICATION STARTUP");
            _log.Info(new string('-', 80));
            _log.Info("User: " + Environment.UserDomainName + "\\" + Environment.UserName);
            _log.Info("Computer: " + Environment.MachineName);
            _log.Info("App-Directory: " + Environment.CurrentDirectory);
            _log.Info("App-Version: " + Application.ProductVersion);
            _log.Info(".NET Framework Version: " + Environment.Version);
            _log.Info(new string('=', 80));
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            _log.Debug(new string('=', 80));
            _log.Debug("PonydayManager - APPLICATION CLOSED");
            _log.Debug(new string('=', 80));
        }
    }
}
