using BOSLib;
using BYSUpdater;
using DevExpress.XtraSplashScreen;
using Localization;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BOSERP
{
    static class Program
    {
        private static string ProjectCode = ConfigurationManager.AppSettings["ProjectCode"];

        [STAThread]
        static void Main()
        {
            if (!SingleInstance.Start(ProjectCode))
                return;

            DevExpress.UserSkins.OfficeSkins.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Assembly assembly = Assembly.GetExecutingAssembly();
            if (!CheckForUpdate(assembly))
            {
                SplashScreenManager.ShowForm(typeof(BysSplashForm));
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                GEVersionsController objVersionsController = new GEVersionsController();
                if (objVersionsController.CheckVersion(fvi.FileVersion))
                {
                    Application.Run(new GUIMain());
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    MessageBox.Show(CommonLocalizedResources.Version, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private static bool CheckForUpdate(Assembly assembly)
        {
            string downloadPath = ConfigurationManager.AppSettings["DownloadedURL"];
            string versionFileName = ConfigurationManager.AppSettings["VersionFileName"];
            string localVersion = "1.0.0.0";
            string localVersionPath = Application.StartupPath + @"\LocalVersion.txt";
            if (File.Exists(localVersionPath))
            {
                localVersion = File.ReadAllText(localVersionPath);
            }
            else
            {
                File.WriteAllText(localVersionPath, localVersion);
            }

            var productVersion = assembly.GetName().Version;
            BysGateway.CurrentVersion = string.Format("v{0}.{1}.{2}", productVersion.Major, productVersion.Minor, productVersion.Build);
            BysGateway.EnvironmentVersion = ConfigurationManager.AppSettings["Environment"];
            if (string.IsNullOrWhiteSpace(BysGateway.EnvironmentVersion))
                BysGateway.EnvironmentVersion = "Development";

            if (string.IsNullOrWhiteSpace(downloadPath))
                return false;

            return BYSAutoUpdater.InstallUpdate(downloadPath, versionFileName, localVersion, assembly);
        }

        static public class SingleInstance
        {
            private static int WM_SHOWFIRSTINSTANCE { get; set; }

            private static Mutex CurrentMutex = null;

            static public bool Start(string projectCode)
            {
                BysGateway.MutexInstanceName = String.Format("Local\\{0}", projectCode);
                WM_SHOWFIRSTINSTANCE = WinApi.RegisterWindowMessage("WM_SHOWFIRSTINSTANCE|{0}", BysGateway.MutexInstanceName);
                bool isCreateInstance = false;
                CurrentMutex = new Mutex(true, BysGateway.MutexInstanceName, out isCreateInstance);
                return isCreateInstance;
            }

            static public void ShowFirstInstance()
            {
                WinApi.PostMessage(
                    (IntPtr)WinApi.HWND_BROADCAST,
                    WM_SHOWFIRSTINSTANCE,
                    IntPtr.Zero,
                    IntPtr.Zero);

                IntPtr window = WinApi.FindWindow(null, BysGateway.MutexInstanceName);
                WinApi.ShowToFront((IntPtr)WinApi.HWND_BROADCAST);
            }

            static public void Stop()
            {
                CurrentMutex.ReleaseMutex();
            }
        }
    }
}
