namespace EQManager
{
    partial class AddDataForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTransation = new System.Windows.Forms.Button();
            this.detailView1 = new EQManager.DetailView();
            this.inputControl1 = new EQManager.InputControl();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(468, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(467, 475);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnTransation
            // 
            this.btnTransation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransation.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTransation.Location = new System.Drawing.Point(374, 475);
            this.btnTransation.Name = "btnTransation";
            this.btnTransation.Size = new System.Drawing.Size(87, 23);
            this.btnTransation.TabIndex = 29;
            this.btnTransation.Text = "Transaction";
            this.btnTransation.UseVisualStyleBackColor = true;
            this.btnTransation.Click += new System.EventHandler(this.btnTransation_Click);
            // 
            // detailView1
            // 
            this.detailView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailView1.Location = new System.Drawing.Point(12, 343);
            this.detailView1.Name = "detailView1";
            this.detailView1.Size = new System.Drawing.Size(530, 126);
            this.detailView1.TabIndex = 28;
            // 
            // inputControl1
            // 
            this.inputControl1.Location = new System.Drawing.Point(12, 12);
            this.inputControl1.Name = "inputControl1";
            this.inputControl1.Size = new System.Drawing.Size(539, 303);
            this.inputControl1.TabIndex = 30;
            // 
            // AddDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 508);
            this.Controls.Add(this.inputControl1);
            this.Controls.Add(this.btnTransation);
            this.Controls.Add(this.detailView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddDataForm";
            this.Text = "AddDataForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private DetailView detailView1;
        private System.Windows.Forms.Button btnTransation;
        private InputControl inputControl1;
    }
}