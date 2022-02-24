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
    public partial class ViewProdi : Form
    {
        public ViewProdi()
        {
            InitializeComponent();
            string sql = "SELECT * FROM ms_prodi";

            string connection = "integrated security=true; data source=.; initial catalog=UAS";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            SqlCommand sc = new SqlCommand(sql, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(sc);

            sda.Fill(ds, "ms_prodi");

            gridProdi.DataSource = ds;
            gridProdi.DataMember = "ms_prodi";
            gridProdi.Refresh();

            conn.Close();
        }
    }
}
