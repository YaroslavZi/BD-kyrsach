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
    public partial class AddCategoty : Form
    {
        public AddCategoty()
        {
            InitializeComponent();
            Text = "Добавить категорию";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");

            string query = "INSERT INTO Categories (Name)";
            query += " VALUES (@Name)";

            SqlCommand myCommand = new SqlCommand(query, connection);
            myCommand.Parameters.AddWithValue("@Name", textBox1.Text);
            connection.Open();

            try
            {
                myCommand.ExecuteNonQuery();
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Поле заполнено не верно!");
                return;
            }
            finally { connection.Close(); }

        }
    }
}
