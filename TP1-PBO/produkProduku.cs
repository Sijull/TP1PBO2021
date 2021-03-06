using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_PBO
{
    public partial class produkProduku : Form
    {
        private Form2 mainmenu;

        public produkProduku(Form2 mainmenu)
        {
            InitializeComponent();
            this.mainmenu = mainmenu;
            this.flowLayoutPanel1.Controls.Add(new barangku("IPOD KW","Rp.250.000,-",mainmenu));
            this.flowLayoutPanel1.Controls.Add(new barangku("Logitech GEGEGE", "Rp.450.000,-", mainmenu));
            this.flowLayoutPanel1.Controls.Add(new barangku("Tahu Sultan", "Rp.100.000,-", mainmenu));
            this.flowLayoutPanel1.Controls.Add(new barangku("Sepatu Lelang IG", "Rp.150.000,-", mainmenu));
            this.flowLayoutPanel1.Controls.Add(new barangku("Celana Gemes", "Rp.300.000,-", mainmenu));
        }

        private void produkProduku_Load(object sender, EventArgs e)
        {

        }
    }
}
