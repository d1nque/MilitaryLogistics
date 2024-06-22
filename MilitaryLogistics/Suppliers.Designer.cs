namespace MilitaryLogistics
{
    partial class Suppliers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            System.Windows.Forms.Label supplyIDLabel;
            System.Windows.Forms.Label resourceIDLabel;
            System.Windows.Forms.Label locationIDLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label supplyDateLabel;
            this.militaryDBDataSet = new MilitaryLogistics.MilitaryDBDataSet();
            this.suppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliesTableAdapter = new MilitaryLogistics.MilitaryDBDataSetTableAdapters.SuppliesTableAdapter();
            this.tableAdapterManager = new MilitaryLogistics.MilitaryDBDataSetTableAdapters.TableAdapterManager();
            this.suppliesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.suppliesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.suppliesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyIDTextBox = new System.Windows.Forms.TextBox();
            this.resourceIDTextBox = new System.Windows.Forms.TextBox();
            this.locationIDTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.supplyDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            supplyIDLabel = new System.Windows.Forms.Label();
            resourceIDLabel = new System.Windows.Forms.Label();
            locationIDLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            supplyDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.militaryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingNavigator)).BeginInit();
            this.suppliesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // militaryDBDataSet
            // 
            this.militaryDBDataSet.DataSetName = "MilitaryDBDataSet";
            this.militaryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliesBindingSource
            // 
            this.suppliesBindingSource.DataMember = "Supplies";
            this.suppliesBindingSource.DataSource = this.militaryDBDataSet;
            // 
            // suppliesTableAdapter
            // 
            this.suppliesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ResourcesTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SuppliesTableAdapter = this.suppliesTableAdapter;
            this.tableAdapterManager.SupplyRoutesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MilitaryLogistics.MilitaryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // suppliesBindingNavigator
            // 
            this.suppliesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.suppliesBindingNavigator.BindingSource = this.suppliesBindingSource;
            this.suppliesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.suppliesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.suppliesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.suppliesBindingNavigatorSaveItem});
            this.suppliesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.suppliesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.suppliesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.suppliesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.suppliesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.suppliesBindingNavigator.Name = "suppliesBindingNavigator";
            this.suppliesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.suppliesBindingNavigator.Size = new System.Drawing.Size(1006, 25);
            this.suppliesBindingNavigator.TabIndex = 0;
            this.suppliesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // suppliesBindingNavigatorSaveItem
            // 
            this.suppliesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.suppliesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("suppliesBindingNavigatorSaveItem.Image")));
            this.suppliesBindingNavigatorSaveItem.Name = "suppliesBindingNavigatorSaveItem";
            this.suppliesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.suppliesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.suppliesBindingNavigatorSaveItem.Click += new System.EventHandler(this.suppliesBindingNavigatorSaveItem_Click);
            // 
            // suppliesDataGridView
            // 
            this.suppliesDataGridView.AutoGenerateColumns = false;
            this.suppliesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.suppliesDataGridView.DataSource = this.suppliesBindingSource;
            this.suppliesDataGridView.Location = new System.Drawing.Point(394, 55);
            this.suppliesDataGridView.Name = "suppliesDataGridView";
            this.suppliesDataGridView.Size = new System.Drawing.Size(551, 354);
            this.suppliesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplyID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SupplyID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ResourceID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ResourceID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LocationID";
            this.dataGridViewTextBoxColumn3.HeaderText = "LocationID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SupplyDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "SupplyDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // supplyIDLabel
            // 
            supplyIDLabel.AutoSize = true;
            supplyIDLabel.Location = new System.Drawing.Point(53, 137);
            supplyIDLabel.Name = "supplyIDLabel";
            supplyIDLabel.Size = new System.Drawing.Size(56, 13);
            supplyIDLabel.TabIndex = 2;
            supplyIDLabel.Text = "Supply ID:";
            // 
            // supplyIDTextBox
            // 
            this.supplyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "SupplyID", true));
            this.supplyIDTextBox.Location = new System.Drawing.Point(129, 134);
            this.supplyIDTextBox.Name = "supplyIDTextBox";
            this.supplyIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.supplyIDTextBox.TabIndex = 3;
            // 
            // resourceIDLabel
            // 
            resourceIDLabel.AutoSize = true;
            resourceIDLabel.Location = new System.Drawing.Point(53, 163);
            resourceIDLabel.Name = "resourceIDLabel";
            resourceIDLabel.Size = new System.Drawing.Size(70, 13);
            resourceIDLabel.TabIndex = 4;
            resourceIDLabel.Text = "Resource ID:";
            // 
            // resourceIDTextBox
            // 
            this.resourceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "ResourceID", true));
            this.resourceIDTextBox.Location = new System.Drawing.Point(129, 160);
            this.resourceIDTextBox.Name = "resourceIDTextBox";
            this.resourceIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.resourceIDTextBox.TabIndex = 5;
            // 
            // locationIDLabel
            // 
            locationIDLabel.AutoSize = true;
            locationIDLabel.Location = new System.Drawing.Point(53, 189);
            locationIDLabel.Name = "locationIDLabel";
            locationIDLabel.Size = new System.Drawing.Size(65, 13);
            locationIDLabel.TabIndex = 6;
            locationIDLabel.Text = "Location ID:";
            // 
            // locationIDTextBox
            // 
            this.locationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "LocationID", true));
            this.locationIDTextBox.Location = new System.Drawing.Point(129, 186);
            this.locationIDTextBox.Name = "locationIDTextBox";
            this.locationIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationIDTextBox.TabIndex = 7;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(53, 215);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(129, 212);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // supplyDateLabel
            // 
            supplyDateLabel.AutoSize = true;
            supplyDateLabel.Location = new System.Drawing.Point(53, 242);
            supplyDateLabel.Name = "supplyDateLabel";
            supplyDateLabel.Size = new System.Drawing.Size(68, 13);
            supplyDateLabel.TabIndex = 10;
            supplyDateLabel.Text = "Supply Date:";
            // 
            // supplyDateDateTimePicker
            // 
            this.supplyDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.suppliesBindingSource, "SupplyDate", true));
            this.supplyDateDateTimePicker.Location = new System.Drawing.Point(129, 238);
            this.supplyDateDateTimePicker.Name = "supplyDateDateTimePicker";
            this.supplyDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.supplyDateDateTimePicker.TabIndex = 11;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(supplyIDLabel);
            this.Controls.Add(this.supplyIDTextBox);
            this.Controls.Add(resourceIDLabel);
            this.Controls.Add(this.resourceIDTextBox);
            this.Controls.Add(locationIDLabel);
            this.Controls.Add(this.locationIDTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(supplyDateLabel);
            this.Controls.Add(this.supplyDateDateTimePicker);
            this.Controls.Add(this.suppliesDataGridView);
            this.Controls.Add(this.suppliesBindingNavigator);
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.militaryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingNavigator)).EndInit();
            this.suppliesBindingNavigator.ResumeLayout(false);
            this.suppliesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MilitaryDBDataSet militaryDBDataSet;
        private System.Windows.Forms.BindingSource suppliesBindingSource;
        private MilitaryDBDataSetTableAdapters.SuppliesTableAdapter suppliesTableAdapter;
        private MilitaryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator suppliesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton suppliesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView suppliesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox supplyIDTextBox;
        private System.Windows.Forms.TextBox resourceIDTextBox;
        private System.Windows.Forms.TextBox locationIDTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.DateTimePicker supplyDateDateTimePicker;
    }
}