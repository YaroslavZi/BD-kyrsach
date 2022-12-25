using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsach
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productBut_Click(object sender, EventArgs e)
        {
            Form f = new ProductsForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void salesBut_Click(object sender, EventArgs e)
        {
            Form f = new SalesForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ordersBut_Click(object sender, EventArgs e)
        {
            Form f = new OrdersForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void workersBut_Click(object sender, EventArgs e)
        {
            Form f = new WorkerForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new ProvidersForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
