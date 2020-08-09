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
        #region My Backups

        public static List<MyBackup> MyBackups = new List<MyBackup>();

        public static void LoadBackups(MainMenu mainMenu)
        {
            var MyIni = new IniFile("Configuration.ini");
            var MaxIndex = MyIni.ReadInt32("Configuration", "MaxIndex", 0);
            for (int i = 0; i < MaxIndex; i++)
            {
                var Section = "Configuration#" + (i + 1).ToString();
                var MyIndex = MyIni.ReadInt32(Section, "MyIndex", 0);
                if (MyIndex > 0)
                {
                    var backup = new MyBackup()
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
                    LoadBackupStatus(backup);
                }
            }

            mainMenu.BackupsLoaded();
        }

        public static void SaveBackup(MyBackup backup)
        {
            var MyIni = new IniFile("Configuration.ini");
            var Section = "Configuration#";

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

        public static void DeleteBackup(MyBackup backup)
        {
            while (backup.BackupStatus.Count > 0)
            {
                DeleteBackupState(backup.BackupStatus[0]);
            }
            IniFile MyIni = new IniFile("Configuration.ini");
            MyIni.DeleteSection("Configuration#" + backup.MyIndex);
            MyBackups.Remove(backup);
        }

        #endregion

        #region Backup Status

        public static void LoadBackupStatus(MyBackup backup)
        {
            var MyIni = new IniFile("BackupStatus.ini");
            var StrIndexes = MyIni.ReadString("Configuration", "Indexes#" + backup.MyIndex, "");

            int[] Indexes = StrIndexes.Split(',').Select(x => int.TryParse(x, out var i) ? i : 0).ToArray();

            foreach (var i in Indexes)
            {
                string Section = "Status#" + backup.MyIndex + "#" + i.ToString();
                int MyIndex = MyIni.ReadInt32(Section, "MyIndex", 0);
                if (MyIndex > 0)
                {
                    var state = new BackupState()
                    {
                        StateIndex = MyIndex,
                        backup = backup,
                        FullPath = MyIni.ReadString(Section, "FullPath"),
                        BackupDateTime = MyIni.ReadInt64(Section, "BackupDateTime"),
                        DefaultBackupDateTime = MyIni.ReadInt64(Section, "DefaultBackupDateTime"),
                        Warning = MyIni.ReadBoolean(Section, "Warning"),
                        WarningMessage = MyIni.ReadString(Section, "WarningMessage"),
                        FullWarning = MyIni.ReadString(Section, "FullWarning"),
                        Read = MyIni.ReadBoolean(Section, "Read"),
                    };

                    backup.BackupStatus.Add(state);
                }
            }
        }

        public static void SaveBackupState(BackupState state)
        {
            var MyIni = new IniFile("BackupStatus.ini");
            var backupIndex = state.backup.MyIndex.ToString();
            var Section = "Status#" + backupIndex + "#";

            if (state.StateIndex == 0)
            {
                var Indexes = MyIni.ReadString("Configuration", "Indexes#" + backupIndex, 0);

                var MaxIndex = Indexes.Split(',').Max(x => int.TryParse(x, out var i) ? i : 0) + 1;

                state.StateIndex = MaxIndex;

                Section += MaxIndex.ToString();

                string[] IndexesArr = state.backup.BackupStatus.Select(x => x.StateIndex.ToString() + ",").ToArray();
                string NewIndexes = string.Join(string.Empty, IndexesArr) + MaxIndex.ToString();

                MyIni.Write("Configuration", "Indexes#" + backupIndex, NewIndexes);
            }
            else
                Section += state.StateIndex.ToString();

            MyIni.Write(Section, "MyIndex", state.StateIndex);
            MyIni.Write(Section, "FullPath", state.FullPath);
            MyIni.Write(Section, "BackupDateTime", state.BackupDateTime);
            MyIni.Write(Section, "DefaultBackupDateTime", state.DefaultBackupDateTime);
            MyIni.Write(Section, "Warning", state.Warning);
            MyIni.Write(Section, "WarningMessage", state.WarningMessage);
            MyIni.Write(Section, "FullWarning", state.FullWarning);
            MyIni.Write(Section, "Read", state.Read);

            if (!state.backup.BackupStatus.Contains(state))
                state.backup.BackupStatus.Add(state);
        }

        public static void DeleteBackupState(BackupState state)
        {
            var backupIndex = state.backup.MyIndex.ToString();
            IniFile MyIni = new IniFile("BackupStatus.ini");

            MyIni.DeleteSection("Status#" + backupIndex + "#" + state.StateIndex);

            string[] Indexes = state.backup.BackupStatus.Select(x => x.StateIndex == state.StateIndex ? string.Empty : (x.StateIndex.ToString() + ",")).ToArray();
            string NewIndexes = string.Join(string.Empty, Indexes.Where(x => x.Length > 0));

            MyIni.Write("Configuration", "Indexes#" + backupIndex, NewIndexes);

            state.backup.BackupStatus.Remove(state);
        }

        #endregion

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

        public List<BackupState> BackupStatus = new List<BackupState>();
        public class BackupState
        {
            public MyBackup backup;
            public int StateIndex;
            public string FullPath;
            public long BackupDateTime;
            public long DefaultBackupDateTime;
            public bool Warning;
            public string WarningMessage;
            public string FullWarning;
            public bool Read;
        }

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

        #region Datetime/TimeSpan Helpers
        public bool RepeatDay(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday:
                    return this.Sun;
                case DayOfWeek.Monday:
                    return this.Mon;
                case DayOfWeek.Tuesday:
                    return this.Tue;
                case DayOfWeek.Wednesday:
                    return this.Wed;
                case DayOfWeek.Thursday:
                    return this.Thu;
                case DayOfWeek.Friday:
                    return this.Fri;
                case DayOfWeek.Saturday:
                    return this.Sat;
                default:
                    return false;
            }
        }
        public TimeSpan RepeatTime
        {
            get
            {
                var time = new DateTime(Time);
                return new TimeSpan(time.Hour, time.Minute, 0);
            }
        }

        public TimeSpan SpecificAfter
        {
            get
            {
                DateTime DT = new DateTime();
                switch (SpecificType)
                {
                    case SpecificTypes.Minutes:
                        return TimeSpan.FromTicks(DT.AddMinutes((double)this.Every).Ticks);
                    case SpecificTypes.Hours:
                        return TimeSpan.FromTicks(DT.AddHours((double)this.Every).Ticks);
                    case SpecificTypes.Days:
                        return TimeSpan.FromTicks(DT.AddDays((double)this.Every).Ticks);
                    case SpecificTypes.Weeks:
                        return TimeSpan.FromTicks(DT.AddDays((double)this.Every * 7).Ticks);
                    case SpecificTypes.Months:
                        {
                            var vals = this.Every.ToString().Split('0');
                            int.TryParse(vals[0], out int Months);
                            int.TryParse(vals[1], out int Days);
                            DT.AddMonths(Months);//DT = 
                            DT.AddDays(Days * DateTime.DaysInMonth(DT.Year, DT.Month));
                            return TimeSpan.FromTicks(DT.Ticks);
                        }
                    case SpecificTypes.Years:
                    case SpecificTypes.None:
                    default:
                        {
                            return new TimeSpan();
                        }
                }
            }
        }
        #endregion
    }
}
