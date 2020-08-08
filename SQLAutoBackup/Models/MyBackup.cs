using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SQLAutoBackup.Models
{
    public class MyBackup
    {
        public static List<MyBackup> MyBackups = new List<MyBackup>();

        public static void Load(MainMenu mainMenu)
        {
            IniFile MyIni = new IniFile("Configuration.ini");
            var MaxIndex = MyIni.ReadInt32("Configuration", "MaxIndex", 0);
            for (int i = 0; i < MaxIndex; i++)
            {
                string Section = "Configuration#" + (i + 1).ToString();
                int MyIndex = MyIni.ReadInt32(Section, "MyIndex", 0);
                if (MyIndex > 0)
                {
                    MyBackup backup = new MyBackup()
                    {
                        MyIndex = MyIndex,
                        IsEnabled = MyIni.ReadBoolean(Section, "IsEnabled"),
                        BackupName = MyIni.ReadString(Section, "BackupName"),
                        Host = MyIni.ReadString(Section, "Host"),
                        Database = MyIni.ReadString(Section, "Database"),
                        Authentication = MyIni.ReadBoolean(Section, "Authentication"),
                        Username = MyIni.ReadString(Section, "Username"),
                        Password = MyIni.ReadString(Section, "Password"),
                        SavePassword = MyIni.ReadBoolean(Section, "SavePassword"),
                        BackupPath = MyIni.ReadString(Section, "BackupPath"),
                        Repeat = MyIni.ReadBoolean(Section, "Repeat"),
                        Time = MyIni.ReadInt64(Section, "Time"),
                        Sat = MyIni.ReadBoolean(Section, "Sat"),
                        Sun = MyIni.ReadBoolean(Section, "Sun"),
                        Mon = MyIni.ReadBoolean(Section, "Mon"),
                        Tue = MyIni.ReadBoolean(Section, "Tue"),
                        Wed = MyIni.ReadBoolean(Section, "Wed"),
                        Thu = MyIni.ReadBoolean(Section, "Thu"),
                        Fri = MyIni.ReadBoolean(Section, "Fri"),
                        Specific = MyIni.ReadBoolean(Section, "Specific"),
                        Every = MyIni.ReadDecimal(Section, "Every"),
                        SpecificType = (SpecificTypes)MyIni.ReadInt32(Section, "SpecificType"),
                        LastBackup = MyIni.ReadInt64(Section, "LastBackup"),
                    };

                    MyBackups.Add(backup);
                }
            }

            if (mainMenu.MyTreeView.InvokeRequired)
            {
                mainMenu.MyTreeView.BeginInvoke((MethodInvoker)delegate ()
                {
                    mainMenu.MyTreeView.Nodes.Clear();
                    mainMenu.RefreshMyTreeView();
                });
            }
            else
            {
                mainMenu.MyTreeView.Nodes.Clear();
                mainMenu.RefreshMyTreeView();
            }

            
        }

        public static void Save(MyBackup backup)
        {
            IniFile MyIni = new IniFile("Configuration.ini");
            string Section = "Configuration#";

            if (backup.MyIndex == 0)
            {
                var MaxIndex = MyIni.ReadInt32("Configuration", "MaxIndex", 0) + 1;
                backup.MyIndex = MaxIndex;
                Section += MaxIndex.ToString();

                MyIni.Write("Configuration", "MaxIndex", MaxIndex);
            }
            else
                Section += backup.MyIndex.ToString();


            MyIni.Write(Section, "MyIndex", backup.MyIndex);
            MyIni.Write(Section, "IsEnabled", backup.IsEnabled);
            MyIni.Write(Section, "BackupName", backup.BackupName);
            MyIni.Write(Section, "Host", backup.Host);
            MyIni.Write(Section, "Database", backup.Database);
            MyIni.Write(Section, "Authentication", backup.Authentication);
            MyIni.Write(Section, "Username", backup.Username);
            MyIni.Write(Section, "Password", backup.Password);
            MyIni.Write(Section, "SavePassword", backup.SavePassword);
            MyIni.Write(Section, "BackupPath", backup.BackupPath);
            MyIni.Write(Section, "Repeat", backup.Repeat);
            MyIni.Write(Section, "Time", backup.Time);
            MyIni.Write(Section, "Sat", backup.Sat);
            MyIni.Write(Section, "Sun", backup.Sun);
            MyIni.Write(Section, "Mon", backup.Mon);
            MyIni.Write(Section, "Tue", backup.Tue);
            MyIni.Write(Section, "Wed", backup.Wed);
            MyIni.Write(Section, "Thu", backup.Thu);
            MyIni.Write(Section, "Fri", backup.Fri);
            MyIni.Write(Section, "Specific", backup.Specific);
            MyIni.Write(Section, "Every", backup.Every);
            MyIni.Write(Section, "SpecificType", (int)backup.SpecificType);
            MyIni.Write(Section, "LastBackup", backup.LastBackup);

            if (!MyBackups.Contains(backup))
            MyBackups.Add(backup);
        }

        public static void Delete(MyBackup backup)
        {
            IniFile MyIni = new IniFile("Configuration.ini");
            MyIni.DeleteSection("Configuration#" + backup.MyIndex);
            MyBackups.Remove(backup);
        }

        public int MyIndex;

        public bool IsEnabled = true;

        public string BackupName = string.Empty;

        public string Host = string.Empty;
        public string Database = string.Empty;
        /// <summary>
        /// <see langword="false"/> is SQL Server Authentication, <see langword="true"/> is Windows Authentication
        /// </summary>
        public bool Authentication = false;
        public string Username = string.Empty;
        public string Password = string.Empty;
        public bool SavePassword = true;

        public string BackupPath = string.Empty;

        public bool Repeat;
        public long Time = 637322688000000000;
        public bool Sat = true;
        public bool Sun = true;
        public bool Mon = true;
        public bool Tue = true;
        public bool Wed = true;
        public bool Thu = true;
        public bool Fri = true;

        public bool Specific;
        public decimal Every = 1;
        public SpecificTypes SpecificType;

        public long LastBackup;

        public enum SpecificTypes : int
        {
            None = 0,
            Minutes,
            Hours,
            Days,
            Weeks,
            Months,
            Years
        }
    }
}
