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
    public partial class ViewMahasiswa : Form
    {
        public ViewMahasiswa()
        {
            InitializeComponent();
            string sql = "SELECT * FROM ms_mhs";

            string connection = "integrated security=true; data source=.; initial catalog=UAS";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            SqlCommand sc = new SqlCommand(sql, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sc);

            da.Fill(ds, "ms_mhs");

            gridMhs.DataSource = ds;
            gridMhs.DataMember = "ms_mhs";
            gridMhs.Refresh();

            conn.Close();
        }
    }
}
