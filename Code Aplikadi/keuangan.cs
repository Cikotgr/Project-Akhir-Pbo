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
    public partial class Keuangan : Form
    {
        private string id = "";
        private int intRow = 0;
        public Keuangan()
        {
            InitializeComponent();
            fillCombo();
            loadData("");
        }

        private void resetMe()
        {

            this.id = string.Empty;

            TxtjumlahUang.Text = "";
            TxtKeterangan.Text = "";

            if (cmbAnggota.Items.Count > 0)
            {
                cmbAnggota.SelectedIndex = 0;
            }
            
            if (cmbJenis.Items.Count > 0)
            {
                cmbJenis.SelectedIndex = 0;
            }

            HapusBtn.Text = "Delete ()";

            //cariTxt.Clear();

            //if (cariTxt.CanSelect)
            //{
            //    cariTxt.Select();
            //}

        }
        void fillCombo()
        {
            cmbAnggota.Items.Clear();
            CRUD.con.Open();
            CRUD.sql = "select nama from keuangan.anggota";

            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            foreach (DataRow dr in dt.Rows)
            {
                cmbAnggota.Items.Add(dr["nama"].ToString());
            }
            cmbJenis.Items.Add("Pemasukan");
            cmbJenis.Items.Add("Pengeluaran");
            cmbJenis.Items.Add("kas");
            CRUD.con.Close();

        }

        
        private void loadData(string keyword)
        {
            string key = keyword;

            string comsql = string.Format("SELECT k.id_kas, jumlah_uang, nama, jenis, keterangan, waktu FROM keuangan.kas k inner join keuangan.jenis_kas p on k.id_jenis = p.id_jenis inner join keuangan.anggota a on k.id_anggota = a.id_anggota WHERE CONCAT(CAST(id_kas as varchar), ' ', nama, ' ', keterangan) LIKE '%{0}%'::varchar ORDER BY id_kas ASC", key);
            

            CRUD.sql = comsql;

            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                intRow = 0;
            }


            DataGridView dgv1 = dataGridView1;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;

            dgv1.Columns[0].HeaderText = "ID";
            dgv1.Columns[1].HeaderText = "Besar Uang";
            dgv1.Columns[2].HeaderText = "Anggota";
            dgv1.Columns[3].HeaderText = "Jenis";
            dgv1.Columns[4].HeaderText = "Keterangan";
            dgv1.Columns[5].HeaderText = "Tanggal";


            //dgv1.Columns[4].HeaderText = "Keterangan";//

            dgv1.Columns[0].Width = 85;
            dgv1.Columns[1].Width = 190;
            dgv1.Columns[2].Width = 230;
            dgv1.Columns[3].Width = 200;
            dgv1.Columns[4].Width = 220;
            dgv1.Columns[5].Width = 100;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void execute(string mySQL, string param)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            addParameters(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }
        public string id_anggota()
        {
            //CRUD.con.Open();
            string anggota = cmbAnggota.SelectedItem.ToString();
            string getId_anggotaQuery = string.Format("select * from keuangan.anggota where nama = '{0}'", anggota);
            CRUD.sql = getId_anggotaQuery;
            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            string id_anggota = dt.Rows[0]["id_anggota"].ToString();
            

            return id_anggota;


        }

        private void addParameters(string str)
        {
            //string anggota = cmbAnggota.SelectedItem.ToString();
            //string getId_anggotaQuery = string.Format("select id_anggota from keuangan.anggota where nama = '{0}'", anggota);
            //CRUD.cmd = new NpgsqlCommand(getId_anggotaQuery, CRUD.con);
            //DataTable dt1 = CRUD.PerformCRUD(CRUD.cmd);
            //CRUD.con.Close();

            //string idanggota = id_anggota();


            CRUD.cmd.Parameters.Clear();

            CRUD.cmd.Parameters.AddWithValue("jumlah_uang", Convert.ToInt32(TxtjumlahUang.Texts.Trim()));
            CRUD.cmd.Parameters.AddWithValue("keterangan", TxtKeterangan.Texts.Trim());
            //CRUD.cmd.Parameters.AddWithValue("id_anggota", idanggota.Trim());
            int getJenis = cmbJenis.SelectedIndex + 1;
            CRUD.cmd.Parameters.AddWithValue("jenis", getJenis);
            //CRUD.cmd.Parameters.AddWithValue("id_anggota", Convert.ToInt32(id_anggota()));







            if ( str == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }
        
        //private void addIdanggota()
        //{
        //    CRUD.con.Open();
        //    CRUD.cmd = CRUD.con.CreateCommand();
        //    string anggota= cmbAnggota.SelectedItem.ToString();
        //    string thecmd = string.Format("select id_anggota from keuangan.anggota where nama = '{0}'", anggota);
        //    CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
        //    CRUD.cmd.Parameters.Clear();
        //    DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
        //    CRUD.cmd.Parameters.AddWithValue("id_anggota", Convert.ToInt32(dt.ToString()));
        //}

        //private void addIdJenis()
        //{
        //    CRUD.con.Open();
        //    CRUD.cmd = CRUD.con.CreateCommand();
        //    string jenis = cmbJenis.SelectedItem.ToString();
        //    string thecmd = string.Format("select id_jenis from keuangan.kas where jenis = '{0}'", jenis);
        //    CRUD.sql = thecmd;
        //    CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
        //    CRUD.cmd.Parameters.Clear();
        //    DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
        //    dt = CRUD.PerformCRUD(CRUD.cmd);
        //    CRUD.cmd.Parameters.AddWithValue("id_jenis", Convert.ToInt32(dt.ToString()));
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
           
        //}

        private void TambahBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtjumlahUang.Texts.Trim()) || string.IsNullOrEmpty(TxtKeterangan.Texts.Trim()) || string.IsNullOrEmpty(cmbAnggota.Texts.Trim()) || string.IsNullOrEmpty(cmbJenis.Texts.Trim()))
            {

                MessageBox.Show("Masukan data secara lengkap", "Insert Data ",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //id_anggota();
            string anggota = cmbAnggota.SelectedItem.ToString();
            string getId_anggotaQuery = string.Format("select id_anggota from keuangan.anggota where nama = '{0}'", anggota);
            CRUD.sql = getId_anggotaQuery;
            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            string id_anggota = dt.Rows[0]["id_anggota"].ToString();


            string getsql = string.Format("INSERT INTO keuangan.kas(jumlah_uang, id_anggota, id_jenis, keterangan) VALUES(@jumlah_uang, '{0}', @jenis, @keterangan)",id_anggota);

            CRUD.sql = getsql;

            execute(CRUD.sql, "Insert");

            MessageBox.Show("The record has been saved.", "Insert Data : iBasskung Tutorial",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");

            resetMe();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new Beranda().Show();
            this.Hide();
        }

        private void cmbAnggota_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Keuangan_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dataGridView1;

                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                
                HapusBtn.Text = "Hapus (" + this.id + ")";

                TxtjumlahUang.Texts = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                cmbAnggota.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                cmbJenis.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);




            }
        }

        private void HapusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select an item from the list.", "Delete Data ",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Do you want to permanently delete the selected record?", "Delete Data ",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                CRUD.sql = "DELETE FROM keuangan.kas WHERE id_kas = @id::integer";

                execute(CRUD.sql, "Delete");

                MessageBox.Show("The record has been deleted.", "Delete Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData("");

                resetMe();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searcTxt.Texts.Trim()))
            {
                loadData("");
            }
            else
            {
                loadData(searcTxt.Texts.Trim());
            }

            resetMe();
        }

        private void TxtjumlahUang__TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
