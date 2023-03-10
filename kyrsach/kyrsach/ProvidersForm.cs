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

namespace kyrsach
{
    public partial class ProvidersForm : Form
    {
        public ProvidersForm()
        {
            InitializeComponent();
            Text = "Поставщики";
            RefreshData();
        }
        private void RefreshData()
        {
            prodLV.Items.Clear();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataReader dataReader = null;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
            string cmd = $"SELECT * FROM Providers";
            connection.Open();
            dataReader = new SqlCommand(cmd, connection).ExecuteReader();
            ListViewItem item = null;
            while (dataReader.Read())
            {
                item = new ListViewItem(new string[] { Convert.ToString(dataReader["ProviderID"]), Convert.ToString(dataReader["OrganizationName"]), Convert.ToString(dataReader["PhoneNumber"]), Convert.ToString(dataReader["Address"]) });
                prodLV.Items.Add(item);
            }
            da.Dispose();
            connection.Close();
            ds.Dispose();

        }
        private void addBut_Click(object sender, EventArgs e)
        {
            AddProvidersForm addWorkerForm = new AddProvidersForm();
            addWorkerForm.ShowDialog();
            RefreshData();
        }

        private void removeBut_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");

            try
            {
                foreach (int i in prodLV.SelectedIndices)
                {
                    string temp = prodLV.Items[i].Text;
                    string cmd = "delete from Providers where ProviderID='" + temp + "'";
                    SqlCommand myCommand = new SqlCommand(cmd, connection);
                    connection.Open();
                    myCommand.ExecuteNonQuery();
                    prodLV.Items.Remove(prodLV.Items[i]);
                    RefreshData();
                }

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("УДАЛИТЕ или ИЗМЕНИТЕ все поля таблиц, в которых используется этот поставщик. \n\n", "Ошибка связи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void editBut_Click(object sender, EventArgs e)
        {
            foreach (int i in prodLV.SelectedIndices)
            {

                int id = int.Parse(prodLV.Items[i].Text);
                AddProvidersForm addWorkerForm = new AddProvidersForm(id);
                addWorkerForm.ShowDialog();
                RefreshData();
            }
        }
    }
}
