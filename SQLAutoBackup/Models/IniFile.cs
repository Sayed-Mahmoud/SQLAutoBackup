using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace SQLAutoBackup
{
    public class IniFile
    {
        public string FileName;

        /// <summary>
        /// https://stackoverflow.com/questions/217902/reading-writing-an-ini-file
        /// </summary>
        /// <param name="_FileName"></param>
        public IniFile(string _FileName)
        {
            /*
            if (File.Exists(_FileName))
            {
                FileName = _FileName;
            }
            else
            */
            {
                FileName = Application.StartupPath + "\\" + _FileName;
            }

            if (!File.Exists(FileName))
                File.Create(FileName).Close();
        }


        public byte ReadByte(string Section, string Key, byte _Default)
        {
            byte.TryParse(ReadString(Section, Key, _Default.ToString()), out byte buf);//6
            return buf;
        }
        public short ReadInt16(string Section, string Key, short _Default)
        {
            short.TryParse(ReadString(Section, Key, _Default.ToString()), out short buf);//9
            return buf;
        }
        public int ReadInt32(string Section, string Key)
        {
            int.TryParse(ReadString(Section, Key, 0), out int buf);
            return buf;
        }
        public int ReadInt32(string Section, string Key, int _Default)
        {
            int.TryParse(ReadString(Section, Key, _Default.ToString()), out int buf);
            return buf;
        }
        public long ReadInt64(string Section, string Key)
        {
            long.TryParse(ReadString(Section, Key, 0), out long buf);
            return buf;
        }
        public decimal ReadDecimal(string Section, string Key)
        {
            decimal.TryParse(ReadString(Section, Key, 0), out decimal buf);
            return buf;
        }
        public sbyte ReadSByte(string Section, string Key, byte _Default)
        {
            sbyte.TryParse(ReadString(Section, Key, _Default.ToString()), out sbyte buf);
            return buf;
        }
        public bool ReadBoolean(string Section, string Key)
        {
            bool.TryParse(ReadString(Section, Key, false.ToString()), out bool buf);
            return buf;
        }
        public bool ReadBoolean(string Section, string Key, bool _Default)
        {
            bool.TryParse(ReadString(Section, Key, _Default.ToString()), out bool buf);
            return buf;
        }
        public string ReadString(string Section, string Key)
        {
            return ReadString(Section, Key, string.Empty);
        }
        public string ReadString(string Section, string Key, object _Default)
        {
            if (_Default == null)
                _Default = string.Empty;

            var Buffer = new StringBuilder(255);//400
            NativeMethods.GetPrivateProfileString(Section, Key, _Default.ToString(), Buffer, 255, FileName);//GetPrivateProfileStringA
            return Buffer.ToString();
        }
        public ushort ReadUInt16(string Section, string Key)
        {
            ushort.TryParse(ReadString(Section, Key, 0.ToString()), out ushort buf);
            return buf;
        }
        public uint ReadUInt32(string Section, string Key)
        {
            uint.TryParse(ReadString(Section, Key, 0.ToString()), out uint buf);
            return buf;
        }

        public void Write(string Section, string Key, object Value)
        {
            if (Value == null)
            {
                Value = string.Empty;
            }
            /*
if (Value.GetType() == typeof(bool))
   if ((bool)Value)
   {
       Value = 1;
   }
   else
       Value = 0;
*/
            Write(Section, Key, Value.ToString());
        }
        public void Write(string Section, string Key, string Value)
        {
            NativeMethods.WritePrivateProfileString(Section, Key, Value, FileName);//WritePrivateProfileStringA
        }

        public void DeleteSection(string Section = null)
        {
            Write(Section, null, null);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Section, Key, null);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return ReadString(Section, Key).Length > 0;
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
        /*
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        internal static extern int GetPrivateProfileStringA(string Section, string Key, string _Default, StringBuilder Buffer, int BufferSize, string FileName);
        
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        internal static extern int WritePrivateProfileStringA(string Section, string Key, string Arg, string FileName);
        */

        /*
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        internal static extern int GetPrivateProfileString(string Section, string Key, string _Default, StringBuilder Buffer, int BufferSize, string FileName);
        */

        /*
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        internal static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);//long
        

        [DllImport("KERNEL32.DLL", EntryPoint = "WritePrivateProfileStringW",
           SetLastError = true,
           CharSet = CharSet.Unicode, ExactSpelling = true,
           CallingConvention = CallingConvention.StdCall)]
        internal static extern int WritePrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFilename);
        */
    }
}
