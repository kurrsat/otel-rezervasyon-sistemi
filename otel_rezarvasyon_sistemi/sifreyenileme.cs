using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_rezarvasyon_sistemi
{
    public partial class sifre_yenileme : Form
    {
        public sifre_yenileme()
        {
            InitializeComponent();
        }

        private void txtşifreyenile_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifre_yenileme_Load(object sender, EventArgs e)
        {
            txtşifreyenile.Visible = false;
            lblsifre.Visible = false;
            btnGüncelle.Visible = false;
        }


        private void btnkontrol_Click(object sender, EventArgs e)
        {
            // MySQL bağlantı dizesi
            string connectionString = "Server=172.21.54.253;Database=25_132330030;User=25_132330030;Password=!nif.ogr30AK;";

            // SQL sorgusu
            string query = "SELECT COUNT(*) FROM Yönetici WHERE güvenliksorusu = @input";

            // TextBox'taki değeri al
            string inputValue = txtsoru.Text.Trim();

            if (string.IsNullOrEmpty(inputValue))
            {
                MessageBox.Show("Lütfen güvenlik sorusunu girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Parametre ekliyoruz
                        command.Parameters.AddWithValue("@input", inputValue);

                        // Sorguyu çalıştır ve sonucu al
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            // Eşleşme bulundu
                            MessageBox.Show("Güvenlik sorusu eşleşti!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Görünürlük ayarı
                            txtşifreyenile.Visible = true;
                            lblsifre.Visible = true;
                            btnGüncelle.Visible = true;
                            btnkontrol.Visible = false;
                            txtsoru.Visible = false;
                            lblsoru.Visible = false;

                        }
                        else
                        {
                            // Eşleşme bulunamadı
                            MessageBox.Show("Güvenlik sorusu eşleşmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (MySqlException mysqlEx)
            {
                // MySQL'e özel hata mesajı
                MessageBox.Show("MySQL bağlantı hatası: " + mysqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Genel hata mesajı
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {  // MySQL bağlantı dizesi
            string connectionString = "Server=172.21.54.253;Database=25_132330030;User=25_132330030;Password=!nif.ogr30AK;";

            // TextBox'lardan alınan değerler
            string securityQuestionInput = txtsoru.Text.Trim();
            string newPassword = txtşifreyenile.Text.Trim();

            if (string.IsNullOrEmpty(securityQuestionInput) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL güncelleme sorgusu
            string query = "UPDATE Yönetici SET şifresi = @newPassword WHERE güvenliksorusu = @securityQuestion";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Parametreler
                        command.Parameters.AddWithValue("@securityQuestion", securityQuestionInput);
                        command.Parameters.AddWithValue("@newPassword", newPassword);

                        // Sorguyu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            MessageBox.Show("Şifre başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Güvenlik sorusu eşleşmedi. Güncelleme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show("MySQL bağlantı hatası: " + mysqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblsoru_Click(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

