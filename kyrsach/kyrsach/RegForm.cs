using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace kyrsach
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (loginTB.Text != "" || passTB.Text != "")
            {

                SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");

                string query = "INSERT INTO Users ( UserLogin, UserPassword) VALUES (@Login, @Password)";

                SqlCommand myCommand = new SqlCommand(query, connection);
                myCommand.Parameters.AddWithValue("@Login", loginTB.Text);
                myCommand.Parameters.AddWithValue("@Password", passTB.Text);
    

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
            else MessageBox.Show("Заполните все пустые поля");
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
