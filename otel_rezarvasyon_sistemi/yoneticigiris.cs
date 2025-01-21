using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using otel_rezarvasyon_sistemi.SERVICES;

namespace otel_rezarvasyon_sistemi
{
    public partial class yoneticigiris : Form
    {
        public yoneticigiris()
        {

            InitializeComponent();
        }

        private void btnkaydı_Click(object sender, EventArgs e)
        {
            if ((new YoneticiService()).GirisKontrol(txtkullanıcı.Text, txtsifre.Text))
            {
                yonetici_anaekranı ya = new yonetici_anaekranı();
                ya.Show();
                this.Hide();

            }


        }

        private void lblkullanıcı_Click(object sender, EventArgs e)
        {

        }

        private void lblsifre_Click(object sender, EventArgs e)
        {

        }

        private void yoneticigiris_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifre_yenileme sf = new sifre_yenileme();   
            sf.Show();

        }
    }
}
