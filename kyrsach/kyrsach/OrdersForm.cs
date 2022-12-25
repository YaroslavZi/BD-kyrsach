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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            Text = "Заказы";
            RefreshData();
        }
        private void RefreshData()
        {
            prodLV.Items.Clear();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataReader dataReader = null;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
            string cmd = $"SELECT Orders.OrderID, Products.Name, Providers.OrganizationName, Orders.Count, Orders.OrderDate FROM Orders inner join Products ON Orders.ProductID = Products.ProductID inner join Providers ON Orders.ProviderID = Providers.ProviderID";
            connection.Open();
            dataReader = new SqlCommand(cmd, connection).ExecuteReader();
            ListViewItem item = null;
            while (dataReader.Read())
            {
                item = new ListViewItem(new string[] { Convert.ToString(dataReader["OrderID"]), Convert.ToString(dataReader["Name"]), Convert.ToString(dataReader["OrganizationName"]), Convert.ToString(dataReader["Count"]), Convert.ToString(dataReader["OrderDate"]) });
                prodLV.Items.Add(item);
            }
            da.Dispose();
            connection.Close();
            ds.Dispose();

        }

        private void addBut_Click(object sender, EventArgs e)
        {
            AddOrdersForm addWorkerForm = new AddOrdersForm();
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
                    string cmd = "delete from Orders where OrderID='" + temp + "'";
                    SqlCommand myCommand = new SqlCommand(cmd, connection);
                    connection.Open();
                    myCommand.ExecuteNonQuery();
                    prodLV.Items.Remove(prodLV.Items[i]);
                    RefreshData();
                }

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("УДАЛИТЕ или ИЗМЕНИТЕ все поля таблиц, в которых используется этот работник. \n\n", "Ошибка связи", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                AddOrdersForm addWorkerForm = new AddOrdersForm(id);
                addWorkerForm.ShowDialog();
                RefreshData();
            }
        }

        private void searchBut_Click(object sender, EventArgs e)
        {

        }

        private void searchCB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchCB.Checked == true)
            {
                prodLV.Items.Clear();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dataReader;
                string cmd;
                SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
                try
                {
                    using (connection)
                    {

                        cmd = string.Format("SELECT Orders.OrderID, Products.Name, Providers.OrganizationName, Orders.Count, Orders.OrderDate FROM Orders inner join Products ON Orders.ProductID = Products.ProductID inner join Providers ON Orders.ProviderID = Providers.ProviderID WHERE Providers.OrganizationName like N'%" + searchTB.Text + "%' ");
                        connection.Open();

                        ListViewItem item = null;
                        dataReader = new SqlCommand(cmd, connection).ExecuteReader();
                        while (dataReader.Read())
                        {
                            item = new ListViewItem(new string[] { Convert.ToString(dataReader["OrderID"]), Convert.ToString(dataReader["Name"]), Convert.ToString(dataReader["OrganizationName"]), Convert.ToString(dataReader["Count"]), Convert.ToString(dataReader["OrderDate"]) });
                            prodLV.Items.Add(item);
                        }
                        da.Dispose();
                        connection.Close();
                        ds.Dispose();

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();

                }
            }
            else RefreshData();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
