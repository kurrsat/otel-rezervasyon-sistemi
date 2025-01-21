using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_rezarvasyon_sistemi
{
    public partial class yonetici_anaekranı : Form
    {
        public yonetici_anaekranı()
        {
            InitializeComponent();
        }

        private void btnrezarvasyon_Click(object sender, EventArgs e)
        {
            rezervasyonekranı rz = new rezervasyonekranı();
            rz.Show();

        }

        private void btnodalar_Click(object sender, EventArgs e)
        {
            odalar odalar = new odalar();
            odalar.Show();

        }

        private void yonetici_anaekranı_Load(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
