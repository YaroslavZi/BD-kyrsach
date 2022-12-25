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
    public partial class AddWorkerForm : Form
    {
        int updateID = 0;
        public AddWorkerForm()
        {
            InitializeComponent();
            Text = "Добавить сотредника";
        }
        public AddWorkerForm(int id)
        {
            InitializeComponent();
            Text = "Изменить сотредника";
            updateID = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" || AddressTB.Text != "" || PhoneTB.Text != "")
            {
                if (updateID == 0)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");

                    string query = "INSERT INTO Workers (FullName, Address, PhoneNumber)";
                    query += " VALUES (@FullName, @Address, @PhoneNumber)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@FullName", nameTB.Text);
                    myCommand.Parameters.AddWithValue("@Address", AddressTB.Text);
                    myCommand.Parameters.AddWithValue("@PhoneNumber", PhoneTB.Text);

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

                else
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
                    string query = "UPDATE Workers Set FullName = @FullName, Address = @Address, PhoneNumber = @PhoneNumber WHERE WorkerID=@ID";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@FullName", nameTB.Text);
                    myCommand.Parameters.AddWithValue("@Address", AddressTB.Text);
                    myCommand.Parameters.AddWithValue("@PhoneNumber", PhoneTB.Text);
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
            else MessageBox.Show("Заполните все пустые поля");
        }

        private void AddWorkerForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
            if (updateID != 0)
            {
                using (connection)
                {
                    string cmd = "select * from Workers where WorkerID=@ID";
                    SqlCommand cmd2 = new SqlCommand(cmd, connection);
                    cmd2.Parameters.AddWithValue("@ID", updateID);
                    connection.Open();
                    SqlDataReader reader = cmd2.ExecuteReader();
                    reader.Read();
                    nameTB.Text = reader[1].ToString();
                    AddressTB.Text = reader[2].ToString();
                    PhoneTB.Text = reader[3].ToString();
                    connection.Close();
                }
            }
        }
    }
}
