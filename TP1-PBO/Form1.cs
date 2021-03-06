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
    public partial class Form1 : Form
    {
        readonly string Username = "joyjoy";
        readonly string Password = "PBO123";
        public Form2 mainMenu = new Form2();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Username && txtPassword.Text == Password)
            {
                MessageBox.Show("Kamu berhasil login");
                this.Hide();
                mainMenu.ShowDialog();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Kamu belum mengisi form login");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah ");
            }
        }

        
    }
}
