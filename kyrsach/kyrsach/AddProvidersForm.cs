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
    public partial class AddProvidersForm : Form
    {
        int updateID = 0;
        public AddProvidersForm()
        {
            InitializeComponent();
            Text = "Добавить поставщика";
        }
        public AddProvidersForm(int id)
        {
            InitializeComponent();
            Text = "Изменить поставщика";
            updateID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" || AddressTB.Text != "" || PhoneTB.Text != "")
            {
                if (updateID == 0)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");

                    string query = "INSERT INTO Providers (OrganizationName, PhoneNumber, Address)";
                    query += " VALUES (@OrganizationName, @PhoneNumber, @Address)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@OrganizationName", nameTB.Text);
                    myCommand.Parameters.AddWithValue("@Address", AddressTB.Text);
                    myCommand.Parameters.AddWithValue("@PhoneNumber", PhoneTB.Text);

                    connection.Open();

                    try
                    {
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Одно из полей заполнено не верно!");
                       // MessageBox.Show(ex.ToString());
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
                    string query = "UPDATE Providers Set OrganizationName = @OrganizationName, PhoneNumber = @PhoneNumber, Address = @Address WHERE ProviderID=@ID";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@OrganizationName", nameTB.Text);
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

        private void AddProvidersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
