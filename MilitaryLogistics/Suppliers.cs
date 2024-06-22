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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void suppliesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.militaryDBDataSet);

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "militaryDBDataSet.Supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.militaryDBDataSet.Supplies);

        }
    }
}
