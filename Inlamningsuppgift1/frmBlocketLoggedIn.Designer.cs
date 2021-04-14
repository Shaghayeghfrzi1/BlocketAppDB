namespace Inlamningsuppgift1
{
    partial class frmBlocketLoggedIn
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
            this.lstShowAdvert = new System.Windows.Forms.ListBox();
            this.cmdLogout = new System.Windows.Forms.Button();
            this.cmdCreateAdvert = new System.Windows.Forms.Button();
            this.cmdUpdateAdvert = new System.Windows.Forms.Button();
            this.cmdDeleteAdvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.lblAllInfoAdvert = new System.Windows.Forms.Label();
            this.txtSelectedAdvert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstShowAdvert
            // 
            this.lstShowAdvert.FormattingEnabled = true;
            this.lstShowAdvert.ItemHeight = 16;
            this.lstShowAdvert.Location = new System.Drawing.Point(20, 83);
            this.lstShowAdvert.Name = "lstShowAdvert";
            this.lstShowAdvert.Size = new System.Drawing.Size(557, 260);
            this.lstShowAdvert.TabIndex = 1;
            this.lstShowAdvert.Click += new System.EventHandler(this.lstShowAdvert_Click);
            this.lstShowAdvert.DoubleClick += new System.EventHandler(this.lstShowAdvert_DoubleClick);
            // 
            // cmdLogout
            // 
            this.cmdLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdLogout.Location = new System.Drawing.Point(464, 12);
            this.cmdLogout.Name = "cmdLogout";
            this.cmdLogout.Size = new System.Drawing.Size(88, 29);
            this.cmdLogout.TabIndex = 0;
            this.cmdLogout.Text = "Logga ut";
            this.cmdLogout.UseVisualStyleBackColor = false;
            this.cmdLogout.Click += new System.EventHandler(this.cmdLogout_Click);
            // 
            // cmdCreateAdvert
            // 
            this.cmdCreateAdvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdCreateAdvert.Location = new System.Drawing.Point(32, 358);
            this.cmdCreateAdvert.Name = "cmdCreateAdvert";
            this.cmdCreateAdvert.Size = new System.Drawing.Size(143, 35);
            this.cmdCreateAdvert.TabIndex = 2;
            this.cmdCreateAdvert.Text = "Skapa ny annons";
            this.cmdCreateAdvert.UseVisualStyleBackColor = false;
            this.cmdCreateAdvert.Click += new System.EventHandler(this.cmdCreateAdvert_Click);
            // 
            // cmdUpdateAdvert
            // 
            this.cmdUpdateAdvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdUpdateAdvert.Enabled = false;
            this.cmdUpdateAdvert.Location = new System.Drawing.Point(218, 358);
            this.cmdUpdateAdvert.Name = "cmdUpdateAdvert";
            this.cmdUpdateAdvert.Size = new System.Drawing.Size(143, 35);
            this.cmdUpdateAdvert.TabIndex = 3;
            this.cmdUpdateAdvert.Text = "Uppdatera";
            this.cmdUpdateAdvert.UseVisualStyleBackColor = false;
            this.cmdUpdateAdvert.Click += new System.EventHandler(this.cmdUpdateAdvert_Click);
            // 
            // cmdDeleteAdvert
            // 
            this.cmdDeleteAdvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdDeleteAdvert.Enabled = false;
            this.cmdDeleteAdvert.Location = new System.Drawing.Point(404, 358);
            this.cmdDeleteAdvert.Name = "cmdDeleteAdvert";
            this.cmdDeleteAdvert.Size = new System.Drawing.Size(143, 35);
            this.cmdDeleteAdvert.TabIndex = 4;
            this.cmdDeleteAdvert.Text = "Ta bort";
            this.cmdDeleteAdvert.UseVisualStyleBackColor = false;
            this.cmdDeleteAdvert.Click += new System.EventHandler(this.cmdDeleteAdvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dina annonser: ";
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdRefresh.Location = new System.Drawing.Point(502, 107);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(75, 23);
            this.cmdRefresh.TabIndex = 15;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = false;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(456, 83);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(121, 24);
            this.cmbSort.TabIndex = 17;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // lblAllInfoAdvert
            // 
            this.lblAllInfoAdvert.AutoSize = true;
            this.lblAllInfoAdvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAllInfoAdvert.Location = new System.Drawing.Point(24, 429);
            this.lblAllInfoAdvert.Name = "lblAllInfoAdvert";
            this.lblAllInfoAdvert.Size = new System.Drawing.Size(89, 153);
            this.lblAllInfoAdvert.TabIndex = 19;
            this.lblAllInfoAdvert.Text = "Anonns: \r\n\r\nKategori: \r\n\r\nBeskrivning: \r\n\r\nDatum: \r\n\r\nPris: \r\n";
            // 
            // txtSelectedAdvert
            // 
            this.txtSelectedAdvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSelectedAdvert.Enabled = false;
            this.txtSelectedAdvert.Location = new System.Drawing.Point(20, 427);
            this.txtSelectedAdvert.Multiline = true;
            this.txtSelectedAdvert.Name = "txtSelectedAdvert";
            this.txtSelectedAdvert.Size = new System.Drawing.Size(551, 161);
            this.txtSelectedAdvert.TabIndex = 18;
            // 
            // frmBlocketLoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 645);
            this.Controls.Add(this.lblAllInfoAdvert);
            this.Controls.Add(this.txtSelectedAdvert);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDeleteAdvert);
            this.Controls.Add(this.cmdUpdateAdvert);
            this.Controls.Add(this.cmdCreateAdvert);
            this.Controls.Add(this.lstShowAdvert);
            this.Controls.Add(this.cmdLogout);
            this.MaximizeBox = false;
            this.Name = "frmBlocketLoggedIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blocket(Inloggad)";
            this.Load += new System.EventHandler(this.frmBlocketLoggedIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstShowAdvert;
        private System.Windows.Forms.Button cmdLogout;
        private System.Windows.Forms.Button cmdCreateAdvert;
        private System.Windows.Forms.Button cmdUpdateAdvert;
        private System.Windows.Forms.Button cmdDeleteAdvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label lblAllInfoAdvert;
        private System.Windows.Forms.TextBox txtSelectedAdvert;
    }
}