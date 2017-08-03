namespace Tomcat_Log_Deleted {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteLog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbPreview = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptbFacebook = new System.Windows.Forms.PictureBox();
            this.ptbInfo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.btnDeleteLog);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvData);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnPath});
            this.dgvData.Location = new System.Drawing.Point(6, 205);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(607, 242);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(446, 26);
            this.txtName.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(87, 93);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(446, 26);
            this.txtPath.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(274, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 36);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(403, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(547, 92);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(44, 28);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(547, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteLog
            // 
            this.btnDeleteLog.Location = new System.Drawing.Point(157, 150);
            this.btnDeleteLog.Name = "btnDeleteLog";
            this.btnDeleteLog.Size = new System.Drawing.Size(98, 36);
            this.btnDeleteLog.TabIndex = 4;
            this.btnDeleteLog.Text = "Delete Log";
            this.btnDeleteLog.UseVisualStyleBackColor = true;
            this.btnDeleteLog.Click += new System.EventHandler(this.btnDeleteLog_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("UTM Facebook", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1059, 52);
            this.label3.TabIndex = 1;
            this.label3.Text = "Log Deletor By minhphong306";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Tên";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.Width = 200;
            // 
            // columnPath
            // 
            this.columnPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPath.HeaderText = "Đường dẫn";
            this.columnPath.Name = "columnPath";
            this.columnPath.ReadOnly = true;
            // 
            // rtbPreview
            // 
            this.rtbPreview.Enabled = false;
            this.rtbPreview.Location = new System.Drawing.Point(6, 30);
            this.rtbPreview.Name = "rtbPreview";
            this.rtbPreview.Size = new System.Drawing.Size(529, 404);
            this.rtbPreview.TabIndex = 2;
            this.rtbPreview.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbPreview);
            this.groupBox2.Location = new System.Drawing.Point(644, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 444);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // ptbFacebook
            // 
            this.ptbFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbFacebook.Image = global::Tomcat_Log_Deleted.Properties.Resources.facebook;
            this.ptbFacebook.Location = new System.Drawing.Point(1114, 29);
            this.ptbFacebook.Name = "ptbFacebook";
            this.ptbFacebook.Size = new System.Drawing.Size(32, 32);
            this.ptbFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbFacebook.TabIndex = 4;
            this.ptbFacebook.TabStop = false;
            this.ptbFacebook.Click += new System.EventHandler(this.ptbFacebook_Click);
            // 
            // ptbInfo
            // 
            this.ptbInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbInfo.Image = global::Tomcat_Log_Deleted.Properties.Resources.info;
            this.ptbInfo.Location = new System.Drawing.Point(1066, 29);
            this.ptbInfo.Name = "ptbInfo";
            this.ptbInfo.Size = new System.Drawing.Size(32, 32);
            this.ptbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbInfo.TabIndex = 4;
            this.ptbInfo.TabStop = false;
            this.ptbInfo.Click += new System.EventHandler(this.ptbInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1197, 544);
            this.Controls.Add(this.ptbFacebook);
            this.Controls.Add(this.ptbInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Log Deletor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDeleteLog;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ptbInfo;
        private System.Windows.Forms.PictureBox ptbFacebook;
    }
}

