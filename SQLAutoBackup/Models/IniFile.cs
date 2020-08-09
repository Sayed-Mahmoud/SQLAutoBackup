using SQLAutoBackup.Models;
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
            if (File.Exists(_FileName) && (_FileName.Contains("//") || _FileName.Contains("\\")))
            {
                FileName = _FileName;
            }
            else
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

            Write(Section, Key, Value.ToString());
        }
        public void Write(string Section, string Key, string Value)
        {
            NativeMethods.WritePrivateProfileString(Section, Key, Value, FileName);
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
}
