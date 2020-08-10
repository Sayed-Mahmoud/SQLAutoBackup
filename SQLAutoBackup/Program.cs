using Microsoft.Win32;
using SQLAutoBackup.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SQLAutoBackup
{
    static class Program
    {
        public static bool DebugMode = false;
        //public static bool IsLoaded;
        public static MainMenu mainMenu;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            #region One Process
            Process current = Process.GetCurrentProcess();
            Process[] Processess = Process.GetProcessesByName(current.ProcessName);
            for (int i = 0; i < Processess.Length; i++)
            {
                Process process = Processess[i];
                if (process.ProcessName == current.ProcessName && process.Id != current.Id)
                {
                    NativeMethods.SetForegroundWindow(process.MainWindowHandle);
                    NativeMethods.ShowWindow(process.MainWindowHandle, 9);//9
                    Application.Exit();
                    Environment.Exit(0);
                    return;
                }
            }
            #endregion

            #region Startup
            if (!DebugMode)
            {
                using (RegistryKey regkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (regkey != null && regkey.GetValue("MyApp") == null)
                    {
                            string strPath = Application.ExecutablePath + " /onboot";
                        regkey.SetValue(Path.GetFileNameWithoutExtension(Application.ExecutablePath), strPath, RegistryValueKind.String);
                    }
                }
            }
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainMenu = new MainMenu()
            {
                AutoStartup = args.Length > 0
            };

            var worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();

            Application.Run(mainMenu);
        }

        static void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            MyBackup.LoadBackups(mainMenu);
        }

        static void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //IsLoaded = true;
            if (e.Error != null)
                if (DebugMode)
                    MessageBox.Show(e.Error.ToString());
                else
                    MessageBox.Show(e.Error.Message);
        }
    }
}