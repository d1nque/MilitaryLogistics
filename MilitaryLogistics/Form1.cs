using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryLogistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Locations newForm = new Locations();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suppliers newForm = new Suppliers();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupplyRoutes newForm = new SupplyRoutes();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rescources newForm = new Rescources();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Orders newForm = new Orders();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderItems newForm = new OrderItems();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }
    }
}
