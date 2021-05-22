namespace PMS
{
    partial class CriminalsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriminalsForm));
            this.namelbl = new System.Windows.Forms.Label();
            this.agelbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.crimeslbl = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.crimeIDlbl = new System.Windows.Forms.Label();
            this.caselbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.arrestTxt = new System.Windows.Forms.TextBox();
            this.caseNoTxt = new System.Windows.Forms.TextBox();
            this.crimesTxt = new System.Windows.Forms.TextBox();
            this.batchIDTxt = new System.Windows.Forms.TextBox();
            this.crimeIDTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.criminalsGridView = new System.Windows.Forms.DataGridView();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(47, 38);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(35, 13);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Name";
           
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Location = new System.Drawing.Point(47, 78);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(26, 13);
            this.agelbl.TabIndex = 1;
            this.agelbl.Text = "Age";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Location = new System.Drawing.Point(331, 38);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(45, 13);
            this.addresslbl.TabIndex = 2;
            this.addresslbl.Text = "Address";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(304, 81);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(72, 13);
            this.datelbl.TabIndex = 3;
            this.datelbl.Text = "Date of Arrest";
            // 
            // crimeslbl
            // 
            this.crimeslbl.AutoSize = true;
            this.crimeslbl.Location = new System.Drawing.Point(603, 81);
            this.crimeslbl.Name = "crimeslbl";
            this.crimeslbl.Size = new System.Drawing.Size(67, 13);
            this.crimeslbl.TabIndex = 4;
            this.crimeslbl.Text = "No of Crimes";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(587, 128);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(83, 13);
            this.idlbl.TabIndex = 5;
            this.idlbl.Text = "Officer Batch ID";
            // 
            // crimeIDlbl
            // 
            this.crimeIDlbl.AutoSize = true;
            this.crimeIDlbl.Location = new System.Drawing.Point(45, 121);
            this.crimeIDlbl.Name = "crimeIDlbl";
            this.crimeIDlbl.Size = new System.Drawing.Size(47, 13);
            this.crimeIDlbl.TabIndex = 6;
            this.crimeIDlbl.Text = "Crime ID";
            // 
            // caselbl
            // 
            this.caselbl.AutoSize = true;
            this.caselbl.Location = new System.Drawing.Point(331, 121);
            this.caselbl.Name = "caselbl";
            this.caselbl.Size = new System.Drawing.Size(48, 13);
            this.caselbl.TabIndex = 7;
            this.caselbl.Text = "Case No";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(122, 35);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(164, 20);
            this.nameTxt.TabIndex = 8;
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(122, 78);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(164, 20);
            this.ageTxt.TabIndex = 9;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(406, 35);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(458, 20);
            this.addressTxt.TabIndex = 10;
            // 
            // arrestTxt
            // 
            this.arrestTxt.Location = new System.Drawing.Point(406, 78);
            this.arrestTxt.Name = "arrestTxt";
            this.arrestTxt.Size = new System.Drawing.Size(164, 20);
            this.arrestTxt.TabIndex = 11;
            // 
            // caseNoTxt
            // 
            this.caseNoTxt.Location = new System.Drawing.Point(406, 121);
            this.caseNoTxt.Name = "caseNoTxt";
            this.caseNoTxt.Size = new System.Drawing.Size(164, 20);
            this.caseNoTxt.TabIndex = 12;
            // 
            // crimesTxt
            // 
            this.crimesTxt.Location = new System.Drawing.Point(700, 81);
            this.crimesTxt.Name = "crimesTxt";
            this.crimesTxt.Size = new System.Drawing.Size(164, 20);
            this.crimesTxt.TabIndex = 13;
            // 
            // batchIDTxt
            // 
            this.batchIDTxt.Location = new System.Drawing.Point(700, 125);
            this.batchIDTxt.Name = "batchIDTxt";
            this.batchIDTxt.Size = new System.Drawing.Size(164, 20);
            this.batchIDTxt.TabIndex = 14;
            // 
            // crimeIDTxt
            // 
            this.crimeIDTxt.Location = new System.Drawing.Point(120, 118);
            this.crimeIDTxt.Name = "crimeIDTxt";
            this.crimeIDTxt.Size = new System.Drawing.Size(164, 20);
            this.crimeIDTxt.TabIndex = 15;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(59, 172);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(379, 172);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(495, 172);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(158, 172);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(269, 172);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // criminalsGridView
            // 
            this.criminalsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criminalsGridView.Location = new System.Drawing.Point(-1, 210);
            this.criminalsGridView.Name = "criminalsGridView";
            this.criminalsGridView.Size = new System.Drawing.Size(922, 207);
            this.criminalsGridView.TabIndex = 21;
            this.criminalsGridView.DoubleClick += new System.EventHandler(this.criminalsGridView_DoubleClick);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(6, 406);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(905, 17);
            this.hScrollBar1.TabIndex = 22;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(909, 210);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 207);
            this.vScrollBar1.TabIndex = 23;
            // 
            // CriminalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 451);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.criminalsGridView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.crimeIDTxt);
            this.Controls.Add(this.batchIDTxt);
            this.Controls.Add(this.crimesTxt);
            this.Controls.Add(this.caseNoTxt);
            this.Controls.Add(this.arrestTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.caselbl);
            this.Controls.Add(this.crimeIDlbl);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.crimeslbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.agelbl);
            this.Controls.Add(this.namelbl);
            this.Name = "CriminalsForm";
            this.Text = "Criminals";
            this.Load += new System.EventHandler(this.CriminalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.criminalsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label crimeslbl;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label crimeIDlbl;
        private System.Windows.Forms.Label caselbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox arrestTxt;
        private System.Windows.Forms.TextBox caseNoTxt;
        private System.Windows.Forms.TextBox crimesTxt;
        private System.Windows.Forms.TextBox batchIDTxt;
        private System.Windows.Forms.TextBox crimeIDTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView criminalsGridView;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

