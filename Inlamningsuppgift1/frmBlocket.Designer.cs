namespace Inlamningsuppgift1
{
    partial class frmBlocket
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
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstShowAdvert = new System.Windows.Forms.ListBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.txtSelectedAdvert = new System.Windows.Forms.TextBox();
            this.lblAllInfoAdvert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSearch
            // 
            this.cmdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdSearch.Location = new System.Drawing.Point(500, 69);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(59, 38);
            this.cmdSearch.TabIndex = 2;
            this.cmdSearch.Text = "Sök";
            this.cmdSearch.UseVisualStyleBackColor = false;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cmdLogin
            // 
            this.cmdLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdLogin.Location = new System.Drawing.Point(414, 12);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(187, 29);
            this.cmdLogin.TabIndex = 6;
            this.cmdLogin.Text = "Skapa konto/ Logga in";
            this.cmdLogin.UseVisualStyleBackColor = false;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(33, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(321, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // lstShowAdvert
            // 
            this.lstShowAdvert.FormattingEnabled = true;
            this.lstShowAdvert.ItemHeight = 16;
            this.lstShowAdvert.Location = new System.Drawing.Point(27, 121);
            this.lstShowAdvert.Name = "lstShowAdvert";
            this.lstShowAdvert.Size = new System.Drawing.Size(557, 292);
            this.lstShowAdvert.TabIndex = 4;
            this.lstShowAdvert.DoubleClick += new System.EventHandler(this.lstShowAdvert_DoubleClick);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(364, 76);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbCategory.TabIndex = 1;
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(463, 121);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(121, 24);
            this.cmbSort.TabIndex = 3;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // txtSelectedAdvert
            // 
            this.txtSelectedAdvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSelectedAdvert.Enabled = false;
            this.txtSelectedAdvert.Location = new System.Drawing.Point(33, 429);
            this.txtSelectedAdvert.Multiline = true;
            this.txtSelectedAdvert.Name = "txtSelectedAdvert";
            this.txtSelectedAdvert.Size = new System.Drawing.Size(551, 161);
            this.txtSelectedAdvert.TabIndex = 7;
            // 
            // lblAllInfoAdvert
            // 
            this.lblAllInfoAdvert.AutoSize = true;
            this.lblAllInfoAdvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAllInfoAdvert.Location = new System.Drawing.Point(37, 431);
            this.lblAllInfoAdvert.Name = "lblAllInfoAdvert";
            this.lblAllInfoAdvert.Size = new System.Drawing.Size(89, 153);
            this.lblAllInfoAdvert.TabIndex = 8;
            this.lblAllInfoAdvert.Text = "Anonns: \r\n\r\nKategori: \r\n\r\nBeskrivning: \r\n\r\nDatum: \r\n\r\nPris: \r\n";
            // 
            // frmBlocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 645);
            this.Controls.Add(this.lblAllInfoAdvert);
            this.Controls.Add(this.txtSelectedAdvert);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lstShowAdvert);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.cmdSearch);
            this.MaximizeBox = false;
            this.Name = "frmBlocket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blocket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstShowAdvert;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.TextBox txtSelectedAdvert;
        private System.Windows.Forms.Label lblAllInfoAdvert;
    }
}

