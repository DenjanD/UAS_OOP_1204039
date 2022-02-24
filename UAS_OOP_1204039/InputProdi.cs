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
using System.Text.RegularExpressions;
using System.Globalization;

namespace UAS_OOP_1204039
{
    public partial class InputProdi : Form
    {
        public InputProdi()
        {
            InitializeComponent();
            string getLastIdSql = "SELECT kode_prodi FROM ms_prodi ORDER BY kode_prodi DESC";

            string connection = "integrated security=true; data source=.; initial catalog=UAS";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand sc = new SqlCommand(getLastIdSql, conn);
            SqlDataReader result;

            result = sc.ExecuteReader();

            string newKode = "";
            if (result.HasRows)
            {
                int newKodeProdi = 0;
                while (result.Read())
                {
                    newKode = result["kode_prodi"].ToString();
                    string angkaKode = Regex.Match(newKode, @"\d+").Value;
                    newKodeProdi = Int16.Parse(angkaKode) + 1;
                    if (newKodeProdi >= 10)
                    {
                        newKode = "PRD" + newKodeProdi;
                    }
                    else
                    {
                        newKode = "PRD0" + newKodeProdi;
                    }
                    break;
                }
            }
            else
            {
                newKode = "PRD01";
            }
            kodeProdiTB.Text = newKode;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SubmitBT_Click(object sender, EventArgs e)
        {
            int i;
            if (namaProdiTB.Text != "" && !namaProdiTB.Text.ToString().Any(char.IsDigit)) {
                if (singkatanTB.Text != "")
                {
                    if (biayaKuliahTB.Text != "" && int.TryParse(biayaKuliahTB.Text.ToString(), out i))
                    {
                        string sql = "INSERT INTO ms_prodi VALUES('"
                                + kodeProdiTB.Text + "','"
                                + namaProdiTB.Text + "','"
                                + singkatanTB.Text + "','"
                                + biayaKuliahTB.Text + "')";

                        updateDatabase(sql);
                        this.Dispose();
                    } else
                    {
                        MessageBox.Show("Biaya Kuliah tidak boleh kosong dan pastikan formatnya benar!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("Singkatan Prodi tidak boleh kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {
                MessageBox.Show("Nama Prodi tidak boleh kosong dan pastikan formatnya benar!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            namaProdiTB.Text = "";
            singkatanTB.Text = "";
            biayaKuliahTB.Text = "";
        }

        private void biayaKuliahTB_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
