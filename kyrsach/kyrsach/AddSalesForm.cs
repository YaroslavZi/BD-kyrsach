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
    public partial class AddSalesForm : Form
    {
        int updateID = 0;
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
        string sql1 = "SELECT * FROM Products";
        string sql2 = "SELECT * FROM Workers";
        DataSet ds;
        SqlDataAdapter adapter;
        public AddSalesForm()
        {
            InitializeComponent();
            Text = "Добавить продажу";
        }
        public AddSalesForm(int id)
        {
            InitializeComponent();
            Text = "Изменить продажу";
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

                    string query = "INSERT INTO Sales (WorkerID, ProductID, SalesCount, SalesDate)";
                    query += " VALUES ( @WorkerID, @ProductID, @SalesCount, @SalesDate)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@WorkerID", workerCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@ProductID", productCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@SalesCount", salesCountTB.Text);
                    myCommand.Parameters.AddWithValue("@SalesDate", salesDateTB.Text);

                    string query2 = "SELECT Count FROM Products WHERE ProductID=@ProductID"; // удаляем 1 книгу из таблицы книг
                    SqlCommand myCommand2 = new SqlCommand(query2, connection);
                    myCommand2.Parameters.AddWithValue("@ProductID", productCB.SelectedValue);
                    int ProductCount = Convert.ToInt32(myCommand2.ExecuteScalar());


                    string query1 = "UPDATE Products Set Count = Count - 1  WHERE ProductID=@ProductID"; // удаляем 1 книгу из таблицы книг
                    SqlCommand myCommand1 = new SqlCommand(query1, connection);
                    myCommand1.Parameters.AddWithValue("@ProductID", productCB.SelectedValue);



                    try
                    {
                        if (ProductCount > 0)
                        {
                            myCommand.ExecuteNonQuery();
                            myCommand1.ExecuteNonQuery();
                        }
                        else MessageBox.Show("Товар закончился", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
                    string query = "UPDATE Sales Set WorkerID = @WorkerID, ProductID = @ProductID, SalesCount = @SalesCount, SalesDate = @SalesDate   WHERE SaleID=@ID";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@WorkerID", workerCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@ProductID", productCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@SalesCount", salesCountTB.Text);
                    myCommand.Parameters.AddWithValue("@SalesDate", salesDateTB.Text);
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

        private void AddSalesForm_Load(object sender, EventArgs e)
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
                workerCB.DataSource = ds.Tables[0];
                workerCB.DisplayMember = "FullName";
                workerCB.ValueMember = "WorkerID";
                connection.Close();
            }


            if (updateID != 0)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True"))
                {
                    string cmd = "select * from Sales where SaleID=@ID";
                    SqlCommand cmd2 = new SqlCommand(cmd, connection);
                    cmd2.Parameters.AddWithValue("@ID", updateID);
                    connection.Open();
                    SqlDataReader reader = cmd2.ExecuteReader();
                    reader.Read();
                    productCB.SelectedValue = reader[2].ToString();
                    workerCB.SelectedValue = reader[1].ToString();
                    salesCountTB.Text = reader[3].ToString();
                    salesDateTB.Text = reader[4].ToString();
                    connection.Close();
                }
            }
        }
    }
}
