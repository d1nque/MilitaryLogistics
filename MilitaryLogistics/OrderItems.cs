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
    public partial class OrderItems : Form
    {
        public OrderItems()
        {
            InitializeComponent();
        }

        private void orderItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.militaryDBDataSet);

        }

        private void OrderItems_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "militaryDBDataSet.OrderItems". При необходимости она может быть перемещена или удалена.
            this.orderItemsTableAdapter.Fill(this.militaryDBDataSet.OrderItems);

        }
    }
}
