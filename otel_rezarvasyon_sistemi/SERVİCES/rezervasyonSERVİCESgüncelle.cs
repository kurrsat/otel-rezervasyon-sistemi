using otel_rezarvasyon_sistemi.DAL;
using otel_rezarvasyon_sistemi.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_rezarvasyon_sistemi.SERVİCES
{
    internal class rezervasyonSERVİCESgüncelle
    {
        public void RezervasyonKaydet(string gTC, string gTELNO, string gADSOYAD, string gEposta, string gOdaTipi, string gOdalar, string gGiristarihi, string Çıkıştarihi)
        {

            // DAL katmanını kullanarak rezervasyonu kaydet
            (new rezervasyonDAOgüncelle()).rezervasyonkaydet(new Rezervasyon(gTC, gTELNO, gADSOYAD, gEposta, gOdaTipi, Convert.ToInt32(gOdalar), gGiristarihi, Çıkıştarihi));

            Console.WriteLine("Rezervasyon başarıyla kaydedildi.");
        }
    }
}
