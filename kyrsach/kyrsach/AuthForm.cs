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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            string cmd = null;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True");
            try
            {
                using (connection)
                {

                    cmd = "SELECT * FROM Users  WHERE UserLogin = '" + loginTB.Text + "' and UserPassword = '" + passTB.Text + "'";

                    SqlCommand myCommand = new SqlCommand(cmd, connection);
                    da.SelectCommand = myCommand;
                    da.Fill(table);

                    if (table.Rows.Count == 1)
                    {
                        
                        MessageBox.Show("Вы успешно авторизовались", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MainForm f = new MainForm();
                        f.ShowDialog();
                        this.Show();

                    }
                    else
                    {
                        MessageBox.Show("Такого аккаунта не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




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

        private void regButton_Click(object sender, EventArgs e)
        {
            Form f = new RegForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
