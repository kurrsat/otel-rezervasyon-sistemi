using MySql.Data.MySqlClient;
using otel_rezarvasyon_sistemi.DOMAIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;

namespace otel_rezarvasyon_sistemi
{
    public partial class odalar : Form
    {
        public void OdalarFormu_Load(object sender, EventArgs e)
        {

        }

        public static void GuncelleOdalar()
        {
            throw new NotImplementedException();
        }

        public odalar()
        {
            InitializeComponent();
        }

        private void odalar_Load(object sender, EventArgs e)
        {

           
            // Veritabanından dolu odaları oku
            List<string> doluOdalar = VeritabanindanDoluOdalarGetir();
            if (doluOdalar.Contains(btn100.Text))
            {
                btn100.BackColor = System.Drawing.Color.Red;
            }
            if (doluOdalar.Contains(btn101.Text))
            {
                btn101.BackColor = System.Drawing.Color.Red;
            }
            if (doluOdalar.Contains(btn102.Text))
            {
                btn102.BackColor = System.Drawing.Color.Red;
            }
            if (doluOdalar.Contains(btn103.Text))
            {
                btn103.BackColor = System.Drawing.Color.Red;
            }
            if (doluOdalar.Contains(btn104.Text))
            {
                btn104.BackColor = System.Drawing.Color.Red;
            }
            if (doluOdalar.Contains(btn105.Text))
            {
                btn105.BackColor = System.Drawing.Color.Red;
            }

        }

       

       

        private List<string> VeritabanindanDoluOdalarGetir()
        {
            List<string> doluOdalar = new List<string>();
            string connectionString = "Server=172.21.54.253;Database=25_132330030;User ID=25_132330030;Password=!nif.ogr30AK;";
            string query = "SELECT ODALAR FROM rezervasyonlar";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // ODALAR sütununun değeri boş değilse, listeye ekleyin
                            if (!reader.IsDBNull(reader.GetOrdinal("ODALAR")))
                            {
                                doluOdalar.Add(reader["ODALAR"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bağlantı hatası: " + ex.Message);
                }
            }

            return doluOdalar;
        }

        private void VeritabanindanOdaSil(string odaNumarasi)
        {
            string connectionString = "Server=172.21.54.253;Database=25_132330030;User ID=25_132330030;Password=!nif.ogr30AK;";
            string query = "DELETE FROM rezervasyonlar WHERE ODALAR = @OdaNumarasi";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@OdaNumarasi", odaNumarasi);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"{odaNumarasi} başarıyla silindi.");
                    }
                    else
                    {
                        Console.WriteLine($"{odaNumarasi} silinirken bir hata oluştu veya zaten mevcut değil.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bağlantı hatası: " + ex.Message);
                }
            }
        }


        private void btn100_Click(object sender, EventArgs e)
        {
            List<string> doluOdalar = VeritabanindanDoluOdalarGetir();
            string odaNumarasi = btn100.Text;

            if (doluOdalar.Contains(odaNumarasi))
            {
                // Veritabanından silme işlemi
                VeritabanindanOdaSil(odaNumarasi);

                // Buton rengini yeşile çevir
                btn100.BackColor = Color.Green;

                // Kullanıcıya bilgi ver
                MessageBox.Show($"{odaNumarasi} numaralı oda boşaltıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{odaNumarasi} numaralı oda zaten boş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void btn101_Click(object sender, EventArgs e)
        {
            List<string> doluOdalar = VeritabanindanDoluOdalarGetir();
            string odaNumarasi = btn101.Text;

            if (doluOdalar.Contains(odaNumarasi))
            {
                // Veritabanından silme işlemi
                VeritabanindanOdaSil(odaNumarasi);

                // Buton rengini yeşile çevir
                btn100.BackColor = Color.Green;

                // Kullanıcıya bilgi ver
                MessageBox.Show($"{odaNumarasi} numaralı oda boşaltıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{odaNumarasi} numaralı oda zaten boş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn102_Click(object sender, EventArgs e)
        {
            List<string> doluOdalar = VeritabanindanDoluOdalarGetir();
            string odaNumarasi = btn102.Text;

            if (doluOdalar.Contains(odaNumarasi))
            {
                // Veritabanından silme işlemi
                VeritabanindanOdaSil(odaNumarasi);

                // Buton rengini yeşile çevir
                btn100.BackColor = Color.Green;

                // Kullanıcıya bilgi ver
                MessageBox.Show($"{odaNumarasi} numaralı oda boşaltıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{odaNumarasi} numaralı oda zaten boş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            List<string> doluOdalar = VeritabanindanDoluOdalarGetir();
            string odaNumarasi = btn103.Text;

            if (doluOdalar.Contains(odaNumarasi))
            {
                // Veritabanından silme işlemi
                VeritabanindanOdaSil(odaNumarasi);

                // Buton rengini yeşile çevir
                btn100.BackColor = Color.Green;

                // Kullanıcıya bilgi ver
                MessageBox.Show($"{odaNumarasi} numaralı oda boşaltıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{odaNumarasi} numaralı oda zaten boş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            List<string> doluOdalar = VeritabanindanDoluOdalarGetir();
            string odaNumarasi = btn104.Text;

            if (doluOdalar.Contains(odaNumarasi))
            {
                // Veritabanından silme işlemi
                VeritabanindanOdaSil(odaNumarasi);

                // Buton rengini yeşile çevir
                btn100.BackColor = Color.Green;

                // Kullanıcıya bilgi ver
                MessageBox.Show($"{odaNumarasi} numaralı oda boşaltıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{odaNumarasi} numaralı oda zaten boş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            List<string> doluOdalar = VeritabanindanDoluOdalarGetir();
            string odaNumarasi = btn105.Text;

            if (doluOdalar.Contains(odaNumarasi))
            {
                // Veritabanından silme işlemi
                VeritabanindanOdaSil(odaNumarasi);

                // Buton rengini yeşile çevir
                btn100.BackColor = Color.Green;

                // Kullanıcıya bilgi ver
                MessageBox.Show($"{odaNumarasi} numaralı oda boşaltıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{odaNumarasi} numaralı oda zaten boş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
