using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_rezarvasyon_sistemi.DOMAİN
{
    internal class rezervasyonsil
    {
        public rezervasyonsil(string gTC, string gTelNo, string gAdSoyad, string gEposta, string gOdaTipi, int gOdalar)
        {
            this.TC = gTC;
            this.TelNo = gTelNo;
            this.AdSoyad = gAdSoyad;
            this.Eposta = gEposta;
            this.OdaTipi = gOdaTipi;
            this.Odalar = gOdalar;

        }
        int ıd;
        string tc;
        string telno;
        string adSoyad;
        string eposta;
        string odaTipi;
        int odalar;
        // DateTime dateCikis;
        //  DateTime dateGiris;
        public string TC { get { return tc; } set { tc = value; } }
        public string TelNo { get { return telno; } set { telno = value; } }
        public string AdSoyad { get { return adSoyad; } set { adSoyad = value; } }
        public string Eposta { get { return eposta; } set { eposta = value; } }
        public string OdaTipi { get { return odaTipi; } set { odaTipi = value; } }
        public int Odalar { get { return odalar; } set { odalar = value; } }
        public int Id { get { return ıd; } set { ıd = value; } }
    }
}
