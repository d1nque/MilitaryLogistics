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
    public partial class Locations : Form
    {
        public Locations()
        {
            InitializeComponent();
        }

        private void locationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.militaryDBDataSet);

        }

        private void Locations_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "militaryDBDataSet.Locations". При необходимости она может быть перемещена или удалена.
            this.locationsTableAdapter.Fill(this.militaryDBDataSet.Locations);

        }
    }
}
