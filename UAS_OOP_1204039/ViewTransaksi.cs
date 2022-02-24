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
    public partial class ViewTransaksi : Form
    {
        public ViewTransaksi()
        {
            InitializeComponent();
            string sql = "SELECT ms_mhs.npm,nama_mhs,nama_prodi,grade,total_biaya FROM ms_mhs JOIN ms_prodi ON ms_mhs.kode_prodi=ms_prodi.kode_prodi JOIN tr_daftar_ulang ON ms_mhs.npm=tr_daftar_ulang.npm";

            string connection = "integrated security=true; data source=.; initial catalog=UAS";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            SqlCommand sc = new SqlCommand(sql, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(sc);

            sda.Fill(ds, "tr_daftar_ulang");

            gridTransaksi.DataSource = ds;
            gridTransaksi.DataMember = "tr_daftar_ulang";
            gridTransaksi.Refresh();

            conn.Close();
        }
    }
}
