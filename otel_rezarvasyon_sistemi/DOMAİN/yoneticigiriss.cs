namespace otel_rezarvasyon_sistemi.DOMAIN
{
    public class Yonetici
    {

        string KULLANİCİADİ;
        string SİFRE;
        public string KullaniciAdi { get { return KULLANİCİADİ; } set { KULLANİCİADİ = value; } }
        public string Sifre { get { return SİFRE; } set { SİFRE = value; } }

        public Yonetici(string kullaniciAdi, string sifre)
        {
           this.KULLANİCİADİ= kullaniciAdi;
            this.SİFRE = sifre;
        }
    }
}
