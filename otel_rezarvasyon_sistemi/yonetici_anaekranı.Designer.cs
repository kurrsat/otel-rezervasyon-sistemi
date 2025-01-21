namespace otel_rezarvasyon_sistemi
{
    partial class yonetici_anaekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetici_anaekranı));
            btnrezervasyon = new Button();
            btnodalar = new Button();
            btnkapat = new Button();
            SuspendLayout();
            // 
            // btnrezervasyon
            // 
            btnrezervasyon.BackColor = Color.White;
            btnrezervasyon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnrezervasyon.Location = new Point(217, 184);
            btnrezervasyon.Name = "btnrezervasyon";
            btnrezervasyon.Size = new Size(176, 80);
            btnrezervasyon.TabIndex = 2;
            btnrezervasyon.Text = "Rezervasyonlar";
            btnrezervasyon.UseVisualStyleBackColor = false;
            btnrezervasyon.Click += btnrezarvasyon_Click;
            // 
            // btnodalar
            // 
            btnodalar.BackColor = Color.White;
            btnodalar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnodalar.Location = new Point(449, 184);
            btnodalar.Name = "btnodalar";
            btnodalar.Size = new Size(178, 80);
            btnodalar.TabIndex = 3;
            btnodalar.Text = "Odalar";
            btnodalar.UseVisualStyleBackColor = false;
            btnodalar.Click += btnodalar_Click;
            // 
            // btnkapat
            // 
            btnkapat.BackgroundImage = (Image)resources.GetObject("btnkapat.BackgroundImage");
            btnkapat.BackgroundImageLayout = ImageLayout.Stretch;
            btnkapat.Location = new Point(741, -3);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(64, 54);
            btnkapat.TabIndex = 23;
            btnkapat.UseVisualStyleBackColor = false;
            btnkapat.Click += btnkapat_Click;
            // 
            // yonetici_anaekranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(799, 449);
            Controls.Add(btnkapat);
            Controls.Add(btnodalar);
            Controls.Add(btnrezervasyon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "yonetici_anaekranı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "musteri_anaekranı";
            Load += yonetici_anaekranı_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnrezervasyon;
        private Button btnodalar;
        private Button btnkapat;
    }
}