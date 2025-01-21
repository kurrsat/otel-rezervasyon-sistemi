using otel_rezarvasyon_sistemi.DAL;
using otel_rezarvasyon_sistemi.DOMAIN;
using System;
using System.Security.Policy;

namespace otel_rezarvasyon_sistemi.SERVICES
{
    public class RezervasyonServices
    {
        public void RezervasyonKaydet(  string gTC, string gTELNO, string gADSOYAD, string gEposta, string gOdaTipi, string gOdalar,string gGiristarihi,string Çıkıştarihi)   {         

            // DAL katmanını kullanarak rezervasyonu kaydet
            (new rezervasyonDAO()).rezervasyonkaydet(new Rezervasyon(gTC,gTELNO,gADSOYAD,gEposta,gOdaTipi, Convert.ToInt32(gOdalar),gGiristarihi,Çıkıştarihi));

            Console.WriteLine("Rezervasyon başarıyla kaydedildi.");
        }
    }
}
