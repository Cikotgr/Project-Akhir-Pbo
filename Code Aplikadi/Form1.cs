using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            namaPengguna.Text = Login.getUsername();
        }

        private void namaPengguna_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
            
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            new Beranda().Show();
            this.Hide();
        }
    }
}
