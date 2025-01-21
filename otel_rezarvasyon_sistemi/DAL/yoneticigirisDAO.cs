using MySql.Data.MySqlClient;
using otel_rezarvasyon_sistemi.DOMAIN;
using System;
using WindowsFormsApplication1.DAL;

namespace otel_rezarvasyon_sistemi.DAL
{
    public class YoneticiDAO
    {
        public bool GirisDogrula(Yonetici yonetici)
        {
            bool girisBasarili = false;

            try
            {
                using (var connection = (new baglanti()).BaglantiGetir())
                {
                    string query = "SELECT * FROM Yönetici WHERE Kullanıcıadı = @Kullanıcıadı AND şifresi = @sifresi";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Kullanıcıadı", yonetici.KullaniciAdi);
                        command.Parameters.AddWithValue("@sifresi", yonetici.Sifre);

                        if (connection.State == System.Data.ConnectionState.Broken ||
    connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                        }


                        using (var reader = command.ExecuteReader())
                        {
                            girisBasarili = reader.Read();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw;
            }

            return girisBasarili;
        }
    }
}
