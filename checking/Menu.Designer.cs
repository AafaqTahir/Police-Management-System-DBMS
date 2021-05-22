namespace PMS
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblCriminals = new System.Windows.Forms.Label();
            this.lblOfficers = new System.Windows.Forms.Label();
            this.lblVictims = new System.Windows.Forms.Label();
            this.lblCase = new System.Windows.Forms.Label();
            this.lblCrime = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCriminals
            // 
            this.lblCriminals.AutoSize = true;
            this.lblCriminals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriminals.Location = new System.Drawing.Point(36, 116);
            this.lblCriminals.Name = "lblCriminals";
            this.lblCriminals.Size = new System.Drawing.Size(182, 20);
            this.lblCriminals.TabIndex = 0;
            this.lblCriminals.Text = "CRIMINALS RECORDS";
            this.lblCriminals.Click += new System.EventHandler(this.lblCriminals_Click);
            // 
            // lblOfficers
            // 
            this.lblOfficers.AutoSize = true;
            this.lblOfficers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficers.Location = new System.Drawing.Point(36, 165);
            this.lblOfficers.Name = "lblOfficers";
            this.lblOfficers.Size = new System.Drawing.Size(176, 20);
            this.lblOfficers.TabIndex = 1;
            this.lblOfficers.Text = "OFFICERS RECORDS";
            this.lblOfficers.Click += new System.EventHandler(this.lblOfficers_Click);
            // 
            // lblVictims
            // 
            this.lblVictims.AutoSize = true;
            this.lblVictims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictims.Location = new System.Drawing.Point(36, 211);
            this.lblVictims.Name = "lblVictims";
            this.lblVictims.Size = new System.Drawing.Size(159, 20);
            this.lblVictims.TabIndex = 2;
            this.lblVictims.Text = "VICTIMS RECORDS";
            this.lblVictims.Click += new System.EventHandler(this.lblVictims_Click);
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase.Location = new System.Drawing.Point(36, 254);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(138, 20);
            this.lblCase.TabIndex = 3;
            this.lblCase.Text = "CASE RECORDS";
            this.lblCase.Click += new System.EventHandler(this.lblCase_Click);
            // 
            // lblCrime
            // 
            this.lblCrime.AutoSize = true;
            this.lblCrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrime.Location = new System.Drawing.Point(36, 298);
            this.lblCrime.Name = "lblCrime";
            this.lblCrime.Size = new System.Drawing.Size(146, 20);
            this.lblCrime.TabIndex = 4;
            this.lblCrime.Text = "CRIME RECORDS";
            this.lblCrime.Click += new System.EventHandler(this.lblCrime_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(71, 396);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 489);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.lblCrime);
            this.Controls.Add(this.lblCase);
            this.Controls.Add(this.lblVictims);
            this.Controls.Add(this.lblOfficers);
            this.Controls.Add(this.lblCriminals);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCriminals;
        private System.Windows.Forms.Label lblOfficers;
        private System.Windows.Forms.Label lblVictims;
        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.Label lblCrime;
        private System.Windows.Forms.Button CancelButton;

    }
}