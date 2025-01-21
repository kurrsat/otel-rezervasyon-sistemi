using MySql.Data.MySqlClient;
using otel_rezarvasyon_sistemi.DAL;
using otel_rezarvasyon_sistemi.SERVICES;
using otel_rezarvasyon_sistemi.SERVİCES;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otel_rezarvasyon_sistemi
{
    public partial class rezervasyonekranı : Form
    {

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {// Designer dosyasında
            dataGridView1.CellClick += dataGridView1_CellClick;

            // CellContentClick olayı için kodlar
        }


        public rezervasyonekranı()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        public string odanumarası { get; set; }
        public string odanumarası1 { get; set; }
        public string odanumarası2 { get; set; }
        public string odanumarası3 { get; set; }
        public string odanumarası4 { get; set; }
        public string odanumarası5 { get; set; }


        public rezervasyonekranı(string odaNo, string odano1, string odano2, string odano3, string odano4, string odano5)
        {
            InitializeComponent(); // Bunu ilk sıraya alın

            if (!string.IsNullOrEmpty(odaNo))
                odanumarası = odaNo;

            if (!string.IsNullOrEmpty(odano1))
                odanumarası1 = odano1;

            if (!string.IsNullOrEmpty(odano2))
                odanumarası2 = odano2;

            if (!string.IsNullOrEmpty(odano3))
                odanumarası3 = odano3;

            if (!string.IsNullOrEmpty(odano4))
                odanumarası4 = odano4;

            if (!string.IsNullOrEmpty(odano5))
                odanumarası5 = odano5;
        }







        private void btnkaydet_Click(object sender, EventArgs e)
        {
            (new RezervasyonServices()).RezervasyonKaydet(msktc.Text, msktel.Text, txtad.Text, txteposta.Text, cmbkisi.Text, cmbodanumara.Text, dategiris.Text, datecıkıs.Text);


            LoadDataToGrid();








        }

        public void rezarvasyonekranı_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();

            // DataGridView özelleştirme
            CustomizeDataGridView();

            odanumarası1 = cmbodanumara.SelectedItem != null ? cmbodanumara.SelectedItem.ToString() : "Varsayılan Değer";

            odanumarası2 = cmbodanumara.SelectedItem != null ? cmbodanumara.SelectedItem.ToString() : "Varsayılan Değer";

            odanumarası3 = cmbodanumara.SelectedItem != null ? cmbodanumara.SelectedItem.ToString() : "Varsayılan Değer";

            odanumarası4 = cmbodanumara.SelectedItem != null ? cmbodanumara.SelectedItem.ToString() : "Varsayılan Değer";

            odanumarası5 = cmbodanumara.SelectedItem != null ? cmbodanumara.SelectedItem.ToString() : "Varsayılan Değer";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

            txtad.Text = selectedRow.Cells["ADSOYAD"].Value?.ToString() ?? ""; // Null kontrol
            txteposta.Text = selectedRow.Cells["EPOSTA"].Value?.ToString() ?? "";
            msktc.Text = selectedRow.Cells["TC"].Value?.ToString() ?? "";
            msktel.Text = selectedRow.Cells["TELEFON"].Value?.ToString() ?? "";
            cmbkisi.Text = selectedRow.Cells["ODATİPİ"].Value?.ToString() ?? "";
            cmbodanumara.Text = selectedRow.Cells["ODALAR"].Value?.ToString() ?? "";
            dategiris.Text = selectedRow.Cells["GİRİŞTARİHİ"].Value?.ToString() ?? "";
            datecıkıs.Text = selectedRow.Cells["ÇIKIŞTARİHİ"].Value?.ToString() ?? "";
        }




        private void LoadDataToGrid()
        {
            string connectionString = "Server=172.21.54.253;Database=25_132330030;User=25_132330030;Password=!nif.ogr30AK;";
            string query = "SELECT TC, TELEFON, ADSOYAD, EPOSTA, ODATİPİ, ODALAR,GİRİŞTARİHİ,ÇIKIŞTARİHİ FROM rezervasyonlar";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Veriyi DataGridView'e bağla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yükleme sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// DataGridView özelleştirmelerini yapar
        /// </summary>
        private void CustomizeDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Sütunları otomatik genişlet
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Satır bazlı seçim
            dataGridView1.ReadOnly = true; // Sadece okunabilir yap
            dataGridView1.AllowUserToAddRows = false; // Kullanıcının yeni satır eklemesini engelle
        }








        private void btndüzenle_Click(object sender, EventArgs e)
        {
            (new rezervasyonSERVİCESgüncelle()).RezervasyonKaydet(msktc.Text, msktel.Text, txtad.Text, txteposta.Text, cmbkisi.Text, cmbodanumara.Text, dategiris.Text, datecıkıs.Text);
            LoadDataToGrid();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            (new rezervasyonSERVİCESsil()).RezervasyonKaydet(msktc.Text, msktel.Text, txtad.Text, txteposta.Text, cmbkisi.Text, cmbodanumara.Text, dategiris.Text, datecıkıs.Text);
            LoadDataToGrid();
        }

        private void datecıkıs_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


 

