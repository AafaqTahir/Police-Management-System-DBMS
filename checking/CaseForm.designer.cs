namespace PMS
{
    partial class CaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseForm));
            this.lblCaseType = new System.Windows.Forms.Label();
            this.lblStartingDate = new System.Windows.Forms.Label();
            this.lblEndingDate = new System.Windows.Forms.Label();
            this.lblSolved = new System.Windows.Forms.Label();
            this.txtCaseType = new System.Windows.Forms.TextBox();
            this.txtStartingDate = new System.Windows.Forms.TextBox();
            this.txtEndingDate = new System.Windows.Forms.TextBox();
            this.txtSolved = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVictimID = new System.Windows.Forms.Label();
            this.txtOfficerID = new System.Windows.Forms.TextBox();
            this.txtVictimID = new System.Windows.Forms.TextBox();
            this.CaseGridView = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtCrimeID = new System.Windows.Forms.TextBox();
            this.lblCrimeID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CaseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaseType
            // 
            this.lblCaseType.AutoSize = true;
            this.lblCaseType.Location = new System.Drawing.Point(23, 61);
            this.lblCaseType.Name = "lblCaseType";
            this.lblCaseType.Size = new System.Drawing.Size(58, 13);
            this.lblCaseType.TabIndex = 0;
            this.lblCaseType.Text = "Case Type";
            // 
            // lblStartingDate
            // 
            this.lblStartingDate.AutoSize = true;
            this.lblStartingDate.Location = new System.Drawing.Point(23, 92);
            this.lblStartingDate.Name = "lblStartingDate";
            this.lblStartingDate.Size = new System.Drawing.Size(69, 13);
            this.lblStartingDate.TabIndex = 1;
            this.lblStartingDate.Text = "Starting Date";
            // 
            // lblEndingDate
            // 
            this.lblEndingDate.AutoSize = true;
            this.lblEndingDate.Location = new System.Drawing.Point(23, 127);
            this.lblEndingDate.Name = "lblEndingDate";
            this.lblEndingDate.Size = new System.Drawing.Size(66, 13);
            this.lblEndingDate.TabIndex = 2;
            this.lblEndingDate.Text = "Ending Date";
            // 
            // lblSolved
            // 
            this.lblSolved.AutoSize = true;
            this.lblSolved.Location = new System.Drawing.Point(23, 188);
            this.lblSolved.Name = "lblSolved";
            this.lblSolved.Size = new System.Drawing.Size(40, 13);
            this.lblSolved.TabIndex = 3;
            this.lblSolved.Text = "Solved";
            // 
            // txtCaseType
            // 
            this.txtCaseType.Location = new System.Drawing.Point(118, 58);
            this.txtCaseType.Name = "txtCaseType";
            this.txtCaseType.Size = new System.Drawing.Size(150, 20);
            this.txtCaseType.TabIndex = 4;
            // 
            // txtStartingDate
            // 
            this.txtStartingDate.Location = new System.Drawing.Point(118, 88);
            this.txtStartingDate.Name = "txtStartingDate";
            this.txtStartingDate.Size = new System.Drawing.Size(150, 20);
            this.txtStartingDate.TabIndex = 5;
            // 
            // txtEndingDate
            // 
            this.txtEndingDate.Location = new System.Drawing.Point(118, 119);
            this.txtEndingDate.Name = "txtEndingDate";
            this.txtEndingDate.Size = new System.Drawing.Size(150, 20);
            this.txtEndingDate.TabIndex = 5;
            // 
            // txtSolved
            // 
            this.txtSolved.Location = new System.Drawing.Point(118, 184);
            this.txtSolved.Name = "txtSolved";
            this.txtSolved.Size = new System.Drawing.Size(150, 20);
            this.txtSolved.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Officer Batch ID";
            // 
            // lblVictimID
            // 
            this.lblVictimID.AutoSize = true;
            this.lblVictimID.Location = new System.Drawing.Point(23, 220);
            this.lblVictimID.Name = "lblVictimID";
            this.lblVictimID.Size = new System.Drawing.Size(49, 13);
            this.lblVictimID.TabIndex = 8;
            this.lblVictimID.Text = "Victim ID";
            // 
            // txtOfficerID
            // 
            this.txtOfficerID.Location = new System.Drawing.Point(118, 153);
            this.txtOfficerID.Name = "txtOfficerID";
            this.txtOfficerID.Size = new System.Drawing.Size(150, 20);
            this.txtOfficerID.TabIndex = 10;
            // 
            // txtVictimID
            // 
            this.txtVictimID.Location = new System.Drawing.Point(118, 216);
            this.txtVictimID.Name = "txtVictimID";
            this.txtVictimID.Size = new System.Drawing.Size(150, 20);
            this.txtVictimID.TabIndex = 11;
            // 
            // CaseGridView
            // 
            this.CaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CaseGridView.Location = new System.Drawing.Point(294, 39);
            this.CaseGridView.Name = "CaseGridView";
            this.CaseGridView.Size = new System.Drawing.Size(583, 295);
            this.CaseGridView.TabIndex = 12;
            this.CaseGridView.DoubleClick += new System.EventHandler(this.CaseGridView_DoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(108, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(202, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(56, 353);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(163, 353);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCrimeID
            // 
            this.txtCrimeID.Location = new System.Drawing.Point(118, 248);
            this.txtCrimeID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrimeID.Name = "txtCrimeID";
            this.txtCrimeID.Size = new System.Drawing.Size(150, 20);
            this.txtCrimeID.TabIndex = 20;
            // 
            // lblCrimeID
            // 
            this.lblCrimeID.AutoSize = true;
            this.lblCrimeID.Location = new System.Drawing.Point(25, 251);
            this.lblCrimeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrimeID.Name = "lblCrimeID";
            this.lblCrimeID.Size = new System.Drawing.Size(47, 13);
            this.lblCrimeID.TabIndex = 21;
            this.lblCrimeID.Text = "Crime ID";
            // 
            // CaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(916, 487);
            this.Controls.Add(this.lblCrimeID);
            this.Controls.Add(this.txtCrimeID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.CaseGridView);
            this.Controls.Add(this.txtVictimID);
            this.Controls.Add(this.txtOfficerID);
            this.Controls.Add(this.lblVictimID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndingDate);
            this.Controls.Add(this.txtStartingDate);
            this.Controls.Add(this.txtSolved);
            this.Controls.Add(this.txtCaseType);
            this.Controls.Add(this.lblSolved);
            this.Controls.Add(this.lblEndingDate);
            this.Controls.Add(this.lblStartingDate);
            this.Controls.Add(this.lblCaseType);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "CaseForm";
            this.Text = "Case";
            this.Load += new System.EventHandler(this.CaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaseType;
        private System.Windows.Forms.Label lblStartingDate;
        private System.Windows.Forms.Label lblEndingDate;
        private System.Windows.Forms.Label lblSolved;
        private System.Windows.Forms.TextBox txtCaseType;
        private System.Windows.Forms.TextBox txtStartingDate;
        private System.Windows.Forms.TextBox txtEndingDate;
        private System.Windows.Forms.TextBox txtSolved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVictimID;
        private System.Windows.Forms.TextBox txtOfficerID;
        private System.Windows.Forms.TextBox txtVictimID;
        private System.Windows.Forms.DataGridView CaseGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtCrimeID;
        private System.Windows.Forms.Label lblCrimeID;
    }
}