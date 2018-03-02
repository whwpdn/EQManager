namespace EQManager
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lvModel = new System.Windows.Forms.ListView();
            this.tabViewDetail = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.cbBoardType = new System.Windows.Forms.CheckBox();
            this.cbManageNum = new System.Windows.Forms.CheckBox();
            this.cbSystem = new System.Windows.Forms.CheckBox();
            this.tbSearchWord = new System.Windows.Forms.TextBox();
            this.comboCondition = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.detailEquipment = new EQManager.DetailView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.detailBoard = new EQManager.DetailView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lvBoard = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.tabViewDetail.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.addToolStripMenuItem.Text = "add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem1.Text = "edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // lvModel
            // 
            this.lvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvModel.Location = new System.Drawing.Point(3, 3);
            this.lvModel.Name = "lvModel";
            this.lvModel.Size = new System.Drawing.Size(186, 424);
            this.lvModel.TabIndex = 1;
            this.lvModel.UseCompatibleStateImageBehavior = false;
            this.lvModel.View = System.Windows.Forms.View.List;
            this.lvModel.SelectedIndexChanged += new System.EventHandler(this.lvModel_SelectedIndexChanged);
            // 
            // tabViewDetail
            // 
            this.tabViewDetail.Controls.Add(this.tabPage1);
            this.tabViewDetail.Controls.Add(this.tabPage2);
            this.tabViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabViewDetail.Location = new System.Drawing.Point(200, 24);
            this.tabViewDetail.Name = "tabViewDetail";
            this.tabViewDetail.SelectedIndex = 0;
            this.tabViewDetail.Size = new System.Drawing.Size(1025, 456);
            this.tabViewDetail.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1017, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "equipment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnUserSearch);
            this.splitContainer1.Panel1.Controls.Add(this.lbUser);
            this.splitContainer1.Panel1.Controls.Add(this.lbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.comboUser);
            this.splitContainer1.Panel1.Controls.Add(this.cbBoardType);
            this.splitContainer1.Panel1.Controls.Add(this.cbManageNum);
            this.splitContainer1.Panel1.Controls.Add(this.cbSystem);
            this.splitContainer1.Panel1.Controls.Add(this.tbSearchWord);
            this.splitContainer1.Panel1.Controls.Add(this.comboCondition);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.detailEquipment);
            this.splitContainer1.Size = new System.Drawing.Size(1011, 424);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Location = new System.Drawing.Point(181, 28);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(75, 20);
            this.btnUserSearch.TabIndex = 9;
            this.btnUserSearch.Text = "Search";
            this.btnUserSearch.UseVisualStyleBackColor = true;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(3, 32);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(31, 12);
            this.lbUser.TabIndex = 8;
            this.lbUser.Text = "User";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(3, 6);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(45, 12);
            this.lbSearch.TabIndex = 7;
            this.lbSearch.Text = "Search";
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(54, 29);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(121, 20);
            this.comboUser.TabIndex = 6;
            // 
            // cbBoardType
            // 
            this.cbBoardType.AutoSize = true;
            this.cbBoardType.Location = new System.Drawing.Point(544, 3);
            this.cbBoardType.Name = "cbBoardType";
            this.cbBoardType.Size = new System.Drawing.Size(86, 16);
            this.cbBoardType.TabIndex = 5;
            this.cbBoardType.Text = "BoardType";
            this.cbBoardType.UseVisualStyleBackColor = true;
            // 
            // cbManageNum
            // 
            this.cbManageNum.AutoSize = true;
            this.cbManageNum.Location = new System.Drawing.Point(441, 4);
            this.cbManageNum.Name = "cbManageNum";
            this.cbManageNum.Size = new System.Drawing.Size(97, 16);
            this.cbManageNum.TabIndex = 4;
            this.cbManageNum.Text = "ManageNum";
            this.cbManageNum.UseVisualStyleBackColor = true;
            // 
            // cbSystem
            // 
            this.cbSystem.AutoSize = true;
            this.cbSystem.Location = new System.Drawing.Point(369, 3);
            this.cbSystem.Name = "cbSystem";
            this.cbSystem.Size = new System.Drawing.Size(66, 16);
            this.cbSystem.TabIndex = 3;
            this.cbSystem.Text = "system";
            this.cbSystem.UseVisualStyleBackColor = true;
            // 
            // tbSearchWord
            // 
            this.tbSearchWord.Location = new System.Drawing.Point(181, 2);
            this.tbSearchWord.Name = "tbSearchWord";
            this.tbSearchWord.Size = new System.Drawing.Size(100, 21);
            this.tbSearchWord.TabIndex = 2;
            // 
            // comboCondition
            // 
            this.comboCondition.FormattingEnabled = true;
            this.comboCondition.Items.AddRange(new object[] {
            "All",
            "System",
            "Management",
            "BoardType"});
            this.comboCondition.Location = new System.Drawing.Point(54, 3);
            this.comboCondition.Name = "comboCondition";
            this.comboCondition.Size = new System.Drawing.Size(121, 20);
            this.comboCondition.TabIndex = 1;
            this.comboCondition.SelectedIndexChanged += new System.EventHandler(this.comboCondition_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(287, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // detailEquipment
            // 
            this.detailEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailEquipment.Location = new System.Drawing.Point(0, 0);
            this.detailEquipment.Name = "detailEquipment";
            this.detailEquipment.Size = new System.Drawing.Size(1011, 359);
            this.detailEquipment.TabIndex = 0;
            this.detailEquipment.ViewType = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.detailBoard);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "board";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // detailBoard
            // 
            this.detailBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailBoard.Location = new System.Drawing.Point(3, 3);
            this.detailBoard.Name = "detailBoard";
            this.detailBoard.Size = new System.Drawing.Size(1011, 424);
            this.detailBoard.TabIndex = 0;
            this.detailBoard.ViewType = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 456);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvModel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 430);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "equipment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lvBoard);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 430);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "board";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lvBoard
            // 
            this.lvBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBoard.Location = new System.Drawing.Point(3, 3);
            this.lvBoard.Name = "lvBoard";
            this.lvBoard.Size = new System.Drawing.Size(186, 424);
            this.lvBoard.TabIndex = 2;
            this.lvBoard.UseCompatibleStateImageBehavior = false;
            this.lvBoard.View = System.Windows.Forms.View.List;
            this.lvBoard.SelectedIndexChanged += new System.EventHandler(this.lvBoard_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 480);
            this.Controls.Add(this.tabViewDetail);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabViewDetail.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ListView lvModel;
        private System.Windows.Forms.TabControl tabViewDetail;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DetailView detailEquipment;
        private System.Windows.Forms.TextBox tbSearchWord;
        private System.Windows.Forms.ComboBox comboCondition;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.CheckBox cbBoardType;
        private System.Windows.Forms.CheckBox cbManageNum;
        private System.Windows.Forms.CheckBox cbSystem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lvBoard;
        private DetailView detailBoard;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
    }
}

