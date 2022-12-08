using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Anggota : Form
    {

        private string id = "";
        private int intRow = 0;

        public Anggota()
        {
            InitializeComponent();
            fillCombo();
            resetMe();
        }

        void fillCombo()
        {
           
            cmbgender.Items.Add("Pria");
            cmbgender.Items.Add("Wanita");
        }

        private void resetMe()
        {

            this.id = string.Empty;

            Txtnama.Text = "";
            Txtnim.Text = "";

            if (cmbgender.Items.Count > 0)
            {
                cmbgender.SelectedIndex = 0;
            }

            updateBtn.Text = "Update ()";
            clearBtn.Text = "Delete ()";

            cariTxt.ResetText();

            if (cariTxt.CanSelect)
            {
                cariTxt.Select();
            }

        }

        private void Anggota_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void loadData(string keyword)
        {
            string key = keyword;
            string comsql = string.Format("SELECT id_anggota, nama, nim, gender FROM keuangan.Anggota WHERE CONCAT(CAST(id_anggota as varchar), ' ', nama, ' ', nim) LIKE '%{0}%'::varchar OR TRIM(gender) LIKE '%{0}%'::varchar ORDER BY id_anggota ASC", key );

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

            Txtrows.Text = "Jumlah baris: " + intRow.ToString();

            DataGridView dgv1 = dataGridView1;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;

            dgv1.Columns[0].HeaderText = "ID";
            dgv1.Columns[1].HeaderText = "Nama";
            dgv1.Columns[2].HeaderText = "Nim";
            dgv1.Columns[3].HeaderText = "Gender";

            dgv1.Columns[0].Width = 85;
            dgv1.Columns[1].Width = 210;
            dgv1.Columns[2].Width = 230;
            dgv1.Columns[3].Width = 220;

        }

        private void execute(string mySQL, string param)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            addParameters(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void addParameters(string str)
        {
            
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("nama",Txtnama.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("nim", Txtnim.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("gender", cmbgender.SelectedItem.ToString());

            if (str == "Update" || str == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtnama.Text.Trim()) || string.IsNullOrEmpty(Txtnim.Text.Trim()))
            {
                MessageBox.Show("Please input first name and  last name.", "Insert Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "INSERT INTO keuangan.Anggota(nama, nim, gender) VALUES(@nama, @nim, @gender)";

            execute(CRUD.sql, "Insert");

            MessageBox.Show("The record has been saved.", "Insert Data ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");

            resetMe();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dataGridView1;

                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                updateBtn.Text = "Ubah (" + this.id + ")";
                clearBtn.Text = "Hapus (" + this.id + ")";

               Txtnama.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                Txtnim.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);

                cmbgender.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);

            }

        }

        private void updateBtn_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select an item from the list.", "Update Data : iBasskung Tutorial",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(Txtnama.Text.Trim()) || string.IsNullOrEmpty(Txtnim.Text.Trim()))
            {
                MessageBox.Show("Please input first name and  last name.", "Insert Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "UPDATE keuangan.Anggota SET nama = @nama, nim = @nim, gender = @gender WHERE id_anggota = @id::integer";

            execute(CRUD.sql, "Update");

            MessageBox.Show("The record has been updated.", "Update Datal",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");

            resetMe();

        }

        private void clearBtn_Click_2(object sender, EventArgs e)
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

                CRUD.sql = "DELETE FROM keuangan.Anggota WHERE id_anggota = @id::integer";

                execute(CRUD.sql, "Update");

                MessageBox.Show("The record has been deleted.", "Delete Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData("");

                resetMe();

            }

        }





        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cariTxt.Texts.Trim()))
            {
                loadData("");
            }
            else
            {
                loadData(cariTxt.Texts.Trim());
            }

            resetMe();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new Beranda().Show();
            this.Hide();
        }

        private void cmbgender_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn__TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtrows_Click(object sender, EventArgs e)
        {

        }

        private void cekKas_Click(object sender, EventArgs e)
        {
            string namatext = Txtnama.Text.ToString();
            string namasql = string.Format("select SUM(jumlah_uang) as kas from keuangan.kas k inner join keuangan.anggota a on k.id_anggota = a.id_anggota where id_jenis = 3 and nama = '{0}'", namatext);
            CRUD.sql = namasql;
            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            string uangkas = dt.Rows[0]["kas"].ToString();

            MessageBox.Show("jumlah uang kas Rp."+uangkas, "Informasi saldo ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

