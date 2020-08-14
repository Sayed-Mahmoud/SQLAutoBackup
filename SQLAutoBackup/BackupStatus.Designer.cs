namespace SQLAutoBackup
{
    partial class BackupStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupStatus));
            this.StateDGV = new System.Windows.Forms.DataGridView();
            this.SateIndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefDateTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullPathCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarningMessageCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalStatusLBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SelectedStatusLBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CheckedToDeleteLBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeleteCheckedBtn = new System.Windows.Forms.ToolStripDropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.StateDGV)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StateDGV
            // 
            this.StateDGV.AllowUserToAddRows = false;
            this.StateDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StateDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StateDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StateDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SateIndexCol,
            this.DateTimeCol,
            this.DefDateTimeCol,
            this.FullPathCol,
            this.WarningMessageCol,
            this.DeleteCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StateDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.StateDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateDGV.Location = new System.Drawing.Point(0, 0);
            this.StateDGV.Name = "StateDGV";
            this.StateDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StateDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StateDGV.Size = new System.Drawing.Size(764, 439);
            this.StateDGV.TabIndex = 0;
            // 
            // SateIndexCol
            // 
            this.SateIndexCol.HeaderText = "Index";
            this.SateIndexCol.Name = "SateIndexCol";
            this.SateIndexCol.ReadOnly = true;
            this.SateIndexCol.Visible = false;
            // 
            // DateTimeCol
            // 
            this.DateTimeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateTimeCol.HeaderText = "DateTime";
            this.DateTimeCol.Name = "DateTimeCol";
            this.DateTimeCol.ReadOnly = true;
            // 
            // DefDateTimeCol
            // 
            this.DefDateTimeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DefDateTimeCol.HeaderText = "Default DateTime";
            this.DefDateTimeCol.Name = "DefDateTimeCol";
            this.DefDateTimeCol.ReadOnly = true;
            // 
            // FullPathCol
            // 
            this.FullPathCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullPathCol.HeaderText = "Path";
            this.FullPathCol.Name = "FullPathCol";
            this.FullPathCol.ReadOnly = true;
            // 
            // WarningMessageCol
            // 
            this.WarningMessageCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WarningMessageCol.HeaderText = "Warning Message";
            this.WarningMessageCol.Name = "WarningMessageCol";
            this.WarningMessageCol.ReadOnly = true;
            // 
            // DeleteCol
            // 
            this.DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteCol.FillWeight = 50F;
            this.DeleteCol.HeaderText = "Delete";
            this.DeleteCol.Name = "DeleteCol";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TotalStatusLBL,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.SelectedStatusLBL,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.CheckedToDeleteLBL,
            this.toolStripStatusLabel7,
            this.DeleteCheckedBtn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(764, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel1.Text = "Total Status: ";
            // 
            // TotalStatusLBL
            // 
            this.TotalStatusLBL.BackColor = System.Drawing.Color.White;
            this.TotalStatusLBL.Name = "TotalStatusLBL";
            this.TotalStatusLBL.Size = new System.Drawing.Size(13, 17);
            this.TotalStatusLBL.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel3.Text = "Selected Status: ";
            // 
            // SelectedStatusLBL
            // 
            this.SelectedStatusLBL.BackColor = System.Drawing.Color.White;
            this.SelectedStatusLBL.Name = "SelectedStatusLBL";
            this.SelectedStatusLBL.Size = new System.Drawing.Size(13, 17);
            this.SelectedStatusLBL.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel4.Margin = new System.Windows.Forms.Padding(10, 3, 10, 2);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabel5.Text = "Checked to delete: ";
            // 
            // CheckedToDeleteLBL
            // 
            this.CheckedToDeleteLBL.BackColor = System.Drawing.Color.White;
            this.CheckedToDeleteLBL.Name = "CheckedToDeleteLBL";
            this.CheckedToDeleteLBL.Size = new System.Drawing.Size(13, 17);
            this.CheckedToDeleteLBL.Text = "0";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel7.Margin = new System.Windows.Forms.Padding(10, 3, 10, 2);
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel7.Text = "|";
            // 
            // DeleteCheckedBtn
            // 
            this.DeleteCheckedBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DeleteCheckedBtn.BackColor = System.Drawing.Color.White;
            this.DeleteCheckedBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DeleteCheckedBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteCheckedBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCheckedBtn.Name = "DeleteCheckedBtn";
            this.DeleteCheckedBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DeleteCheckedBtn.ShowDropDownArrow = false;
            this.DeleteCheckedBtn.Size = new System.Drawing.Size(119, 20);
            this.DeleteCheckedBtn.Text = "&Delete checked";
            this.DeleteCheckedBtn.ToolTipText = "Delete checked status";
            this.DeleteCheckedBtn.Click += new System.EventHandler(this.DeleteCheckedBtn_Click);
            // 
            // BackupStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.StateDGV);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "BackupStatus";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup Status";
            this.Load += new System.EventHandler(this.BackupStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StateDGV)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StateDGV;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SateIndexCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefDateTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullPathCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarningMessageCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DeleteCol;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TotalStatusLBL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel SelectedStatusLBL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel CheckedToDeleteLBL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripDropDownButton DeleteCheckedBtn;
    }
}