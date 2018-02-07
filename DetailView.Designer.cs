namespace EQManager
{
    partial class DetailView
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridDetailView = new System.Windows.Forms.DataGridView();
            this.colUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBoardType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBoardSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSplitter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIncomeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuitemHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.editDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridDetailView
            // 
            this.dataGridDetailView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dataGridDetailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //this.colUse,
            //this.colSystem,
            //this.colManageNumber,
            //this.colSerial,
            //this.colBoardType,
            //this.colBoardSerial,
            //this.colSplitter,
            //this.colCPU,
            //this.colRAM,
            //this.colHDD,
            //this.colVGA,
            //this.colUser,
            //this.colLoc,
            //this.colIncomeDate,
            //this.colNote});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDetailView.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridDetailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDetailView.Location = new System.Drawing.Point(0, 0);
            this.dataGridDetailView.MultiSelect = false;
            this.dataGridDetailView.Name = "dataGridDetailView";
            this.dataGridDetailView.RowHeadersVisible = false;
            this.dataGridDetailView.RowTemplate.Height = 23;
            this.dataGridDetailView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDetailView.Size = new System.Drawing.Size(1058, 299);
            this.dataGridDetailView.TabIndex = 1;
            this.dataGridDetailView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridDetailView_CellMouseDown);
            this.dataGridDetailView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridDetailView_MouseClick);
            // 
            // colUse
            // 
            this.colUse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colUse.DefaultCellStyle = dataGridViewCellStyle6;
            this.colUse.HeaderText = "use";
            this.colUse.Name = "colUse";
            this.colUse.ReadOnly = true;
            this.colUse.Width = 51;
            // 
            // colSystem
            // 
            this.colSystem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSystem.HeaderText = "system";
            this.colSystem.Name = "colSystem";
            this.colSystem.Width = 72;
            // 
            // colManageNumber
            // 
            this.colManageNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colManageNumber.DefaultCellStyle = dataGridViewCellStyle7;
            this.colManageNumber.HeaderText = "ManageNum";
            this.colManageNumber.Name = "colManageNumber";
            this.colManageNumber.ReadOnly = true;
            this.colManageNumber.Width = 103;
            // 
            // colSerial
            // 
            this.colSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colSerial.DefaultCellStyle = dataGridViewCellStyle8;
            this.colSerial.HeaderText = "SerialNum";
            this.colSerial.Name = "colSerial";
            this.colSerial.Width = 89;
            // 
            // colBoardType
            // 
            this.colBoardType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colBoardType.HeaderText = "BoardType";
            this.colBoardType.Name = "colBoardType";
            this.colBoardType.Width = 92;
            // 
            // colBoardSerial
            // 
            this.colBoardSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colBoardSerial.DefaultCellStyle = dataGridViewCellStyle9;
            this.colBoardSerial.HeaderText = "BoardSerialNum";
            this.colBoardSerial.Name = "colBoardSerial";
            this.colBoardSerial.Width = 122;
            // 
            // colSplitter
            // 
            this.colSplitter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSplitter.HeaderText = "Splitter";
            this.colSplitter.Name = "colSplitter";
            this.colSplitter.Width = 68;
            // 
            // colCPU
            // 
            this.colCPU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCPU.HeaderText = "CPU";
            this.colCPU.Name = "colCPU";
            this.colCPU.Width = 55;
            // 
            // colRAM
            // 
            this.colRAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colRAM.HeaderText = "RAM";
            this.colRAM.Name = "colRAM";
            this.colRAM.Width = 57;
            // 
            // colHDD
            // 
            this.colHDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colHDD.HeaderText = "HDD";
            this.colHDD.Name = "colHDD";
            this.colHDD.Width = 54;
            // 
            // colVGA
            // 
            this.colVGA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colVGA.HeaderText = "VGA";
            this.colVGA.Name = "colVGA";
            this.colVGA.Width = 55;
            // 
            // colUser
            // 
            this.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUser.HeaderText = "UserName";
            this.colUser.Name = "colUser";
            this.colUser.Width = 90;
            // 
            // colLoc
            // 
            this.colLoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colLoc.HeaderText = "Location";
            this.colLoc.Name = "colLoc";
            this.colLoc.Width = 78;
            // 
            // colIncomeDate
            // 
            this.colIncomeDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colIncomeDate.HeaderText = "IncomingDate";
            this.colIncomeDate.Name = "colIncomeDate";
            this.colIncomeDate.Width = 107;
            // 
            // colNote
            // 
            this.colNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colNote.HeaderText = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Width = 56;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemHistory,
            this.editDataToolStripMenuItem,
            this.deleteDataToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // menuitemHistory
            // 
            this.menuitemHistory.Name = "menuitemHistory";
            this.menuitemHistory.Size = new System.Drawing.Size(152, 22);
            this.menuitemHistory.Text = "view history";
            this.menuitemHistory.Click += new System.EventHandler(this.menuitemHistory_Click);
            // 
            // editDataToolStripMenuItem
            // 
            this.editDataToolStripMenuItem.Name = "editDataToolStripMenuItem";
            this.editDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editDataToolStripMenuItem.Text = "edit data";
            this.editDataToolStripMenuItem.Click += new System.EventHandler(this.editDataToolStripMenuItem_Click);
            // 
            // deleteDataToolStripMenuItem
            // 
            this.deleteDataToolStripMenuItem.Name = "deleteDataToolStripMenuItem";
            this.deleteDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteDataToolStripMenuItem.Text = "delete data";
            this.deleteDataToolStripMenuItem.Click += new System.EventHandler(this.deleteDataToolStripMenuItem_Click);
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridDetailView);
            this.Name = "DetailView";
            this.Size = new System.Drawing.Size(1058, 299);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDetailView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuitemHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoardSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSplitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIncomeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.ToolStripMenuItem editDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDataToolStripMenuItem;
    }
}
