
using MySql.Data.MySqlClient;
using otel_rezarvasyon_sistemi.DOMAIN;
using System;
using WindowsFormsApplication1.DAL;

namespace otel_rezarvasyon_sistemi.DAL
{
    public class rezervasyonDAO
    {
        public void rezervasyonkaydet(Rezervasyon grezervasyon)
        {
            try
            {
                using (var connection = (new baglanti()).BaglantiGetir())
                {
                    string query = "INSERT INTO rezervasyonlar (TC, TELEFON, ADSOYAD, EPOSTA, ODATİPİ, ODALAR,GİRİŞTARİHİ,ÇIKIŞTARİHİ ) " +
                                   "VALUES (@TC, @Telefon, @AdSoyad, @Eposta, @OdaTipi, @Odalar,@giristarihi,@cıkıştarihi)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TC", grezervasyon.TC);
                        command.Parameters.AddWithValue("@Telefon", grezervasyon.TelNo);
                        command.Parameters.AddWithValue("@AdSoyad", grezervasyon.AdSoyad);
                        command.Parameters.AddWithValue("@Eposta", grezervasyon.Eposta);
                        command.Parameters.AddWithValue("@OdaTipi", grezervasyon.OdaTipi);
                        command.Parameters.AddWithValue("@Odalar", grezervasyon.Odalar);
                        command.Parameters.AddWithValue("@giristarihi", grezervasyon.DATAGİRİS);
                        command.Parameters.AddWithValue("@cıkıştarihi", grezervasyon.DATACIKIS);

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

