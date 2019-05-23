namespace YazilimYapimi
{
    partial class TestForm
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
            this.txtCevap = new MetroFramework.Controls.MetroTextBox();
            this.btnCevap = new MetroFramework.Controls.MetroButton();
            this.btnYeniKelime = new MetroFramework.Controls.MetroButton();
            this.btnGeri = new MetroFramework.Controls.MetroButton();
            this.lblGizlenmisCvp = new MetroFramework.Controls.MetroLabel();
            this.lblGizlenmisSoru = new MetroFramework.Controls.MetroLabel();
            this.lblGizlenmisYil = new MetroFramework.Controls.MetroLabel();
            this.lblGizlenmisAy = new MetroFramework.Controls.MetroLabel();
            this.lblSoru = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtCevap
            // 
            // 
            // 
            // 
            this.txtCevap.CustomButton.Image = null;
            this.txtCevap.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtCevap.CustomButton.Name = "";
            this.txtCevap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCevap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCevap.CustomButton.TabIndex = 1;
            this.txtCevap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCevap.CustomButton.UseSelectable = true;
            this.txtCevap.CustomButton.Visible = false;
            this.txtCevap.Lines = new string[0];
            this.txtCevap.Location = new System.Drawing.Point(169, 97);
            this.txtCevap.MaxLength = 32767;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.PasswordChar = '\0';
            this.txtCevap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCevap.SelectedText = "";
            this.txtCevap.SelectionLength = 0;
            this.txtCevap.SelectionStart = 0;
            this.txtCevap.Size = new System.Drawing.Size(90, 23);
            this.txtCevap.TabIndex = 1;
            this.txtCevap.UseSelectable = true;
            this.txtCevap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCevap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCevap
            // 
            this.btnCevap.BackColor = System.Drawing.Color.DarkGray;
            this.btnCevap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCevap.Location = new System.Drawing.Point(41, 166);
            this.btnCevap.Name = "btnCevap";
            this.btnCevap.Size = new System.Drawing.Size(68, 21);
            this.btnCevap.TabIndex = 2;
            this.btnCevap.Text = "Cevapla";
            this.btnCevap.UseCustomBackColor = true;
            this.btnCevap.UseCustomForeColor = true;
            this.btnCevap.UseSelectable = true;
            this.btnCevap.UseStyleColors = true;
            this.btnCevap.UseWaitCursor = true;
            this.btnCevap.Click += new System.EventHandler(this.btnCevap_Click);
            // 
            // btnYeniKelime
            // 
            this.btnYeniKelime.BackColor = System.Drawing.Color.DarkGray;
            this.btnYeniKelime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYeniKelime.Location = new System.Drawing.Point(155, 165);
            this.btnYeniKelime.Name = "btnYeniKelime";
            this.btnYeniKelime.Size = new System.Drawing.Size(73, 22);
            this.btnYeniKelime.TabIndex = 3;
            this.btnYeniKelime.Text = "Yeni Kelime";
            this.btnYeniKelime.UseCustomBackColor = true;
            this.btnYeniKelime.UseCustomForeColor = true;
            this.btnYeniKelime.UseSelectable = true;
            this.btnYeniKelime.UseStyleColors = true;
            this.btnYeniKelime.UseWaitCursor = true;
            this.btnYeniKelime.Click += new System.EventHandler(this.btnYeniKelime_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.DarkGray;
            this.btnGeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGeri.Location = new System.Drawing.Point(286, 166);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(55, 23);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseCustomBackColor = true;
            this.btnGeri.UseCustomForeColor = true;
            this.btnGeri.UseSelectable = true;
            this.btnGeri.UseStyleColors = true;
            this.btnGeri.UseWaitCursor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblGizlenmisCvp
            // 
            this.lblGizlenmisCvp.AutoSize = true;
            this.lblGizlenmisCvp.Location = new System.Drawing.Point(271, 39);
            this.lblGizlenmisCvp.Name = "lblGizlenmisCvp";
            this.lblGizlenmisCvp.Size = new System.Drawing.Size(46, 19);
            this.lblGizlenmisCvp.TabIndex = 5;
            this.lblGizlenmisCvp.Text = "Cevap";
            this.lblGizlenmisCvp.Visible = false;
            // 
            // lblGizlenmisSoru
            // 
            this.lblGizlenmisSoru.AutoSize = true;
            this.lblGizlenmisSoru.Location = new System.Drawing.Point(271, 60);
            this.lblGizlenmisSoru.Name = "lblGizlenmisSoru";
            this.lblGizlenmisSoru.Size = new System.Drawing.Size(36, 19);
            this.lblGizlenmisSoru.TabIndex = 6;
            this.lblGizlenmisSoru.Text = "Soru";
            this.lblGizlenmisSoru.Visible = false;
            // 
            // lblGizlenmisYil
            // 
            this.lblGizlenmisYil.AutoSize = true;
            this.lblGizlenmisYil.Location = new System.Drawing.Point(271, 79);
            this.lblGizlenmisYil.Name = "lblGizlenmisYil";
            this.lblGizlenmisYil.Size = new System.Drawing.Size(23, 19);
            this.lblGizlenmisYil.TabIndex = 7;
            this.lblGizlenmisYil.Text = "Yıl";
            this.lblGizlenmisYil.Visible = false;
            // 
            // lblGizlenmisAy
            // 
            this.lblGizlenmisAy.AutoSize = true;
            this.lblGizlenmisAy.Location = new System.Drawing.Point(271, 101);
            this.lblGizlenmisAy.Name = "lblGizlenmisAy";
            this.lblGizlenmisAy.Size = new System.Drawing.Size(24, 19);
            this.lblGizlenmisAy.TabIndex = 8;
            this.lblGizlenmisAy.Text = "Ay";
            this.lblGizlenmisAy.Visible = false;
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(41, 101);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(0, 0);
            this.lblSoru.TabIndex = 9;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 214);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.lblGizlenmisAy);
            this.Controls.Add(this.lblGizlenmisYil);
            this.Controls.Add(this.lblGizlenmisSoru);
            this.Controls.Add(this.lblGizlenmisCvp);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnYeniKelime);
            this.Controls.Add(this.btnCevap);
            this.Controls.Add(this.txtCevap);
            this.Name = "TestForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Test Etme";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtCevap;
        private MetroFramework.Controls.MetroButton btnCevap;
        private MetroFramework.Controls.MetroButton btnYeniKelime;
        private MetroFramework.Controls.MetroButton btnGeri;
        private MetroFramework.Controls.MetroLabel lblGizlenmisCvp;
        private MetroFramework.Controls.MetroLabel lblGizlenmisSoru;
        private MetroFramework.Controls.MetroLabel lblGizlenmisYil;
        private MetroFramework.Controls.MetroLabel lblGizlenmisAy;
        private MetroFramework.Controls.MetroLabel lblSoru;
    }
}