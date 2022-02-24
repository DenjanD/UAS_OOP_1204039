using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204039
{
    public partial class InputDaftarUlang : Form
    {
        public InputDaftarUlang()
        {
            InitializeComponent();
            aRB.Checked = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void NPMTB_Leave(object sender, EventArgs e)
        {
            
        }

        private void aRB_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void aRB_MouseClick(object sender, MouseEventArgs e)
        {
            int diskon = (Int16.Parse(biayaKuliahTB.Text.ToString()) * 50) / 100;
            potonganBiayaTB.Text = diskon.ToString();
            int total = Int16.Parse(biayaKuliahTB.Text.ToString()) - diskon;
            totalTB.Text = total.ToString();
        }

        private void clearBT_Click(object sender, EventArgs e)
        {
            NPMTB.Text = "";
            namaTB.Text = "";
            prodiTB.Text = "";
            biayaKuliahTB.Text = "";
            aRB.Checked = false;
            bRB.Checked = false;
            cRB.Checked = false;
            potonganBiayaTB.Text = "";
            totalTB.Text = "";
        }

        private void bRB_MouseClick(object sender, MouseEventArgs e)
        {
            int diskon = (Int16.Parse(biayaKuliahTB.Text.ToString()) * 25) / 100;
            potonganBiayaTB.Text = diskon.ToString();
            int total = Int16.Parse(biayaKuliahTB.Text.ToString()) - diskon;
            totalTB.Text = total.ToString();
        }

        private void cRB_MouseClick(object sender, MouseEventArgs e)
        {
            int diskon = (Int16.Parse(biayaKuliahTB.Text.ToString()) * 10) / 100;
            potonganBiayaTB.Text = diskon.ToString();
            int total = Int16.Parse(biayaKuliahTB.Text.ToString()) - diskon;
            totalTB.Text = total.ToString();
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

        private void submitBT_Click(object sender, EventArgs e)
        {
            if (NPMTB.Text != "" && !NPMTB.Text.ToString().Any(char.IsDigit))
            {
                if (aRB.Checked != false || bRB.Checked != false || cRB.Checked != false)
                {
                    string grade = "";
                    if (aRB.Checked)
                    {
                        grade = "A";
                    }
                    if (bRB.Checked)
                    {
                        grade = "B";
                    }
                    if (cRB.Checked)
                    {
                        grade = "C";
                    }
                    string sql = "INSERT INTO tr_daftar_ulang VALUES('"
                        + NPMTB.Text + "','"
                        + grade + "','"
                        + totalTB.Text + "')";

                    updateDatabase(sql);

                    this.Dispose();
                } else
                {
                    MessageBox.Show("Grade Selesai Mahasiswa belum dipilih!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show("NPM Mahasiswa belum diisi dan pastikan formatnya benar!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
        }

        private void cariBT_Click(object sender, EventArgs e)
        {
            string getLastIdSql = "SELECT nama_mhs,nama_prodi,biaya_kuliah FROM ms_mhs " +
                "JOIN ms_prodi ON ms_mhs.kode_prodi=ms_prodi.kode_prodi WHERE npm='" + NPMTB.Text + "'";

            string connection = "integrated security=true; data source=.; initial catalog=UAS";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand sc = new SqlCommand(getLastIdSql, conn);
            SqlDataReader result;

            result = sc.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    namaTB.Text = result["nama_mhs"].ToString();
                    prodiTB.Text = result["nama_prodi"].ToString();
                    biayaKuliahTB.Text = result["biaya_kuliah"].ToString();
                }
            }
        }
    }
}
