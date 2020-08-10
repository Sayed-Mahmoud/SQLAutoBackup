using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SQLAutoBackup
{
    public static class SQLFunctions
    {
        /// <summary>
        /// Test SQL Connection and return true if the connection is valid or false if it is not valid.
        /// </summary>
        /// <param name="ShowTest">Show Message (Error message or Successful)</param>
        /// <param name="DS">DataSource</param>
        /// <param name="DB">Database</param>
        /// <param name="IS">IntegratedSecurity</param>
        /// <param name="User">UserID</param>
        /// <param name="Pass">Password</param>
        /// <param name="ConnectionString">SQL Connection String</param>
        /// <param name="ExcMessage">Exception Message</param>
        /// <returns>bool</returns>
        public static bool TestConnection(bool ShowTest, string DS, string DB, bool IS, string User, string Pass, out string ConnectionString, out string ExcMessage)
        {
            if (DB.Length == 0 || DS.Length == 0)
            {
                //DB = "master";
                ConnectionString = "";
                ExcMessage = "Please select your host and database!";
                if (ShowTest)
                    MessageBox.Show("Please select your host and database!", "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool ISecurity = IS || (User.Length == 0 || Pass.Length == 0);//If user or password is empty return true (Windows Auth)
            var builder = new SqlConnectionStringBuilder()
            {
                ConnectTimeout = 10,
                DataSource = DS,
                InitialCatalog = DB,
                IntegratedSecurity = ISecurity,
                UserID = IS ? string.Empty : User,
                Password = IS ? string.Empty : Pass,
            };

            ConnectionString = builder.ConnectionString;

            using (var con = new SqlConnection(builder.ConnectionString))
            {
                try
                {
                    con.Open();
                }
                catch (SqlException exc)
                {
                    if (ShowTest)
                        MessageBox.Show(exc.Message, "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExcMessage = exc.Message;
                    return false;
                }
                catch (Exception ex)
                {
                    if (ShowTest)
                        MessageBox.Show(ex.Message, "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExcMessage = ex.Message;
                    return false;
                }
            }

            if (ShowTest)
                MessageBox.Show("Connection Successful.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExcMessage = "";
            return true;
        }

        /// <summary>
        /// Get available SQL Servers https://stackoverflow.com/questions/10781334/how-to-get-list-of-available-sql-servers-using-c-sharp-code.
        /// </summary>
        /// <returns>List of string</returns>
        public static List<string> GetServers()
        {
            List<string> Servers = new List<string>();
            string myServer = Environment.MachineName;

            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine
                {
                    if ((servers.Rows[i]["InstanceName"] as string) != null)
                        Servers.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                    else
                        Servers.Add(servers.Rows[i]["ServerName"].ToString());
                }
            }

            return Servers;
        }

        /// <summary>
        /// Get Databases from connection
        /// </summary>
        /// <param name="con">SQL Connection</param>
        /// <returns>List of string</returns>
        public static List<string> GetDatabases(SqlConnection con)
        {
            List<string> DBs = new List<string>();
            string verQuery = "SELECT name FROM master.dbo.sysdatabases;";

            try
            {
                using (SqlCommand cmd = new SqlCommand(verQuery, con))
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader reader;
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                                DBs.Add(reader.GetString(0));
                        }
                    }
                    return DBs;
                }
            }
            catch //(Exception exc) when (exc is SqlException Sqlexc)
            {

            }
            return DBs;
        }

        /// <summary>
        /// Get SqlConnection
        /// </summary>
        /// <param name="ShowTest">Show Message (Error message or Successful)</param>
        /// <param name="DS">DataSource</param>
        /// <param name="DB">Database</param>
        /// <param name="IS">IntegratedSecurity</param>
        /// <param name="User">UserID</param>
        /// <param name="Pass">Password</param>
        /// <returns>SqlConnection</returns>
        public static SqlConnection GetConnection(string DS, string DB = "master", bool IS = false, string User = "", string Pass = "")
        {
            if (DB.Length == 0)
                DB = "master";

            bool ISecurity = IS || (User.Length == 0 || Pass.Length == 0);//If user or password is empty return true (Windows Auth)
            var builder = new SqlConnectionStringBuilder()
            {
                ConnectTimeout = 10,
                DataSource = DS,
                InitialCatalog = DB,
                IntegratedSecurity = ISecurity,
                UserID = IS ? string.Empty : User,
                Password = IS ? string.Empty : Pass,
            };

            var con = new SqlConnection(builder.ConnectionString);
            try
            {
                con.Open();
            }
            catch //(SqlException exc)
            {
                con.Close();
                con.Dispose();
                return null;
            }
            return con;
        }

        /// <summary>
        /// Get SQL ConnectionString
        /// </summary>
        /// <param name="DS">DataSource</param>
        /// <param name="DB">Database</param>
        /// <param name="IS">IntegratedSecurity</param>
        /// <param name="User">UserID</param>
        /// <param name="Pass">Password</param>
        /// <returns>SQL ConnectionString</returns>
        public static string GetConnectionString(string DS, string DB, bool IS, string User, string Pass)
        {
            if (DB.Length == 0)
                DB = "master";

            bool ISecurity = IS || (User.Length == 0 || Pass.Length == 0);//If user or password is empty return true (Windows Auth)
            var builder = new SqlConnectionStringBuilder()
            {
                ConnectTimeout = 10,
                DataSource = DS,
                InitialCatalog = DB,
                IntegratedSecurity = ISecurity,
                UserID = IS ? string.Empty : User,
                Password = IS ? string.Empty : Pass,
            };

            return builder.ConnectionString;
        }

        public static Exception BackupNow(string path, string connectionString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand CmResources = new SqlCommand("USE master BACKUP DATABASE @DBName TO DISK = @ToPath", conn))
                    {
                        CmResources.Parameters.Add("@DBName", SqlDbType.NVarChar).Value = conn.Database.ToString();
                        CmResources.Parameters.Add("@ToPath", SqlDbType.NVarChar).Value = path;
                        CmResources.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) when (ex is Exception || ex is SqlException || ex is InvalidCastException || ex is IOException || ex is InvalidOperationException || ex is ObjectDisposedException)
            {
                return ex;
            }
            return null;
        }
    }
}
