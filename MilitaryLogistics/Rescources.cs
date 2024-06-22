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
    public partial class Rescources : Form
    {
        public Rescources()
        {
            InitializeComponent();
        }

        private void resourcesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.resourcesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.militaryDBDataSet);

        }

        private void Rescources_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "militaryDBDataSet.Resources". При необходимости она может быть перемещена или удалена.
            this.resourcesTableAdapter.Fill(this.militaryDBDataSet.Resources);

        }
    }
}
