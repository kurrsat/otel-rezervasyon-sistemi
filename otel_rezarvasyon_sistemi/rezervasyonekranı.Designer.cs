
namespace otel_rezarvasyon_sistemi
{
    partial class rezervasyonekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rezervasyonekranı));
            dataGridView1 = new DataGridView();
            cmbkisi = new ComboBox();
            lbladsoyad = new Label();
            label3 = new Label();
            label4 = new Label();
            txteposta = new TextBox();
            txtad = new TextBox();
            msktc = new MaskedTextBox();
            label1 = new Label();
            lbltc = new Label();
            dategiris = new DateTimePicker();
            datecıkıs = new DateTimePicker();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbodanumara = new ComboBox();
            btnkaydet = new Button();
            btndüzenle = new Button();
            msktel = new MaskedTextBox();
            btnkapat = new Button();
            btnsil = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 304);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 284);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbkisi
            // 
            cmbkisi.FormattingEnabled = true;
            cmbkisi.Items.AddRange(new object[] { "1 kişilik", "2 kişilik", "3 kişilik" });
            cmbkisi.Location = new Point(172, 179);
            cmbkisi.Name = "cmbkisi";
            cmbkisi.Size = new Size(125, 28);
            cmbkisi.TabIndex = 2;
            // 
            // lbladsoyad
            // 
            lbladsoyad.AutoSize = true;
            lbladsoyad.Location = new Point(82, 54);
            lbladsoyad.Name = "lbladsoyad";
            lbladsoyad.Size = new Size(84, 20);
            lbladsoyad.TabIndex = 3;
            lbladsoyad.Text = "ADSOYAD :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 92);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 5;
            label3.Text = "TELEFON NUMARASI :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 136);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "EPOSTA : ";
            // 
            // txteposta
            // 
            txteposta.Location = new Point(172, 136);
            txteposta.Name = "txteposta";
            txteposta.Size = new Size(125, 27);
            txteposta.TabIndex = 7;
            // 
            // txtad
            // 
            txtad.Location = new Point(172, 54);
            txtad.Name = "txtad";
            txtad.Size = new Size(125, 27);
            txtad.TabIndex = 9;
            // 
            // msktc
            // 
            msktc.Location = new Point(172, 18);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(125, 27);
            msktc.TabIndex = 10;
            msktc.ValidatingType = typeof(int);
            msktc.MaskInputRejected += msktc_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 182);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 11;
            label1.Text = "ODA TİPİ :";
            label1.Click += label1_Click;
            // 
            // lbltc
            // 
            lbltc.AutoSize = true;
            lbltc.Location = new Point(134, 21);
            lbltc.Name = "lbltc";
            lbltc.Size = new Size(32, 20);
            lbltc.TabIndex = 12;
            lbltc.Text = "TC :";
            // 
            // dategiris
            // 
            dategiris.Location = new Point(139, 21);
            dategiris.Name = "dategiris";
            dategiris.Size = new Size(232, 27);
            dategiris.TabIndex = 13;
            // 
            // datecıkıs
            // 
            datecıkıs.Location = new Point(139, 64);
            datecıkıs.Name = "datecıkıs";
            datecıkıs.Size = new Size(232, 27);
            datecıkıs.TabIndex = 14;
            datecıkıs.ValueChanged += datecıkıs_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 26);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 15;
            label2.Text = "GİRİŞ TARİHİ :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 71);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 16;
            label5.Text = "ÇIKIŞ TARİHİ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 227);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 18;
            label6.Text = "ODA NUMARASI :";
            // 
            // cmbodanumara
            // 
            cmbodanumara.FormattingEnabled = true;
            cmbodanumara.Items.AddRange(new object[] { "100", "101", "102", "103", "104", "105" });
            cmbodanumara.Location = new Point(172, 224);
            cmbodanumara.Name = "cmbodanumara";
            cmbodanumara.Size = new Size(125, 28);
            cmbodanumara.TabIndex = 17;
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(78, 140);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(111, 47);
            btnkaydet.TabIndex = 19;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // btndüzenle
            // 
            btndüzenle.Location = new Point(228, 140);
            btndüzenle.Name = "btndüzenle";
            btndüzenle.Size = new Size(113, 47);
            btndüzenle.TabIndex = 20;
            btndüzenle.Text = "DÜZENLE";
            btndüzenle.UseVisualStyleBackColor = true;
            btndüzenle.Click += btndüzenle_Click;
            // 
            // msktel
            // 
            msktel.Location = new Point(172, 92);
            msktel.Mask = "(999) 000-0000";
            msktel.Name = "msktel";
            msktel.Size = new Size(125, 27);
            msktel.TabIndex = 21;
            // 
            // btnkapat
            // 
            btnkapat.BackColor = SystemColors.ControlLightLight;
            btnkapat.BackgroundImage = (Image)resources.GetObject("btnkapat.BackgroundImage");
            btnkapat.BackgroundImageLayout = ImageLayout.Stretch;
            btnkapat.Location = new Point(856, -2);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(71, 60);
            btnkapat.TabIndex = 22;
            btnkapat.UseVisualStyleBackColor = false;
            btnkapat.Click += btnkapat_Click;
            // 
            // btnsil
            // 
            btnsil.Location = new Point(153, 202);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(108, 47);
            btnsil.TabIndex = 23;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(cmbodanumara);
            groupBox1.Controls.Add(cmbkisi);
            groupBox1.Controls.Add(lbladsoyad);
            groupBox1.Controls.Add(msktel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txteposta);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtad);
            groupBox1.Controls.Add(msktc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbltc);
            groupBox1.Location = new Point(50, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 268);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(dategiris);
            groupBox2.Controls.Add(datecıkıs);
            groupBox2.Controls.Add(btnsil);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btndüzenle);
            groupBox2.Controls.Add(btnkaydet);
            groupBox2.Location = new Point(427, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(409, 268);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            // 
            // rezervasyonekranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(925, 587);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnkapat);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "rezervasyonekranı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "rezarvasyonekranı";
            Load += rezarvasyonekranı_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private void msktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbkisi;
        private Label lbladsoyad;
        private Label label3;
        private Label label4;
        private TextBox txteposta;
        private TextBox txtad;
        private MaskedTextBox msktc;
        private Label label1;
        private Label lbltc;
        private DateTimePicker dategiris;
        private DateTimePicker datecıkıs;
        private Label label2;
        private Label label5;
        private Label label6;
        private ComboBox cmbodanumara;
        private Button btnkaydet;
        private Button btndüzenle;
        private MaskedTextBox msktel;
        private Button btnkapat;
        private Button btnsil;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}