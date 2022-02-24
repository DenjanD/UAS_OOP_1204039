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
    public partial class UpdateMahasiswa : Form
    {
        private DataSet dsMahasiswa;
        public UpdateMahasiswa()
        {
            InitializeComponent();
            refreshDs();
        }

        public DataSet mahasiswaDataSet()
        {
            DataSet ds = new DataSet();

            try
            {
                string conn = "integrated security=true;data source=.;initial catalog=UAS";

                SqlConnection connection = new SqlConnection(conn);

                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandText = "SELECT * FROM ms_mhs";
                command.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.TableMappings.Add("Table", "Mahasiswa");

                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ds;
        }

        private void refreshDs()
        {
            dsMahasiswa = mahasiswaDataSet();
            gridMahasiswa.DataSource = dsMahasiswa.Tables["Mahasiswa"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "integrated security=true;data source=.;initial catalog=UAS";
            SqlConnection connection = new SqlConnection(conn);

            connection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM ms_mhs", connection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            SqlTransaction myTransaction;

            myTransaction = connection.BeginTransaction();
            myAdapter.DeleteCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;
            myAdapter.InsertCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(dsMahasiswa, "Mahasiswa");

                myTransaction.Commit();

                MessageBox.Show(rowsUpdated.ToString() + " baris diperbarui", "informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshDs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
                myTransaction.Rollback();
            }
        }
    }
}
