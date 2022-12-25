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
    public partial class AddProductForm : Form
    {
        int updateID = 0;
        string sql1 = "SELECT * FROM Categories";
        DataSet ds;
        SqlDataAdapter adapter;
        public AddProductForm()
        {
            InitializeComponent();
            Text = "Добавить продукт";
        }
        public AddProductForm(int id)
        {
            InitializeComponent();
            Text = $"Изменить продукт № {id}";
            updateID = id;
        }

        private void CBPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            if (updateID == 0)
            {
                AddProduct();
            }
            else UpdateProduct();
        }

        private void AddProduct()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
            if (CBName.Text != "" || CBCount.Text != "" || CBPrice.Text != "")
            {

                string query = "INSERT INTO Products (CategoryID, Name, Count, Price)";
                query += " VALUES ( @CategoryID, @Name, @Count, @Price)";

                SqlCommand myCommand = new SqlCommand(query, connection);
                myCommand.Parameters.AddWithValue("@CategoryID", CBCategory.SelectedValue);
                myCommand.Parameters.AddWithValue("@Name", CBName.Text);
                myCommand.Parameters.AddWithValue("@Count", CBCount.Text);
                myCommand.Parameters.AddWithValue("@Price", CBPrice.Text);
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
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Одно из полей пустое!");
        }

        private void UpdateProduct()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
            if (CBName.Text != "" || CBCount.Text != "" || CBPrice.Text != "")
            {
                string query = "UPDATE Products Set CategoryID = @CategoryID, Name = @Name, Count = @Count, Price = @Price   WHERE ProductID=@ID";

                SqlCommand myCommand = new SqlCommand(query, connection);
                myCommand.Parameters.AddWithValue("@CategoryID", CBCategory.SelectedValue);
                myCommand.Parameters.AddWithValue("@Name", CBName.Text);
                myCommand.Parameters.AddWithValue("@Count", CBCount.Text);
                myCommand.Parameters.AddWithValue("@Price", CBPrice.Text);
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
                finally { connection.Close(); }
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Одно из полей пустое!");
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
            using (connection)
            {
                adapter = new SqlDataAdapter(sql1, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                CBCategory.DataSource = ds.Tables[0];
                CBCategory.DisplayMember = "Name";
                CBCategory.ValueMember = "CategoryID";
                connection.Close();
            }
            if (updateID != 0)
            {
                SqlConnection connection1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
                using (connection1)
                {

                    string cmd = "select * from Products where ProductID=@ID";
                    SqlCommand cmd2 = new SqlCommand(cmd, connection1);
                    cmd2.Parameters.AddWithValue("@ID", updateID);
                    connection1.Open();
                    SqlDataReader reader = cmd2.ExecuteReader();
                    reader.Read();
                    CBCategory.SelectedValue = reader[1].ToString();
                    CBName.Text = reader[2].ToString();
                    CBCount.Text = reader[3].ToString();
                    CBPrice.Text = reader[4].ToString();
                    connection1.Close();
                }
            }
        }
    }
}
