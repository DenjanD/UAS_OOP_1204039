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
    public partial class UpdateProdi : Form
    {
        private DataSet dsProdi;
        public UpdateProdi()
        {
            InitializeComponent();
            refreshDs();
        }
        public DataSet prodiDataSet()
        {
            DataSet ds = new DataSet();

            try
            {
                string conn = "integrated security=true;data source=.;initial catalog=UAS";

                SqlConnection connection = new SqlConnection(conn);

                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandText = "SELECT * FROM ms_prodi";
                command.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.TableMappings.Add("Table", "Prodi");

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
            dsProdi = prodiDataSet();
            gridProdi.DataSource = dsProdi.Tables["Prodi"];
        }

        private void refreshBT_Click(object sender, EventArgs e)
        {
            refreshDs();
        }

        private void updateBT_Click(object sender, EventArgs e)
        {
            string conn = "integrated security=true;data source=.;initial catalog=UAS";
            SqlConnection connection = new SqlConnection(conn);

            connection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM ms_prodi", connection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            SqlTransaction myTransaction;

            myTransaction = connection.BeginTransaction();
            myAdapter.DeleteCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(dsProdi, "Prodi");

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
