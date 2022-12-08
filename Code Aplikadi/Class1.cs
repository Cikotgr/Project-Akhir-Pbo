using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    internal class Class1
    {
    }
    class CRUD
    {
        private static string getConnString()
        {
           
            string host = "Host=localhost;";
            string port = "Port=5432;";
            string db = "Database=Bendahara;";
            string user = "Username=postgres;";
            string pass = "Password=C1k0tegar;";

            string connString = string.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass);
            return connString;
        }

        public static NpgsqlConnection con = new NpgsqlConnection(getConnString());
        public static NpgsqlCommand cmd = default(NpgsqlCommand);
        public static string sql = string.Empty;

        public static DataTable PerformCRUD(NpgsqlCommand com)
        {
            NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                da = new NpgsqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("pesan error:" + ex.Message,"peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }
    }

    
}
