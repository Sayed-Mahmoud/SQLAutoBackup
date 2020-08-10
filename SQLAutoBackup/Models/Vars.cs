using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using IWshRuntimeLibrary;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SQLAutoBackup.Models
{
    public static class Vars
    {
        /// <summary>
        /// https://stackoverflow.com/a/146162/1726761
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string RemoveInvalidFileNameChars(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "_");
        }

        /// <summary>
        /// https://stackoverflow.com/a/5398398/1726761
        /// </summary>
        /// <param name="path"></param>
        public static void GiveEveryoneAccessControl(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            DirectorySecurity sec = Directory.GetAccessControl(path);
            // Using this instead of the "Everyone" string means we work on non-English systems.
            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.Modify | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            Directory.SetAccessControl(path, sec);
        }

        public static void CreateStartup()
        {
            string ToPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\" + Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".url";
            //if (!System.IO.File.Exists(ToPath))
            {
                object shStartup = (object)"Startup";
                WshShell shell = new WshShell();
                string shortcutAddress = (string)shell.SpecialFolders.Item(ref shStartup) + @"\" + Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                //shortcut.IconLocation = Application.ExecutablePath;
                shortcut.Description = "SQL AutoBackup startup";
                shortcut.TargetPath = Application.ExecutablePath;
                shortcut.Arguments = "/onboot";
                shortcut.Save();
            }
            #region Old Startup
            /*
            using (RegistryKey regkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                if (regkey != null && regkey.GetValue("MyApp") == null)
                {
                    string strPath = Application.ExecutablePath + " /onboot";
                    regkey.SetValue(Path.GetFileNameWithoutExtension(Application.ExecutablePath), strPath, RegistryValueKind.String);
                }
            }
            */
            #endregion
        }
    }

    [SuppressUnmanagedCodeSecurityAttribute]
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetForegroundWindow(IntPtr hWnd);



        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


        [DllImport("kernel32")]
        internal static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        internal static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);
    }
}
