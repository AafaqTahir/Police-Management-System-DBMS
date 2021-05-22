namespace PMS
{
    partial class VictimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VictimForm));
            this.VictimLabel = new System.Windows.Forms.Label();
            this.ID_CardLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.CaseNumber = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDCardTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.CaseNumberTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.VictimGridView = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.VictimGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VictimLabel
            // 
            this.VictimLabel.AutoSize = true;
            this.VictimLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.VictimLabel.Location = new System.Drawing.Point(20, 57);
            this.VictimLabel.Name = "VictimLabel";
            this.VictimLabel.Size = new System.Drawing.Size(35, 13);
            this.VictimLabel.TabIndex = 0;
            this.VictimLabel.Text = "Name";
            // 
            // ID_CardLabel
            // 
            this.ID_CardLabel.AutoSize = true;
            this.ID_CardLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ID_CardLabel.Location = new System.Drawing.Point(20, 105);
            this.ID_CardLabel.Name = "ID_CardLabel";
            this.ID_CardLabel.Size = new System.Drawing.Size(43, 13);
            this.ID_CardLabel.TabIndex = 1;
            this.ID_CardLabel.Text = "ID Card";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddressLabel.Location = new System.Drawing.Point(20, 151);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(20, 200);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 3;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // CaseNumber
            // 
            this.CaseNumber.AutoSize = true;
            this.CaseNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CaseNumber.Location = new System.Drawing.Point(20, 252);
            this.CaseNumber.Name = "CaseNumber";
            this.CaseNumber.Size = new System.Drawing.Size(68, 13);
            this.CaseNumber.TabIndex = 4;
            this.CaseNumber.Text = "CaseNumber";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(125, 50);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(135, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // IDCardTextBox
            // 
            this.IDCardTextBox.Location = new System.Drawing.Point(125, 98);
            this.IDCardTextBox.Name = "IDCardTextBox";
            this.IDCardTextBox.Size = new System.Drawing.Size(135, 20);
            this.IDCardTextBox.TabIndex = 6;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(125, 144);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(135, 20);
            this.AddressTextBox.TabIndex = 7;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(125, 193);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(135, 20);
            this.PhoneNumberTextBox.TabIndex = 8;
            // 
            // CaseNumberTextBox
            // 
            this.CaseNumberTextBox.Location = new System.Drawing.Point(125, 252);
            this.CaseNumberTextBox.Name = "CaseNumberTextBox";
            this.CaseNumberTextBox.Size = new System.Drawing.Size(135, 20);
            this.CaseNumberTextBox.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(23, 316);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(125, 316);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(232, 316);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(73, 369);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(185, 369);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // VictimGridView
            // 
            this.VictimGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VictimGridView.Location = new System.Drawing.Point(345, 50);
            this.VictimGridView.Name = "VictimGridView";
            this.VictimGridView.Size = new System.Drawing.Size(570, 342);
            this.VictimGridView.TabIndex = 15;
            this.VictimGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VictimGridView_CellContentClick);
            this.VictimGridView.DoubleClick += new System.EventHandler(this.VictimGridView_DoubleClick);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(898, 50);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 342);
            this.vScrollBar1.TabIndex = 16;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(345, 375);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(553, 17);
            this.hScrollBar1.TabIndex = 17;
            // 
            // VictimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 520);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.VictimGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CaseNumberTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.IDCardTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CaseNumber);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.ID_CardLabel);
            this.Controls.Add(this.VictimLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "VictimForm";
            this.Text = "Victims";
            this.Load += new System.EventHandler(this.VictimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VictimGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VictimLabel;
        private System.Windows.Forms.Label ID_CardLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label CaseNumber;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDCardTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox CaseNumberTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView VictimGridView;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

