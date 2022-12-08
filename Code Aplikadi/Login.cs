using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public static string getUsername()
        {
            return "Ciko Tegar";
        }
        public string getPassword()
        {
            return "admin";
        }
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            if( textUsername.Text == getUsername() && textPassword.Text == getPassword())
            {
                new Beranda().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username atau password salah");
                textPassword.Clear();
                textUsername.Clear();
                textUsername.Focus();
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        
    }
}
