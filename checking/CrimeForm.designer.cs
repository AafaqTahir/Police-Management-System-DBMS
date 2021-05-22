namespace PMS
{
    partial class CrimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrimeForm));
            this.crimeTypelbl = new System.Windows.Forms.Label();
            this.crimeDatelbl = new System.Windows.Forms.Label();
            this.locationlbl = new System.Windows.Forms.Label();
            this.arrestlbl = new System.Windows.Forms.Label();
            this.crimeTxt = new System.Windows.Forms.TextBox();
            this.crimeDateTxt = new System.Windows.Forms.TextBox();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.arrestTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.CrimeGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CrimeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // crimeTypelbl
            // 
            this.crimeTypelbl.AutoSize = true;
            this.crimeTypelbl.Location = new System.Drawing.Point(46, 42);
            this.crimeTypelbl.Name = "crimeTypelbl";
            this.crimeTypelbl.Size = new System.Drawing.Size(60, 13);
            this.crimeTypelbl.TabIndex = 0;
            this.crimeTypelbl.Text = "Crime Type";
            // 
            // crimeDatelbl
            // 
            this.crimeDatelbl.AutoSize = true;
            this.crimeDatelbl.Location = new System.Drawing.Point(46, 88);
            this.crimeDatelbl.Name = "crimeDatelbl";
            this.crimeDatelbl.Size = new System.Drawing.Size(59, 13);
            this.crimeDatelbl.TabIndex = 1;
            this.crimeDatelbl.Text = "Crime Date";
            // 
            // locationlbl
            // 
            this.locationlbl.AutoSize = true;
            this.locationlbl.Location = new System.Drawing.Point(46, 133);
            this.locationlbl.Name = "locationlbl";
            this.locationlbl.Size = new System.Drawing.Size(48, 13);
            this.locationlbl.TabIndex = 2;
            this.locationlbl.Text = "Location";
            // 
            // arrestlbl
            // 
            this.arrestlbl.AutoSize = true;
            this.arrestlbl.Location = new System.Drawing.Point(6, 179);
            this.arrestlbl.Name = "arrestlbl";
            this.arrestlbl.Size = new System.Drawing.Size(99, 13);
            this.arrestlbl.TabIndex = 3;
            this.arrestlbl.Text = "No of People Arrest";
            // 
            // crimeTxt
            // 
            this.crimeTxt.Location = new System.Drawing.Point(115, 39);
            this.crimeTxt.Name = "crimeTxt";
            this.crimeTxt.Size = new System.Drawing.Size(183, 20);
            this.crimeTxt.TabIndex = 4;
            // 
            // crimeDateTxt
            // 
            this.crimeDateTxt.Location = new System.Drawing.Point(115, 85);
            this.crimeDateTxt.Name = "crimeDateTxt";
            this.crimeDateTxt.Size = new System.Drawing.Size(183, 20);
            this.crimeDateTxt.TabIndex = 4;
            // 
            // locationTxt
            // 
            this.locationTxt.Location = new System.Drawing.Point(115, 130);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(183, 20);
            this.locationTxt.TabIndex = 4;
            // 
            // arrestTxt
            // 
            this.arrestTxt.Location = new System.Drawing.Point(115, 176);
            this.arrestTxt.Name = "arrestTxt";
            this.arrestTxt.Size = new System.Drawing.Size(183, 20);
            this.arrestTxt.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(49, 234);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(142, 234);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(232, 234);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(91, 278);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(197, 278);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CrimeGridView
            // 
            this.CrimeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CrimeGridView.Location = new System.Drawing.Point(327, 2);
            this.CrimeGridView.Name = "CrimeGridView";
            this.CrimeGridView.Size = new System.Drawing.Size(573, 299);
            this.CrimeGridView.TabIndex = 7;
            this.CrimeGridView.DoubleClick += new System.EventHandler(this.CrimeGridView_DoubleClick);
            // 
            // CrimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 415);
            this.Controls.Add(this.CrimeGridView);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.arrestTxt);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.crimeDateTxt);
            this.Controls.Add(this.crimeTxt);
            this.Controls.Add(this.arrestlbl);
            this.Controls.Add(this.locationlbl);
            this.Controls.Add(this.crimeDatelbl);
            this.Controls.Add(this.crimeTypelbl);
            this.Name = "CrimeForm";
            this.Text = "Crime";
            this.Load += new System.EventHandler(this.CrimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CrimeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label crimeTypelbl;
        private System.Windows.Forms.Label crimeDatelbl;
        private System.Windows.Forms.Label locationlbl;
        private System.Windows.Forms.Label arrestlbl;
        private System.Windows.Forms.TextBox crimeTxt;
        private System.Windows.Forms.TextBox crimeDateTxt;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.TextBox arrestTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView CrimeGridView;
    }
}