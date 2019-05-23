namespace YazilimYapimi
{
    partial class KelimelerForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtKelime = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtOrnekCumle = new MetroFramework.Controls.MetroTextBox();
            this.txtTurkcesi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTur = new MetroFramework.Controls.MetroTextBox();
            this.btnEkle = new MetroFramework.Controls.MetroButton();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.btnGuncelle = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.kelimelerDataSet = new YazilimYapimi.KelimelerDataSet();
            this.kelimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kelimeTableAdapter = new YazilimYapimi.KelimelerDataSetTableAdapters.KelimeTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turkceKarsiligiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ornekCumleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilmeSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilinmeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGeri = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Kelime:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(254, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(27, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "ID:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Türkçesi:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(254, 158);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Türü:";
            // 
            // txtKelime
            // 
            // 
            // 
            // 
            this.txtKelime.CustomButton.Image = null;
            this.txtKelime.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txtKelime.CustomButton.Name = "";
            this.txtKelime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKelime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKelime.CustomButton.TabIndex = 1;
            this.txtKelime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKelime.CustomButton.UseSelectable = true;
            this.txtKelime.CustomButton.Visible = false;
            this.txtKelime.Lines = new string[0];
            this.txtKelime.Location = new System.Drawing.Point(129, 104);
            this.txtKelime.MaxLength = 32767;
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.PasswordChar = '\0';
            this.txtKelime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKelime.SelectedText = "";
            this.txtKelime.SelectionLength = 0;
            this.txtKelime.SelectionStart = 0;
            this.txtKelime.Size = new System.Drawing.Size(87, 23);
            this.txtKelime.TabIndex = 4;
            this.txtKelime.UseSelectable = true;
            this.txtKelime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKelime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(302, 104);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(87, 23);
            this.txtID.TabIndex = 5;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOrnekCumle
            // 
            // 
            // 
            // 
            this.txtOrnekCumle.CustomButton.Image = null;
            this.txtOrnekCumle.CustomButton.Location = new System.Drawing.Point(264, 1);
            this.txtOrnekCumle.CustomButton.Name = "";
            this.txtOrnekCumle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrnekCumle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrnekCumle.CustomButton.TabIndex = 1;
            this.txtOrnekCumle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrnekCumle.CustomButton.UseSelectable = true;
            this.txtOrnekCumle.CustomButton.Visible = false;
            this.txtOrnekCumle.Lines = new string[0];
            this.txtOrnekCumle.Location = new System.Drawing.Point(129, 215);
            this.txtOrnekCumle.MaxLength = 32767;
            this.txtOrnekCumle.Multiline = true;
            this.txtOrnekCumle.Name = "txtOrnekCumle";
            this.txtOrnekCumle.PasswordChar = '\0';
            this.txtOrnekCumle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrnekCumle.SelectedText = "";
            this.txtOrnekCumle.SelectionLength = 0;
            this.txtOrnekCumle.SelectionStart = 0;
            this.txtOrnekCumle.Size = new System.Drawing.Size(286, 23);
            this.txtOrnekCumle.TabIndex = 7;
            this.txtOrnekCumle.UseSelectable = true;
            this.txtOrnekCumle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrnekCumle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTurkcesi
            // 
            // 
            // 
            // 
            this.txtTurkcesi.CustomButton.Image = null;
            this.txtTurkcesi.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txtTurkcesi.CustomButton.Name = "";
            this.txtTurkcesi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTurkcesi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTurkcesi.CustomButton.TabIndex = 1;
            this.txtTurkcesi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTurkcesi.CustomButton.UseSelectable = true;
            this.txtTurkcesi.CustomButton.Visible = false;
            this.txtTurkcesi.Lines = new string[0];
            this.txtTurkcesi.Location = new System.Drawing.Point(129, 150);
            this.txtTurkcesi.MaxLength = 32767;
            this.txtTurkcesi.Name = "txtTurkcesi";
            this.txtTurkcesi.PasswordChar = '\0';
            this.txtTurkcesi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTurkcesi.SelectedText = "";
            this.txtTurkcesi.SelectionLength = 0;
            this.txtTurkcesi.SelectionStart = 0;
            this.txtTurkcesi.Size = new System.Drawing.Size(87, 23);
            this.txtTurkcesi.TabIndex = 6;
            this.txtTurkcesi.UseSelectable = true;
            this.txtTurkcesi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTurkcesi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(23, 215);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Örnek Cümle:";
            // 
            // txtTur
            // 
            // 
            // 
            // 
            this.txtTur.CustomButton.Image = null;
            this.txtTur.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txtTur.CustomButton.Name = "";
            this.txtTur.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTur.CustomButton.TabIndex = 1;
            this.txtTur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTur.CustomButton.UseSelectable = true;
            this.txtTur.CustomButton.Visible = false;
            this.txtTur.Lines = new string[0];
            this.txtTur.Location = new System.Drawing.Point(302, 154);
            this.txtTur.MaxLength = 32767;
            this.txtTur.Name = "txtTur";
            this.txtTur.PasswordChar = '\0';
            this.txtTur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTur.SelectedText = "";
            this.txtTur.SelectionLength = 0;
            this.txtTur.SelectionStart = 0;
            this.txtTur.Size = new System.Drawing.Size(87, 23);
            this.txtTur.TabIndex = 9;
            this.txtTur.UseSelectable = true;
            this.txtTur.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTur.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Silver;
            this.btnEkle.Location = new System.Drawing.Point(23, 273);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseCustomBackColor = true;
            this.btnEkle.UseCustomForeColor = true;
            this.btnEkle.UseSelectable = true;
            this.btnEkle.UseStyleColors = true;
            this.btnEkle.UseWaitCursor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Silver;
            this.btnSil.Location = new System.Drawing.Point(175, 273);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseCustomBackColor = true;
            this.btnSil.UseCustomForeColor = true;
            this.btnSil.UseSelectable = true;
            this.btnSil.UseStyleColors = true;
            this.btnSil.UseWaitCursor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnGuncelle.Location = new System.Drawing.Point(324, 273);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseCustomBackColor = true;
            this.btnGuncelle.UseCustomForeColor = true;
            this.btnGuncelle.UseSelectable = true;
            this.btnGuncelle.UseStyleColors = true;
            this.btnGuncelle.UseWaitCursor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.wordDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.turkceKarsiligiDataGridViewTextBoxColumn,
            this.ornekCumleDataGridViewTextBoxColumn,
            this.bilmeSayisiDataGridViewTextBoxColumn,
            this.bilinmeTarihiDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.kelimeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(496, 50);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(438, 227);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGrid1.TabIndex = 14;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            this.metroGrid1.UseStyleColors = true;
            // 
            // kelimelerDataSet
            // 
            this.kelimelerDataSet.DataSetName = "KelimelerDataSet";
            this.kelimelerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kelimeBindingSource
            // 
            this.kelimeBindingSource.DataMember = "Kelime";
            this.kelimeBindingSource.DataSource = this.kelimelerDataSet;
            // 
            // kelimeTableAdapter
            // 
            this.kelimeTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wordDataGridViewTextBoxColumn
            // 
            this.wordDataGridViewTextBoxColumn.DataPropertyName = "Word";
            this.wordDataGridViewTextBoxColumn.HeaderText = "Word";
            this.wordDataGridViewTextBoxColumn.Name = "wordDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // turkceKarsiligiDataGridViewTextBoxColumn
            // 
            this.turkceKarsiligiDataGridViewTextBoxColumn.DataPropertyName = "TurkceKarsiligi";
            this.turkceKarsiligiDataGridViewTextBoxColumn.HeaderText = "TurkceKarsiligi";
            this.turkceKarsiligiDataGridViewTextBoxColumn.Name = "turkceKarsiligiDataGridViewTextBoxColumn";
            // 
            // ornekCumleDataGridViewTextBoxColumn
            // 
            this.ornekCumleDataGridViewTextBoxColumn.DataPropertyName = "OrnekCumle";
            this.ornekCumleDataGridViewTextBoxColumn.HeaderText = "OrnekCumle";
            this.ornekCumleDataGridViewTextBoxColumn.Name = "ornekCumleDataGridViewTextBoxColumn";
            // 
            // bilmeSayisiDataGridViewTextBoxColumn
            // 
            this.bilmeSayisiDataGridViewTextBoxColumn.DataPropertyName = "BilmeSayisi";
            this.bilmeSayisiDataGridViewTextBoxColumn.HeaderText = "BilmeSayisi";
            this.bilmeSayisiDataGridViewTextBoxColumn.Name = "bilmeSayisiDataGridViewTextBoxColumn";
            // 
            // bilinmeTarihiDataGridViewTextBoxColumn
            // 
            this.bilinmeTarihiDataGridViewTextBoxColumn.DataPropertyName = "BilinmeTarihi";
            this.bilinmeTarihiDataGridViewTextBoxColumn.HeaderText = "BilinmeTarihi";
            this.bilinmeTarihiDataGridViewTextBoxColumn.Name = "bilinmeTarihiDataGridViewTextBoxColumn";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Silver;
            this.btnGeri.Location = new System.Drawing.Point(314, 25);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 28);
            this.btnGeri.TabIndex = 15;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseCustomBackColor = true;
            this.btnGeri.UseCustomForeColor = true;
            this.btnGeri.UseSelectable = true;
            this.btnGeri.UseStyleColors = true;
            this.btnGeri.UseWaitCursor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // KelimelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 331);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtOrnekCumle);
            this.Controls.Add(this.txtTurkcesi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtKelime);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "KelimelerForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Kelimeler";
            this.Load += new System.EventHandler(this.KelimelerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtKelime;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtOrnekCumle;
        private MetroFramework.Controls.MetroTextBox txtTurkcesi;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtTur;
        private MetroFramework.Controls.MetroButton btnEkle;
        private MetroFramework.Controls.MetroButton btnSil;
        private MetroFramework.Controls.MetroButton btnGuncelle;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private KelimelerDataSet kelimelerDataSet;
        private System.Windows.Forms.BindingSource kelimeBindingSource;
        private KelimelerDataSetTableAdapters.KelimeTableAdapter kelimeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turkceKarsiligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ornekCumleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilmeSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilinmeTarihiDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnGeri;
    }
}