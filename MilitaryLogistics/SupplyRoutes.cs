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
    public partial class SupplyRoutes : Form
    {
        public SupplyRoutes()
        {
            InitializeComponent();
        }

        private void supplyRoutesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplyRoutesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.militaryDBDataSet);

        }

        private void SupplyRoutes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "militaryDBDataSet.SupplyRoutes". При необходимости она может быть перемещена или удалена.
            this.supplyRoutesTableAdapter.Fill(this.militaryDBDataSet.SupplyRoutes);

        }
    }
}
