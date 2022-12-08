using Npgsql;
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
    public partial class Beranda : Form
    {
        public Beranda()
        {
            InitializeComponent();
            Saldo.Text = saldo();
            kaslabel.Text = "Rp." + kas().ToString();
            pemasukanlabel.Text = "Rp." + pemasukan().ToString();
            Pengeluaranlabel.Text = "Rp." + pengeluaran().ToString();

        }

        public static string saldo()
        {

            int uangsaldo = pemasukan()+ kas() - pengeluaran();
            return "Rp." + Convert.ToString(uangsaldo);


        }
        public static int pemasukan()
        {
            CRUD.sql = "Select SUM(jumlah_uang) As pemasukan from keuangan.kas where id_jenis = 1";
            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            int pemasukan;
            if (dt.Rows[0]["pemasukan"] == null)
            {
                pemasukan = 0;
            }
            else
            {
                pemasukan = Convert.ToInt32(dt.Rows[0]["pemasukan"].ToString());
            }

            return pemasukan;
        }

        public static int pengeluaran()
        {
            CRUD.sql = "Select SUM(jumlah_uang) As pengeluaran from keuangan.kas where id_jenis = 2";
            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            int pengeluaran;
            if (dt.Rows[0]["pengeluaran"] == null)
            {
                pengeluaran = 0;
            }
            else
            {
                pengeluaran = Convert.ToInt32(dt.Rows[0]["pengeluaran"].ToString());
            }

            return pengeluaran;
        }
        public static int kas()
        {
            CRUD.sql = "Select SUM(jumlah_uang) As kas from keuangan.kas where id_jenis = 3";
            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            int kas;
            if (dt.Rows[0]["kas"] == null)
            {
                kas = 0;
            }
            else
            {
                kas = Convert.ToInt32(dt.Rows[0]["kas"].ToString());
            }

            return kas;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lougoutbtn_Click(object sender, EventArgs e)
        {
            new Beranda().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Keuangan().Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
    
        }

        private void lougoutbtn_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Anggota().Show();
            this.Hide();
        }

        private void Saldo_Click(object sender, EventArgs e)
        {

        }

        private void detailBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Beranda_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pemasukanlabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Pengeluaranlabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
