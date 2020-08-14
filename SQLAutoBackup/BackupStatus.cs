using SQLAutoBackup.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static SQLAutoBackup.Models.MyBackup;

namespace SQLAutoBackup
{
    public partial class BackupStatus : Form
    {
        public MyBackup myBackup;
        public BackupStatus(MyBackup myBackup)
        {
            this.myBackup = myBackup;
            InitializeComponent();
        }

        private void BackupStatus_Load(object sender, EventArgs e)
        {
            foreach (var state in myBackup.BackupStatus)
            {
                var rowIndex = StateDGV.Rows.Add();
                StateDGV.Rows[rowIndex].Tag = state;
                StateDGV[SateIndexCol.Index, rowIndex].Value = state.StateIndex;
                StateDGV[DateTimeCol.Index, rowIndex].Value = new DateTime(state.BackupDateTime).ToString();
                StateDGV[DefDateTimeCol.Index, rowIndex].Value = new DateTime(state.DefaultBackupDateTime).ToString();
                StateDGV[WarningMessageCol.Index, rowIndex].Value = state.WarningMessage;
                StateDGV[DeleteCol.Index, rowIndex].Value = false;
            }

            SetStatusStrip();
        }

        private void SetStatusStrip()
        {
            TotalStatusLBL.Text = myBackup.BackupStatus.Count().ToString();
            SelectedStatusLBL.Text = StateDGV.SelectedRows == null ? "0" : StateDGV.SelectedRows.Count.ToString();

            int CheckedToDelete = 0;
            for (int i = 0; i < StateDGV.RowCount; i++)
            {
                var delete = StateDGV[DeleteCol.Index, i].Value;
                if (delete != null && (bool)delete)
                    CheckedToDelete++;
            }
            CheckedToDeleteLBL.Text = CheckedToDelete.ToString();
        }

        private void DeleteCheckedBtn_Click(object sender, EventArgs e)
        {
            //List<DataGridViewRow> ToDeleteRows = new List<DataGridViewRow>();
            for (int i = 0; i < StateDGV.RowCount; i++)
            {
                var delete = StateDGV[DeleteCol.Index, i].Value;
                if (delete != null && (bool)delete)
                {
                    //var SIndex = (int)StateDGV[SateIndexCol.Index, i].Value;
                    DeleteBackupState((BackupState)StateDGV.Rows[i].Tag);
                    //ToDeleteRows.Add(StateDGV.Rows[i]);
                    StateDGV.Rows.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
