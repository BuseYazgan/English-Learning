namespace YazilimYapimi
{
    partial class AnaForm
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
            this.btnTestEt = new MetroFramework.Controls.MetroButton();
            this.btnIstatistik = new MetroFramework.Controls.MetroButton();
            this.btnKelimeler = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnTestEt
            // 
            this.btnTestEt.BackColor = System.Drawing.Color.DarkGray;
            this.btnTestEt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTestEt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTestEt.Location = new System.Drawing.Point(134, 166);
            this.btnTestEt.Name = "btnTestEt";
            this.btnTestEt.Size = new System.Drawing.Size(92, 39);
            this.btnTestEt.TabIndex = 1;
            this.btnTestEt.Text = "Test Et";
            this.btnTestEt.UseCustomBackColor = true;
            this.btnTestEt.UseCustomForeColor = true;
            this.btnTestEt.UseSelectable = true;
            this.btnTestEt.UseStyleColors = true;
            this.btnTestEt.UseWaitCursor = true;
            this.btnTestEt.Click += new System.EventHandler(this.btnTestEt_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.BackColor = System.Drawing.Color.DarkGray;
            this.btnIstatistik.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnIstatistik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIstatistik.Location = new System.Drawing.Point(134, 230);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(92, 39);
            this.btnIstatistik.TabIndex = 2;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.UseCustomBackColor = true;
            this.btnIstatistik.UseCustomForeColor = true;
            this.btnIstatistik.UseSelectable = true;
            this.btnIstatistik.UseStyleColors = true;
            this.btnIstatistik.UseWaitCursor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnKelimeler
            // 
            this.btnKelimeler.BackColor = System.Drawing.Color.DarkGray;
            this.btnKelimeler.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnKelimeler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKelimeler.Location = new System.Drawing.Point(134, 108);
            this.btnKelimeler.Name = "btnKelimeler";
            this.btnKelimeler.Size = new System.Drawing.Size(92, 39);
            this.btnKelimeler.TabIndex = 3;
            this.btnKelimeler.Text = "Kelimeler";
            this.btnKelimeler.UseCustomBackColor = true;
            this.btnKelimeler.UseCustomForeColor = true;
            this.btnKelimeler.UseSelectable = true;
            this.btnKelimeler.UseStyleColors = true;
            this.btnKelimeler.UseWaitCursor = true;
            this.btnKelimeler.Click += new System.EventHandler(this.btnKelimeler_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 326);
            this.Controls.Add(this.btnKelimeler);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnTestEt);
            this.Name = "AnaForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "    İngilizce Kelime Öğrenme";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnTestEt;
        private MetroFramework.Controls.MetroButton btnIstatistik;
        private MetroFramework.Controls.MetroButton btnKelimeler;
    }
}

