
namespace otel_rezarvasyon_sistemi
{
    partial class sifre_yenileme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifre_yenileme));
            txtşifreyenile = new TextBox();
            lblsifre = new Label();
            txtsoru = new TextBox();
            lblsoru = new Label();
            label2 = new Label();
            btnkontrol = new Button();
            btnGüncelle = new Button();
            btnkapat = new Button();
            SuspendLayout();
            // 
            // txtşifreyenile
            // 
            txtşifreyenile.Location = new Point(397, 202);
            txtşifreyenile.Name = "txtşifreyenile";
            txtşifreyenile.Size = new Size(125, 27);
            txtşifreyenile.TabIndex = 0;
            txtşifreyenile.TextChanged += txtşifreyenile_TextChanged;
            // 
            // lblsifre
            // 
            lblsifre.AutoSize = true;
            lblsifre.BackColor = Color.Transparent;
            lblsifre.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblsifre.ForeColor = SystemColors.ButtonHighlight;
            lblsifre.Location = new Point(270, 205);
            lblsifre.Name = "lblsifre";
            lblsifre.Size = new Size(119, 20);
            lblsifre.TabIndex = 1;
            lblsifre.Text = "Yeni Şifreniz : ";
            // 
            // txtsoru
            // 
            txtsoru.Location = new Point(397, 202);
            txtsoru.Name = "txtsoru";
            txtsoru.Size = new Size(125, 27);
            txtsoru.TabIndex = 2;
            // 
            // lblsoru
            // 
            lblsoru.AutoSize = true;
            lblsoru.BackColor = Color.Transparent;
            lblsoru.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblsoru.ForeColor = SystemColors.ButtonHighlight;
            lblsoru.Location = new Point(236, 205);
            lblsoru.Name = "lblsoru";
            lblsoru.Size = new Size(153, 20);
            lblsoru.TabIndex = 3;
            lblsoru.Text = "İlk izlediğiniz flim :";
            lblsoru.Click += lblsoru_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(201, 43);
            label2.Name = "label2";
            label2.Size = new Size(489, 37);
            label2.TabIndex = 4;
            label2.Text = "GÜVENLİK SORUSUNU CEVAPLAYIN";
            // 
            // btnkontrol
            // 
            btnkontrol.Location = new Point(411, 249);
            btnkontrol.Name = "btnkontrol";
            btnkontrol.Size = new Size(94, 29);
            btnkontrol.TabIndex = 5;
            btnkontrol.Text = "Kontrol et";
            btnkontrol.UseVisualStyleBackColor = true;
            btnkontrol.Click += btnkontrol_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(411, 249);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(94, 29);
            btnGüncelle.TabIndex = 6;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnkapat
            // 
            btnkapat.BackgroundImage = (Image)resources.GetObject("btnkapat.BackgroundImage");
            btnkapat.BackgroundImageLayout = ImageLayout.Stretch;
            btnkapat.Location = new Point(737, -2);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(64, 54);
            btnkapat.TabIndex = 24;
            btnkapat.UseVisualStyleBackColor = false;
            btnkapat.Click += btnkapat_Click;
            // 
            // sifre_yenileme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnkapat);
            Controls.Add(btnGüncelle);
            Controls.Add(btnkontrol);
            Controls.Add(label2);
            Controls.Add(lblsoru);
            Controls.Add(txtsoru);
            Controls.Add(lblsifre);
            Controls.Add(txtşifreyenile);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sifre_yenileme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sifre_yenileme";
            Load += sifre_yenileme_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox txtşifreyenile;
        private Label lblsifre;
        private TextBox txtsoru;
        private Label lblsoru;
        private Label label2;
        private Button btnkontrol;
        private Button btnGüncelle;
        private Button btnkapat;
    }
}