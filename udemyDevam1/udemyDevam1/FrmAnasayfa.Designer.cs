namespace udemyDevam1
{
    partial class FrmAnasayfa
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.d = new System.Windows.Forms.Label();
			this.mskMaas = new System.Windows.Forms.MaskedTextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dd = new System.Windows.Forms.Label();
			this.sss = new System.Windows.Forms.Label();
			this.ss = new System.Windows.Forms.Label();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.cmbSehir = new System.Windows.Forms.ComboBox();
			this.txtMeslek = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.s = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnGrafik = new System.Windows.Forms.Button();
			this.btnTemizilk = new System.Windows.Forms.Button();
			this.btnIstetik = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnListele = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tblPersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.personelVeriTabaniDataSet2 = new udemyDevam1.PersonelVeriTabaniDataSet2();
			this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.personelVeriTabaniDataSet1 = new udemyDevam1.PersonelVeriTabaniDataSet1();
			this.tbl_PersonelTableAdapter = new udemyDevam1.PersonelVeriTabaniDataSet1TableAdapters.Tbl_PersonelTableAdapter();
			this.tbl_PersonelTableAdapter1 = new udemyDevam1.PersonelVeriTabaniDataSet2TableAdapters.Tbl_PersonelTableAdapter();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.d);
			this.groupBox1.Controls.Add(this.mskMaas);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dd);
			this.groupBox1.Controls.Add(this.sss);
			this.groupBox1.Controls.Add(this.ss);
			this.groupBox1.Controls.Add(this.txtSoyad);
			this.groupBox1.Controls.Add(this.cmbSehir);
			this.groupBox1.Controls.Add(this.txtMeslek);
			this.groupBox1.Controls.Add(this.txtAd);
			this.groupBox1.Controls.Add(this.txtId);
			this.groupBox1.Controls.Add(this.s);
			this.groupBox1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(15, 16);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(478, 501);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personel Kayıt";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(367, 323);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 24);
			this.label1.TabIndex = 16;
			this.label1.Text = "label1";
			this.label1.Visible = false;
			this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
			// 
			// d
			// 
			this.d.AutoSize = true;
			this.d.Location = new System.Drawing.Point(22, 289);
			this.d.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.d.Name = "d";
			this.d.Size = new System.Drawing.Size(58, 24);
			this.d.TabIndex = 15;
			this.d.Text = "Maaş";
			// 
			// mskMaas
			// 
			this.mskMaas.Location = new System.Drawing.Point(171, 278);
			this.mskMaas.Mask = "00000";
			this.mskMaas.Name = "mskMaas";
			this.mskMaas.Size = new System.Drawing.Size(188, 31);
			this.mskMaas.TabIndex = 14;
			this.mskMaas.ValidatingType = typeof(int);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(258, 346);
			this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(85, 28);
			this.radioButton2.TabIndex = 13;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Bekar";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(173, 346);
			this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(65, 28);
			this.radioButton1.TabIndex = 12;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Evli";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 411);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 24);
			this.label6.TabIndex = 11;
			this.label6.Text = "Meslek";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 342);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 24);
			this.label5.TabIndex = 10;
			this.label5.Text = "Durum";
			// 
			// dd
			// 
			this.dd.AutoSize = true;
			this.dd.Location = new System.Drawing.Point(22, 225);
			this.dd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.dd.Name = "dd";
			this.dd.Size = new System.Drawing.Size(58, 24);
			this.dd.TabIndex = 9;
			this.dd.Text = "Şehir";
			// 
			// sss
			// 
			this.sss.AutoSize = true;
			this.sss.Location = new System.Drawing.Point(22, 168);
			this.sss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.sss.Name = "sss";
			this.sss.Size = new System.Drawing.Size(65, 24);
			this.sss.TabIndex = 8;
			this.sss.Text = "Soyad";
			// 
			// ss
			// 
			this.ss.AutoSize = true;
			this.ss.Location = new System.Drawing.Point(22, 105);
			this.ss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ss.Name = "ss";
			this.ss.Size = new System.Drawing.Size(120, 24);
			this.ss.TabIndex = 7;
			this.ss.Text = "Personel Ad";
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(171, 164);
			this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(188, 31);
			this.txtSoyad.TabIndex = 6;
			// 
			// cmbSehir
			// 
			this.cmbSehir.FormattingEnabled = true;
			this.cmbSehir.Location = new System.Drawing.Point(171, 221);
			this.cmbSehir.Margin = new System.Windows.Forms.Padding(4);
			this.cmbSehir.Name = "cmbSehir";
			this.cmbSehir.Size = new System.Drawing.Size(188, 32);
			this.cmbSehir.TabIndex = 5;
			// 
			// txtMeslek
			// 
			this.txtMeslek.Location = new System.Drawing.Point(173, 411);
			this.txtMeslek.Margin = new System.Windows.Forms.Padding(4);
			this.txtMeslek.Name = "txtMeslek";
			this.txtMeslek.Size = new System.Drawing.Size(188, 31);
			this.txtMeslek.TabIndex = 3;
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(171, 105);
			this.txtAd.Margin = new System.Windows.Forms.Padding(4);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(188, 31);
			this.txtAd.TabIndex = 2;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(171, 44);
			this.txtId.Margin = new System.Windows.Forms.Padding(4);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(188, 31);
			this.txtId.TabIndex = 1;
			// 
			// s
			// 
			this.s.AutoSize = true;
			this.s.Location = new System.Drawing.Point(22, 44);
			this.s.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.s.Name = "s";
			this.s.Size = new System.Drawing.Size(116, 24);
			this.s.TabIndex = 0;
			this.s.Text = "Personel ID";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnGrafik);
			this.groupBox2.Controls.Add(this.btnTemizilk);
			this.groupBox2.Controls.Add(this.btnIstetik);
			this.groupBox2.Controls.Add(this.btnSil);
			this.groupBox2.Controls.Add(this.btnGuncelle);
			this.groupBox2.Controls.Add(this.btnKaydet);
			this.groupBox2.Controls.Add(this.btnListele);
			this.groupBox2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(720, 30);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(320, 487);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "İşlemler";
			// 
			// btnGrafik
			// 
			this.btnGrafik.Location = new System.Drawing.Point(73, 418);
			this.btnGrafik.Name = "btnGrafik";
			this.btnGrafik.Size = new System.Drawing.Size(179, 44);
			this.btnGrafik.TabIndex = 6;
			this.btnGrafik.Text = "Grafik";
			this.btnGrafik.UseVisualStyleBackColor = true;
			this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
			// 
			// btnTemizilk
			// 
			this.btnTemizilk.Location = new System.Drawing.Point(73, 175);
			this.btnTemizilk.Name = "btnTemizilk";
			this.btnTemizilk.Size = new System.Drawing.Size(179, 50);
			this.btnTemizilk.TabIndex = 4;
			this.btnTemizilk.Text = "Temizle";
			this.btnTemizilk.UseVisualStyleBackColor = true;
			this.btnTemizilk.Click += new System.EventHandler(this.btnTemizilk_Click);
			// 
			// btnIstetik
			// 
			this.btnIstetik.Location = new System.Drawing.Point(73, 361);
			this.btnIstetik.Name = "btnIstetik";
			this.btnIstetik.Size = new System.Drawing.Size(179, 46);
			this.btnIstetik.TabIndex = 5;
			this.btnIstetik.Text = "İstatik";
			this.btnIstetik.UseVisualStyleBackColor = true;
			this.btnIstetik.Click += new System.EventHandler(this.btnIstetik_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(73, 239);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(179, 50);
			this.btnSil.TabIndex = 2;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(73, 296);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(179, 50);
			this.btnGuncelle.TabIndex = 3;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(73, 109);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(179, 50);
			this.btnKaydet.TabIndex = 1;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnListele
			// 
			this.btnListele.Location = new System.Drawing.Point(73, 45);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(179, 50);
			this.btnListele.TabIndex = 0;
			this.btnListele.Text = "Listele";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox3.Location = new System.Drawing.Point(15, 524);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1185, 212);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Kayıtlar";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.tblPersonelBindingSource1;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 27);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1179, 182);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// peridDataGridViewTextBoxColumn
			// 
			this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
			this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
			this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
			this.peridDataGridViewTextBoxColumn.ReadOnly = true;
			this.peridDataGridViewTextBoxColumn.Width = 125;
			// 
			// perAdDataGridViewTextBoxColumn
			// 
			this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
			this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
			this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
			this.perAdDataGridViewTextBoxColumn.Width = 125;
			// 
			// perSoyadDataGridViewTextBoxColumn
			// 
			this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
			this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
			this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
			this.perSoyadDataGridViewTextBoxColumn.Width = 125;
			// 
			// perSehirDataGridViewTextBoxColumn
			// 
			this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
			this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
			this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
			this.perSehirDataGridViewTextBoxColumn.Width = 125;
			// 
			// perMaasDataGridViewTextBoxColumn
			// 
			this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
			this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
			this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
			this.perMaasDataGridViewTextBoxColumn.Width = 125;
			// 
			// perDurumDataGridViewCheckBoxColumn
			// 
			this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
			this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
			this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
			this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
			this.perDurumDataGridViewCheckBoxColumn.Width = 125;
			// 
			// perMeslekDataGridViewTextBoxColumn
			// 
			this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
			this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
			this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
			this.perMeslekDataGridViewTextBoxColumn.Width = 125;
			// 
			// tblPersonelBindingSource1
			// 
			this.tblPersonelBindingSource1.DataMember = "Tbl_Personel";
			this.tblPersonelBindingSource1.DataSource = this.personelVeriTabaniDataSet2;
			// 
			// personelVeriTabaniDataSet2
			// 
			this.personelVeriTabaniDataSet2.DataSetName = "PersonelVeriTabaniDataSet2";
			this.personelVeriTabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblPersonelBindingSource
			// 
			this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
			this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet1;
			// 
			// personelVeriTabaniDataSet1
			// 
			this.personelVeriTabaniDataSet1.DataSetName = "PersonelVeriTabaniDataSet1";
			this.personelVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tbl_PersonelTableAdapter
			// 
			this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
			// 
			// tbl_PersonelTableAdapter1
			// 
			this.tbl_PersonelTableAdapter1.ClearBeforeFill = true;
			// 
			// FrmAnasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(1201, 748);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmAnasayfa";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.Label sss;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnTemizilk;
        private System.Windows.Forms.Button btnIstetik;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.MaskedTextBox mskMaas;
        private PersonelVeriTabaniDataSet1 personelVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSet1TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabaniDataSet2 personelVeriTabaniDataSet2;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource1;
        private PersonelVeriTabaniDataSet2TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
    }
}

