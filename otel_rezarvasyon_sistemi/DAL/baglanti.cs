using System;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.DAL
{
    public class baglanti
    {
        private readonly string connectionString = "Server=172.21.54.253;Database=25_132330030;User=25_132330030;Password=!nif.ogr30AK;";

        // MySqlConnection nesnesini döndüren bir yöntem
        public MySqlConnection BaglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection(connectionString);
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                return baglanti;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bağlantı açılırken hata oluştu: " + ex.Message);
                return null; // Hata durumunda null döner
            }
        }

        // Bağlantıyı güvenli bir şekilde kapatan yöntem
        public void BaglantiKapat(MySqlConnection baglanti)
        {
            try
            {
                if (baglanti != null && baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                    Console.WriteLine("Bağlantı kapatıldı.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bağlantı kapatılırken hata oluştu: " + ex.Message);
            }
        }
    }
}
