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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {

            InitializeComponent();
            RefreshData();

        }
        private void RefreshData()
        {
            prodLV.Items.Clear();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataReader dataReader = null;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
            string cmd = $"SELECT Products.ProductID, Categories.Name as Category, Products.Name, Products.Count, Products.Price FROM Products " +
                $"left join Categories ON Products.CategoryID = Categories.CategoryID ";
            connection.Open();
            dataReader = new SqlCommand(cmd, connection).ExecuteReader();
            ListViewItem item = null;
            while (dataReader.Read())
            {
                item = new ListViewItem(new string[] { Convert.ToString(dataReader["ProductID"]), Convert.ToString(dataReader["Category"]), 
                    Convert.ToString(dataReader["Name"]), Convert.ToString(dataReader["Count"]), Convert.ToString(dataReader["Price"]) });
                prodLV.Items.Add(item);
            }
            da.Dispose();
            connection.Close();
            ds.Dispose();
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm();
            addForm.ShowDialog();
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
                    string cmd = "delete from Products where ProductID='" + temp + "'";
                    SqlCommand myCommand = new SqlCommand(cmd, connection);
                    connection.Open();
                    myCommand.ExecuteNonQuery();
                    prodLV.Items.Remove(prodLV.Items[i]);
                }

                RefreshData();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Ошибка \n\n", "Ошибка связи", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                AddProductForm addBookForm = new AddProductForm(id);
                addBookForm.ShowDialog();
                RefreshData();
            }
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            AddCategoty addForm = new AddCategoty();
            addForm.ShowDialog();
            RefreshData();
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

                        cmd = string.Format("SELECT Products.ProductID, Categories.Name as Category, Products.Name, Products.Count, Products.Price FROM Products " +
                $"left join Categories ON Products.CategoryID = Categories.CategoryID WHERE Products.Name like N'%" + searchTB.Text + "%' ");
                        connection.Open();

                        ListViewItem item = null;
                        dataReader = new SqlCommand(cmd, connection).ExecuteReader();
                        while (dataReader.Read())
                        {
                            item = new ListViewItem(new string[] { Convert.ToString(dataReader["ProductID"]), Convert.ToString(dataReader["Category"]),
                    Convert.ToString(dataReader["Name"]), Convert.ToString(dataReader["Count"]), Convert.ToString(dataReader["Price"]) });
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
    }
}
