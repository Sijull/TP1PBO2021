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
    public partial class barangku : UserControl
    {
        private Form2 mainmenu;
        private string name;
        private string harge;
        public barangku(string nama, string harga,Form2 mainmenu)
        {
            InitializeComponent();
            this.label1.Text = nama;
            this.label2.Text = harga;
            this.mainmenu = mainmenu;
            this.name = nama;
            this.harge = harga;
        }

        private void barangku_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            detailForm detil = new detailForm(this.name,this.harge);
            this.mainmenu.OpenChildForm(detil);
        }
    }
}
