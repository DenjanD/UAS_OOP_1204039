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
    public partial class UpdateTransaksi : Form
    {
        private DataSet dsTransaksi;
        public UpdateTransaksi()
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
                command.CommandText = "SELECT * FROM tr_daftar_ulang";
                command.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.TableMappings.Add("Table", "DaftarUlang");

                da.Fill(ds);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ds;
        }

        private void refreshDs()
        {
            dsTransaksi = prodiDataSet();
            gridTransaksi.DataSource = dsTransaksi.Tables["DaftarUlang"];
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

            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM tr_daftar_ulang", connection);
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
                int rowsUpdated = myAdapter.Update(dsTransaksi, "DaftarUlang");

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
