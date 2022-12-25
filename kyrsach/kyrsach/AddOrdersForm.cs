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
    public partial class AddOrdersForm : Form
    {
        int updateID = 0;
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
        string sql1 = "SELECT * FROM Products";
        string sql2 = "SELECT * FROM Providers";
        DataSet ds;
        SqlDataAdapter adapter;
        public AddOrdersForm()
        {
            InitializeComponent();
            Text = "Добавить заказ";
        }
        public AddOrdersForm(int id)
        {
            InitializeComponent();
            Text = "Изменить заказ";
            updateID = id;
        }

            private void button1_Click(object sender, EventArgs e)
        {
            if (salesCountTB.Text != "" || salesDateTB.Text != "")
            {
                if (updateID == 0)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
                    connection.Open();

                    string query = "INSERT INTO Orders (ProductID, ProviderID, Count, OrderDate)";
                    query += " VALUES (@ProductID, @ProviderID, @Count, @OrderDate)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@ProductID", productCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@ProviderID", providerCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@Count", salesCountTB.Text);
                    myCommand.Parameters.AddWithValue("@OrderDate", salesDateTB.Text);

                    try
                    {
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Одно из полей заполнено не верно!");
                        return;
                    }
                    finally
                    {
                        connection.Close();
                    }

                }

                else
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
                    string query = "UPDATE Orders Set ProductID = @ProductID, ProviderID = @ProviderID, Count = @Count, OrderDate = @OrderDate   WHERE OrderID=@ID";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@ProductID", productCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@ProviderID", providerCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@Count", salesCountTB.Text);
                    myCommand.Parameters.AddWithValue("@OrderDate", salesDateTB.Text);
                    myCommand.Parameters.AddWithValue("@ID", updateID);
                    connection.Open();

                    try
                    {
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Одно из полей заполнено не верно!");
                        return;
                    }
                    finally
                    {
                        connection.Close();

                    }
                }

                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Заполните поля");
        }

        private void AddOrdersForm_Load(object sender, EventArgs e)
        {
            using (connection)
            {


                adapter = new SqlDataAdapter(sql1, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                productCB.DataSource = ds.Tables[0];
                productCB.DisplayMember = "Name";
                productCB.ValueMember = "ProductID";
                adapter = new SqlDataAdapter(sql2, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                providerCB.DataSource = ds.Tables[0];
                providerCB.DisplayMember = "OrganizationName";
                providerCB.ValueMember = "ProviderID";
                connection.Close();
            }


            if (updateID != 0)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True"))
                {
                    string cmd = "select * from Orders where OrderID=@ID";
                    SqlCommand cmd2 = new SqlCommand(cmd, connection);
                    cmd2.Parameters.AddWithValue("@ID", updateID);
                    connection.Open();
                    SqlDataReader reader = cmd2.ExecuteReader();
                    reader.Read();
                    productCB.SelectedValue = reader[1].ToString();
                    providerCB.SelectedValue = reader[2].ToString();
                    salesCountTB.Text = reader[3].ToString();
                    salesDateTB.Text = reader[4].ToString();
                    connection.Close();
                }
            }
        }
    }
}
