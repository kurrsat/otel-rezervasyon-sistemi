using MySql.Data.MySqlClient;
using otel_rezarvasyon_sistemi.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL;

namespace otel_rezarvasyon_sistemi.DAL
{
    internal class rezervasyonDAOsil
    {
        public void rezervasyonkaydet(Rezervasyon grezervasyon)
        {
            try
            {
                using (var connection = (new baglanti()).BaglantiGetir())
                {
                    string query = "DELETE FROM rezervasyonlar WHERE TC = @TC";


                    using (var command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@TC", grezervasyon.TC);
                        command.Parameters.AddWithValue("@Telefon", grezervasyon.TelNo);
                        command.Parameters.AddWithValue("@AdSoyad", grezervasyon.AdSoyad);
                        command.Parameters.AddWithValue("@Eposta", grezervasyon.Eposta);
                        command.Parameters.AddWithValue("@OdaTipi", grezervasyon.OdaTipi);
                        command.Parameters.AddWithValue("@Odalar", grezervasyon.Odalar);
                        
                        // Bağlantının açık olup olmadığını kontrol edin
                        if (connection.State != System.Data.ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını yazdır
                Console.WriteLine($"Hata: {ex.Message}");
                throw; // Hatanın kaynağını göstermek için tekrar fırlat
            }



        }
    }
}
