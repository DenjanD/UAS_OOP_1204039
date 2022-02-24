using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UAS_OOP_1204039
{
    public partial class InputMahasiswa : Form
    {
        public InputMahasiswa()
        {
            InitializeComponent();

            string getLastIdSql = "SELECT kode_prodi,singkatan FROM ms_prodi ORDER BY kode_prodi DESC";

            string connection = "integrated security=true; data source=.; initial catalog=UAS";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand sc = new SqlCommand(getLastIdSql, conn);
            SqlDataReader result;

            result = sc.ExecuteReader();

            if (result.HasRows)
            {
                prodiCB.DisplayMember = "singkatan";
                prodiCB.ValueMember = "kode_prodi";
                DataTable dt = new DataTable();
                dt.Columns.Add("kode_prodi", typeof(string));
                dt.Columns.Add("singkatan", typeof(string));
                dt.Load(result);
                prodiCB.DataSource = dt;
            }
        }
        private void updateDatabase(string sql)
        {
            try
            {
                string connection = "integrated security=true; data source=.; initial catalog=UAS";
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Database berhasil di-update!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void submitBT_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (NPMTB.Text != "" && int.TryParse(NPMTB.Text.ToString(), out i))
            {
                if (namaMahasiswaTB.Text != "" && !namaMahasiswaTB.Text.ToString().Any(char.IsDigit))
                {
                    if (prodiCB.Text != "---Silakan Pilih Prodi---")
                    {
                        string sql = "INSERT INTO ms_mhs VALUES('"
                                    + NPMTB.Text + "','"
                                    + namaMahasiswaTB.Text + "','"
                                    + prodiCB.SelectedValue + "')";

                        updateDatabase(sql);

                        this.Dispose();
                    } else
                    {
                        MessageBox.Show("Prodi Mahasiswa belum dipilih!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("Nama Mahasiswa tidak boleh kosong dan pastikan formatnya benar!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("NPM Mahasiswa tidak boleh kosong dan pastikan formatnya benar!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void clearBT_Click(object sender, EventArgs e)
        {
            NPMTB.Text = "";
            namaMahasiswaTB.Text = "";
            prodiCB.Text = "---Silakan Pilih Prodi---";
        }
    }
}
