namespace otel_rezarvasyon_sistemi
{
    partial class yoneticigiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yoneticigiris));
            lblsifre = new Label();
            lblkullanıcı = new Label();
            btnkaydı = new Button();
            txtsifre = new TextBox();
            txtkullanıcı = new TextBox();
            lblotelad = new Label();
            lblunuttum = new LinkLabel();
            SuspendLayout();
            // 
            // lblsifre
            // 
            lblsifre.AutoSize = true;
            lblsifre.BackColor = Color.Transparent;
            lblsifre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblsifre.ForeColor = Color.White;
            lblsifre.Location = new Point(293, 247);
            lblsifre.Name = "lblsifre";
            lblsifre.Size = new Size(54, 23);
            lblsifre.TabIndex = 9;
            lblsifre.Text = "Şifre :";
            lblsifre.Click += lblsifre_Click;
            // 
            // lblkullanıcı
            // 
            lblkullanıcı.AutoSize = true;
            lblkullanıcı.BackColor = Color.Transparent;
            lblkullanıcı.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblkullanıcı.ForeColor = Color.White;
            lblkullanıcı.Location = new Point(225, 205);
            lblkullanıcı.Name = "lblkullanıcı";
            lblkullanıcı.Size = new Size(124, 23);
            lblkullanıcı.TabIndex = 8;
            lblkullanıcı.Text = "Kullanıcı Adı : ";
            lblkullanıcı.Click += lblkullanıcı_Click;
            // 
            // btnkaydı
            // 
            btnkaydı.BackColor = Color.White;
            btnkaydı.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnkaydı.Location = new Point(369, 310);
            btnkaydı.Name = "btnkaydı";
            btnkaydı.Size = new Size(107, 37);
            btnkaydı.TabIndex = 7;
            btnkaydı.Text = "Giriş Yap";
            btnkaydı.UseVisualStyleBackColor = false;
            btnkaydı.Click += btnkaydı_Click;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(355, 247);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(142, 27);
            txtsifre.TabIndex = 6;
            // 
            // txtkullanıcı
            // 
            txtkullanıcı.Location = new Point(355, 201);
            txtkullanıcı.Name = "txtkullanıcı";
            txtkullanıcı.Size = new Size(142, 27);
            txtkullanıcı.TabIndex = 5;
            // 
            // lblotelad
            // 
            lblotelad.AutoSize = true;
            lblotelad.BackColor = SystemColors.ActiveCaptionText;
            lblotelad.Font = new Font("Impact", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblotelad.ForeColor = Color.White;
            lblotelad.Location = new Point(273, 34);
            lblotelad.Name = "lblotelad";
            lblotelad.Size = new Size(283, 54);
            lblotelad.TabIndex = 10;
            lblotelad.Text = "Sogno Marino";
            // 
            // lblunuttum
            // 
            lblunuttum.AutoSize = true;
            lblunuttum.BackColor = Color.Transparent;
            lblunuttum.LinkColor = Color.Cyan;
            lblunuttum.Location = new Point(505, 281);
            lblunuttum.Name = "lblunuttum";
            lblunuttum.Size = new Size(115, 20);
            lblunuttum.TabIndex = 11;
            lblunuttum.TabStop = true;
            lblunuttum.Text = "Şifremi unuttum";
            lblunuttum.LinkClicked += lblunuttum_LinkClicked;
            // 
            // yoneticigiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblunuttum);
            Controls.Add(lblotelad);
            Controls.Add(lblsifre);
            Controls.Add(lblkullanıcı);
            Controls.Add(btnkaydı);
            Controls.Add(txtsifre);
            Controls.Add(txtkullanıcı);
            FormBorderStyle = FormBorderStyle.None;
            Name = "yoneticigiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "yoneticigiris";
            Load += yoneticigiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblsifre;
        private Label lblkullanıcı;
        private Button btnkaydı;
        private TextBox txtsifre;
        private TextBox txtkullanıcı;
        private Label lblotelad;
        private LinkLabel lblunuttum;
    }
}