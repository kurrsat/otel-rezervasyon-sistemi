using otel_rezarvasyon_sistemi.DAL;
using otel_rezarvasyon_sistemi.DOMAIN;
using System;
using System.Windows.Forms; 

namespace otel_rezarvasyon_sistemi.SERVICES
{
    public class YoneticiService
    {
        public bool GirisKontrol(string kullaniciAdi, string sifre)
        {
            
            bool girisBasarili = (new YoneticiDAO()).GirisDogrula(new Yonetici(kullaniciAdi, sifre));

            if (girisBasarili)
            {
                return true;
                
                

            }
            else
            {
                // Hatalı giriş için mesaj göster
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }
    }
}
