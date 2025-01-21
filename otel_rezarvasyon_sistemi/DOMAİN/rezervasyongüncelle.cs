using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_rezarvasyon_sistemi.DOMAİN
{
    internal class rezervasyongüncelle
    {
        public rezervasyongüncelle(string gTC, string gTelNo, string gAdSoyad, string gEposta, string gOdaTipi, int gOdalar,string gGiristarihi,string Çıkıştarihi)
        {
            this.TC = gTC;
            this.TelNo = gTelNo;
            this.AdSoyad = gAdSoyad;
            this.Eposta = gEposta;
            this.OdaTipi = gOdaTipi;
            this.Odalar = gOdalar;
            this.dateGiris = gGiristarihi;  
            this.dateCikis = Çıkıştarihi;
        }
        int ıd;
        string tc;
        string telno;
        string adSoyad;
        string eposta;
        string odaTipi;
        int odalar;
     string   dateCikis;
        string dateGiris;
        public string TC { get { return tc; } set { tc = value; } }
        public string TelNo { get { return telno; } set { telno = value; } }
        public string AdSoyad { get { return adSoyad; } set { adSoyad = value; } }
        public string Eposta { get { return eposta; } set { eposta = value; } }
        public string OdaTipi { get { return odaTipi; } set { odaTipi = value; } }
        public int Odalar { get { return odalar; } set { odalar = value; } }
        public int Id { get { return ıd; } set { ıd = value; } }
        public string DATAGİRİS { get { return dateGiris; } set { dateGiris = value; } }
        public string DATACIKIS { get { return dateCikis; } set { dateCikis = value; } }
    }
}
