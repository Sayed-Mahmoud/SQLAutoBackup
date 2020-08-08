using SQLAutoBackup.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SQLAutoBackup
{
    public partial class MainMenu : Form
    {
        private readonly BackgroundWorker HostWorker = new BackgroundWorker();
        private bool CloseApp;
        public bool AutoStartup;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void SQLAutoBackup_Load(object sender, EventArgs e)
        {
            //AuthCoBox.SelectedIndex = 0;

            if (this.AutoStartup)
            {
                ShowHideNotifyIcon_Click(sender, e);
            }

            HostWorker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            HostWorker.RunWorkerAsync();

            //MyTreeView.Nodes.Clear();
            //RefreshMyTreeView();
        }

        private void SQLAutoBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.CloseApp)
            {
                e.Cancel = true;
                ShowHideNotifyIcon_Click(sender, null);
            }
            else
                MyNotifyIcon.Visible = !this.CloseApp;
        }

        protected override void OnResize(EventArgs ea)
        {
            if (WindowState == FormWindowState.Minimized)
                Visible = false;

            base.OnResize(ea);
        }


        #region MyMenuStrip
        private void ConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBackup.PerformClick();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Are you sure? Click Yes if you want to exit and stopping the automatic backup, click No to close and continue backup or click cancel.", "Exit Confirmation", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.CloseApp = true;
                Application.Exit();
            }
            else if (res == DialogResult.No)
            {
                this.Close();
            }
        }
        #endregion

        #region MyToolStrip

        private void CloneBackup_VisibleChanged(object sender, EventArgs e)
        {
            toolStripSeparator1.Visible = CloneBackup.Visible;
        }

        private void CloseBackup_VisibleChanged(object sender, EventArgs e)
        {
            //toolStripSeparator3.Visible = CloseBackup.Visible;
        }

        private void SaveBackup_VisibleChanged(object sender, EventArgs e)
        {
            toolStripSeparator2.Visible = SaveBackup.Visible;
        }

        private void NewBackup_Click(object sender, EventArgs e)
        {
            ShowBackup(null);
        }

        private void CloneBackup_Click(object sender, EventArgs e)
        {
            string name = BackupNameTxt.Text;
            if (BackupNameTxt.MaxLength > (BackupNameTxt.TextLength + 2))
                name.Remove(BackupNameTxt.TextLength - 2, 2);

            name += "#2";
            ShowBackup(null, true);
            BackupNameTxt.Text = name;
        }

        private void SaveBackup_Click(object sender, EventArgs e)
        {
            string BackupName = BackupNameTxt.Text.Trim();

            #region Save Validation
            int index = ((MyBackup)MyParentPanel.Tag).MyIndex;
            if (BackupName.Length == 0)
            {
                MessageBox.Show("Please write a valid Backup Name!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BackupNameTxt.Focus();
                return;
            }
            else if (MyBackup.MyBackups.Exists(x => x.BackupName.ToLower() == BackupName.ToLower() && x.MyIndex != index))
            {
                MessageBox.Show("Backup Name is already exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BackupNameTxt.Focus();
                return;
            }
            else if (!SQLFunctions.TestConnection(false, HostCoBox.Text, DBCoBox.Text, AuthCoBox.SelectedIndex == 1, AuthCoBox.SelectedIndex == 0 ? UsernameTxt.Text : string.Empty, AuthCoBox.SelectedIndex == 0 ? PassTxt.Text : string.Empty, out _, out string ExcMessage))
            {
                MessageBox.Show(ExcMessage, "SQL ConnectionString Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HostCoBox.Focus();
                return;
            }
            else if (BackupPathTxt.Text.Length == 0 || !Directory.Exists(BackupPathTxt.Text))
            {
                MessageBox.Show("Please select a valid Backup Path!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BackupPathTxt.Focus();
                return;
            }
            else if (!RepeatRadio.Checked && !SpecificRadio.Checked)
            {
                MessageBox.Show("Please select a valid Backup Schedule!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RepeatRadio.Focus();
                return;
            }
            else if (RepeatRadio.Checked)
            {
                if (!SatBox.Checked && !SunBox.Checked && !MonBox.Checked && !TueBox.Checked && !WedBox.Checked && !ThuBox.Checked && !FriBox.Checked)
                {
                    MessageBox.Show("Please select one day schedule at least!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SatBox.Focus();
                    return;
                }
            }
            else if (SpecificRadio.Checked)
            {
                if (!MinutesRadio.Checked && !HoursRadio.Checked && !DaysRadio.Checked && !WeeksRadio.Checked && !MonthsRadio.Checked)//YearsRadio
                {
                    MessageBox.Show("Please select a schedule type!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MinutesRadio.Focus();
                    return;
                }
            }
            #endregion

            MyBackup backup = (MyBackup)MyParentPanel.Tag;

            //Backup Options
            backup.IsEnabled = IsEnabledBox.Checked;
            backup.BackupName = BackupName;

            //SQL Connection
            backup.Host = HostCoBox.SelectedItem.ToString();
            backup.Database = DBCoBox.SelectedItem.ToString();
            backup.Authentication = AuthCoBox.SelectedIndex == 1;
            backup.Username = UsernameTxt.Text;
            backup.Password = PassTxt.Text;
            backup.SavePassword = SaveCkBox.Checked;

            //Backup Path
            backup.BackupPath = BackupPathTxt.Text;

            //Backup Repeat Datetime
            backup.Repeat = RepeatRadio.Checked;
            backup.Time = TimePicker.Value.Ticks;
            backup.Sat = SatBox.Checked;
            backup.Sun = SunBox.Checked;
            backup.Mon = MonBox.Checked;
            backup.Tue = TueBox.Checked;
            backup.Wed = WedBox.Checked;
            backup.Thu = ThuBox.Checked;
            backup.Fri = FriBox.Checked;

            //Backup Specific Datetime
            backup.Specific = SpecificRadio.Checked;
            backup.Every = SpecificNum.Value;
            if (MinutesRadio.Checked)
                backup.SpecificType = MyBackup.SpecificTypes.Minutes;
            else if (HoursRadio.Checked)
                backup.SpecificType = MyBackup.SpecificTypes.Hours;
            else if (DaysRadio.Checked)
                backup.SpecificType = MyBackup.SpecificTypes.Days;
            else if (WeeksRadio.Checked)
                backup.SpecificType = MyBackup.SpecificTypes.Weeks;
            else if (MonthsRadio.Checked)
                backup.SpecificType = MyBackup.SpecificTypes.Months;
            //Years

            MyBackup.Save(backup);
            RefreshMyTreeView();
            MessageBox.Show("Backup settings have been saved successfully.", "Backup settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CloseBackup_Click(object sender, EventArgs e)
        {
            MyParentPanel.Visible = false;
            MyParentPanel.Tag = null;
            MyTreeView.SelectedNode = null;
            CloneBackup.Visible = false;
        }

        #endregion

        #region NotifyIcon
        private void ExitNotifyIcon_Click(object sender, EventArgs e)
        {
            ExitToolStripMenuItem.PerformClick();
        }

        private void ShowHideNotifyIcon_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Visible = true;
                WindowState = FormWindowState.Normal;
                Activate();
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void MyNotifyIcon_Click(object sender, EventArgs e)
        {
            MouseEventArgs mea = e as MouseEventArgs;

            if (mea.Button != MouseButtons.Left)
                return;

            if (WindowState == FormWindowState.Minimized)
            {
                Visible = true;
                WindowState = FormWindowState.Normal;
            }
            Activate();
        }

        private void MyNotifyIconContext_Opening(object sender, CancelEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                ShowHideNotifyIcon.Text = "Restore";
            else
                ShowHideNotifyIcon.Text = "Minimize";
        }
        #endregion

        #region MyTreeView

        private void MyTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
                ShowBackup((MyBackup)e.Node.Tag);
        }

        #endregion


        #region MyParentPanel

        private void MyParentPanel_VisibleChanged(object sender, EventArgs e)
        {
            CloseBackup.Visible = SaveBackup.Visible = MyParentPanel.Visible;
        }

        #region Connection
        private void HostCoBox_Enter(object sender, EventArgs e)
        {
            if (!HostWorker.IsBusy)
                HostWorker.RunWorkerAsync();
        }

        void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var server in SQLFunctions.GetServers())
            {
                if (!HostCoBox.Items.Contains(server))
                {
                    if (this.HostCoBox.InvokeRequired)
                    {
                        HostCoBox.BeginInvoke((MethodInvoker)delegate ()
                        {
                            HostCoBox.Items.Add(server);
                        });
                    }
                    else
                        HostCoBox.Items.Add(server);
                }
            }
        }

        private void DBCoBox_Enter(object sender, EventArgs e)
        {
            using (var con = SQLFunctions.GetConnection(HostCoBox.Text, DBCoBox.Text, AuthCoBox.SelectedIndex == 1, AuthCoBox.SelectedIndex == 0 ? UsernameTxt.Text : string.Empty, AuthCoBox.SelectedIndex == 0 ? PassTxt.Text : string.Empty))
            {
                if (con != null)
                {
                    //DBCoBox.Enabled = true;
                    foreach (var db in SQLFunctions.GetDatabases(con))
                    {
                        if (!DBCoBox.Items.Contains(db))
                            DBCoBox.Items.Add(db);
                    }
                }
                else
                {
                    //DBCoBox.Enabled = false;
                }
            }
        }

        private void AuthCoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsernameLbl.Visible = UsernameTxt.Visible = PassTxt.Visible = PassLbl.Visible = SaveCkBox.Visible = (AuthCoBox.SelectedIndex == 0);
        }

        private void TestConnectionBtn_Click(object sender, EventArgs e)
        {
            SQLFunctions.TestConnection(true, HostCoBox.Text, DBCoBox.Text, AuthCoBox.SelectedIndex == 1, AuthCoBox.SelectedIndex == 0 ? UsernameTxt.Text : string.Empty, AuthCoBox.SelectedIndex == 0 ? PassTxt.Text : string.Empty, out _, out _);
        }
        #endregion

        #region Backup Path

        private void BackupPathTxt_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(BackupPathTxt.Text))
                BackupPathTxt.BackColor = SystemColors.Window;
            else
                BackupPathTxt.BackColor = System.Drawing.Color.Red;
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            if (MyFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                BackupPathTxt.Text = MyFolderBrowserDialog.SelectedPath;
            }
        }
        #endregion

        #region DateTime
        private void RepeatRadio_CheckedChanged(object sender, EventArgs e)
        {
            DaysLayout.Enabled = TimePicker.Enabled = RepeatRadio.Checked;
        }

        private void SpecificRadio_CheckedChanged(object sender, EventArgs e)
        {
            SpecifyLayout.Enabled = SpecificNum.Enabled = SpecificRadio.Checked;
        }
        #endregion

        public void ShowBackup(MyBackup backup, bool Clone = false)
        {
            if (MyParentPanel.Visible)
            {
                //MessageBox.Show("");
            }

            MyParentPanel.Visible = false;

            if (backup == null)
            {
                MyTreeView.SelectedNode = null;
                CloneBackup.Visible = false;
                backup = new MyBackup();
            }
            else
            {
                CloneBackup.Visible = true;
            }

            if (!Clone)
            {
                //Backup Options
                IsEnabledBox.Checked = backup.IsEnabled;
                BackupNameTxt.Text = backup.BackupName;


                //SQL Connection
                if (backup.Host.Length > 0 && !HostCoBox.Items.Contains(backup.Host))
                    HostCoBox.Items.Add(backup.Host);
                HostCoBox.SelectedItem = backup.Host;

                if (backup.Database.Length > 0 && !DBCoBox.Items.Contains(backup.Database))
                    DBCoBox.Items.Add(backup.Database);
                DBCoBox.SelectedItem = backup.Database;

                if (backup.Authentication)
                    AuthCoBox.SelectedIndex = 1;
                else
                    AuthCoBox.SelectedIndex = 0;

                UsernameTxt.Text = backup.Username;
                PassTxt.Text = backup.Password;
                SaveCkBox.Checked = backup.SavePassword;

                //Backup Path
                BackupPathTxt.Text = backup.BackupPath;


                //Backup Repeat Datetime
                RepeatRadio.Checked = backup.Repeat;
                TimePicker.Value = new DateTime(backup.Time);
                SatBox.Checked = backup.Sat;
                SunBox.Checked = backup.Sun;
                MonBox.Checked = backup.Mon;
                TueBox.Checked = backup.Tue;
                WedBox.Checked = backup.Wed;
                ThuBox.Checked = backup.Thu;
                FriBox.Checked = backup.Fri;


                //Backup Specific Datetime
                SpecificRadio.Checked = backup.Specific;
                SpecificNum.Value = backup.Every;
                MinutesRadio.Checked = backup.SpecificType == MyBackup.SpecificTypes.Minutes;
                HoursRadio.Checked = backup.SpecificType == MyBackup.SpecificTypes.Hours;
                DaysRadio.Checked = backup.SpecificType == MyBackup.SpecificTypes.Days;
                WeeksRadio.Checked = backup.SpecificType == MyBackup.SpecificTypes.Weeks;
                MonthsRadio.Checked = backup.SpecificType == MyBackup.SpecificTypes.Months;
                //YearsRadio.Checked = backup.SpecificType == MyBackup.SpecificTypes.Years;
            }
            MyParentPanel.Tag = backup;
            MyParentPanel.Visible = true;
        }

        public void RefreshMyTreeView()
        {
            foreach (var backup in MyBackup.MyBackups.OrderBy(x => x.MyIndex))
            {
                TreeNode node;
                if (MyTreeView.Nodes.ContainsKey(backup.MyIndex.ToString()))
                    node = MyTreeView.Nodes[backup.MyIndex.ToString()];
                else
                    node = new TreeNode()
                    {
                        //BackColor = Color.LightSkyBlue,
                        Tag = backup,
                        Name = backup.MyIndex.ToString(),
                        ImageIndex = 0,
                        
                    };

                node.Text = backup.BackupName + Environment.NewLine + "Test";

                if (!MyTreeView.Nodes.Contains(node))
                    MyTreeView.Nodes.Add(node);
            }
        }

        #endregion

        private void MyTreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if ((e.State & TreeNodeStates.Selected) != 0)
            {
                Font nodeFont;
                if (e.Node.NodeFont != null)
                    nodeFont = new Font(e.Node.NodeFont.FontFamily, e.Node.NodeFont.Size + 2, FontStyle.Bold);
                else
                {
                    var sfont = ((TreeView)sender).Font;
                    nodeFont = new Font(sfont.FontFamily, sfont.Size + 2, FontStyle.Bold);
                }
                Brush brush/*;
                if (this.ActiveControl != e.Node.TreeView)
                    brush = Brushes.Red;
                else
                    brush*/ = Brushes.Transparent;

                e.Graphics.FillRectangle(brush, Rectangle.Inflate(e.Bounds, 0, 0));//Transparent

                e.Graphics.DrawString(e.Node.Text, nodeFont, Brushes.White, e.Node.Bounds);

            
            }
            else// Use the default background and node text.
            {
                e.DrawDefault = true;
            }
        }
    }
}
