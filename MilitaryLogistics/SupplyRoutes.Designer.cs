namespace MilitaryLogistics
{
    partial class SupplyRoutes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplyRoutes));
            System.Windows.Forms.Label routeIDLabel;
            System.Windows.Forms.Label supplyIDLabel;
            System.Windows.Forms.Label startLocationIDLabel;
            System.Windows.Forms.Label endLocationIDLabel;
            System.Windows.Forms.Label routeDetailsLabel;
            this.militaryDBDataSet = new MilitaryLogistics.MilitaryDBDataSet();
            this.supplyRoutesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyRoutesTableAdapter = new MilitaryLogistics.MilitaryDBDataSetTableAdapters.SupplyRoutesTableAdapter();
            this.tableAdapterManager = new MilitaryLogistics.MilitaryDBDataSetTableAdapters.TableAdapterManager();
            this.supplyRoutesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.supplyRoutesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.supplyRoutesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeIDTextBox = new System.Windows.Forms.TextBox();
            this.supplyIDTextBox = new System.Windows.Forms.TextBox();
            this.startLocationIDTextBox = new System.Windows.Forms.TextBox();
            this.endLocationIDTextBox = new System.Windows.Forms.TextBox();
            this.routeDetailsTextBox = new System.Windows.Forms.TextBox();
            routeIDLabel = new System.Windows.Forms.Label();
            supplyIDLabel = new System.Windows.Forms.Label();
            startLocationIDLabel = new System.Windows.Forms.Label();
            endLocationIDLabel = new System.Windows.Forms.Label();
            routeDetailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.militaryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyRoutesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyRoutesBindingNavigator)).BeginInit();
            this.supplyRoutesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyRoutesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // militaryDBDataSet
            // 
            this.militaryDBDataSet.DataSetName = "MilitaryDBDataSet";
            this.militaryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyRoutesBindingSource
            // 
            this.supplyRoutesBindingSource.DataMember = "SupplyRoutes";
            this.supplyRoutesBindingSource.DataSource = this.militaryDBDataSet;
            // 
            // supplyRoutesTableAdapter
            // 
            this.supplyRoutesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ResourcesTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SuppliesTableAdapter = null;
            this.tableAdapterManager.SupplyRoutesTableAdapter = this.supplyRoutesTableAdapter;
            this.tableAdapterManager.UpdateOrder = MilitaryLogistics.MilitaryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // supplyRoutesBindingNavigator
            // 
            this.supplyRoutesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.supplyRoutesBindingNavigator.BindingSource = this.supplyRoutesBindingSource;
            this.supplyRoutesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supplyRoutesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supplyRoutesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.supplyRoutesBindingNavigatorSaveItem});
            this.supplyRoutesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.supplyRoutesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supplyRoutesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supplyRoutesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supplyRoutesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supplyRoutesBindingNavigator.Name = "supplyRoutesBindingNavigator";
            this.supplyRoutesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supplyRoutesBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.supplyRoutesBindingNavigator.TabIndex = 0;
            this.supplyRoutesBindingNavigator.Text = "bindingNavigator1";
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
            // supplyRoutesBindingNavigatorSaveItem
            // 
            this.supplyRoutesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supplyRoutesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supplyRoutesBindingNavigatorSaveItem.Image")));
            this.supplyRoutesBindingNavigatorSaveItem.Name = "supplyRoutesBindingNavigatorSaveItem";
            this.supplyRoutesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.supplyRoutesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.supplyRoutesBindingNavigatorSaveItem.Click += new System.EventHandler(this.supplyRoutesBindingNavigatorSaveItem_Click);
            // 
            // supplyRoutesDataGridView
            // 
            this.supplyRoutesDataGridView.AutoGenerateColumns = false;
            this.supplyRoutesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyRoutesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.supplyRoutesDataGridView.DataSource = this.supplyRoutesBindingSource;
            this.supplyRoutesDataGridView.Location = new System.Drawing.Point(220, 80);
            this.supplyRoutesDataGridView.Name = "supplyRoutesDataGridView";
            this.supplyRoutesDataGridView.Size = new System.Drawing.Size(568, 328);
            this.supplyRoutesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RouteID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RouteID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SupplyID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SupplyID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartLocationID";
            this.dataGridViewTextBoxColumn3.HeaderText = "StartLocationID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EndLocationID";
            this.dataGridViewTextBoxColumn4.HeaderText = "EndLocationID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RouteDetails";
            this.dataGridViewTextBoxColumn5.HeaderText = "RouteDetails";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // routeIDLabel
            // 
            routeIDLabel.AutoSize = true;
            routeIDLabel.Location = new System.Drawing.Point(18, 166);
            routeIDLabel.Name = "routeIDLabel";
            routeIDLabel.Size = new System.Drawing.Size(53, 13);
            routeIDLabel.TabIndex = 2;
            routeIDLabel.Text = "Route ID:";
            // 
            // routeIDTextBox
            // 
            this.routeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplyRoutesBindingSource, "RouteID", true));
            this.routeIDTextBox.Location = new System.Drawing.Point(114, 163);
            this.routeIDTextBox.Name = "routeIDTextBox";
            this.routeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.routeIDTextBox.TabIndex = 3;
            // 
            // supplyIDLabel
            // 
            supplyIDLabel.AutoSize = true;
            supplyIDLabel.Location = new System.Drawing.Point(18, 192);
            supplyIDLabel.Name = "supplyIDLabel";
            supplyIDLabel.Size = new System.Drawing.Size(56, 13);
            supplyIDLabel.TabIndex = 4;
            supplyIDLabel.Text = "Supply ID:";
            // 
            // supplyIDTextBox
            // 
            this.supplyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplyRoutesBindingSource, "SupplyID", true));
            this.supplyIDTextBox.Location = new System.Drawing.Point(114, 189);
            this.supplyIDTextBox.Name = "supplyIDTextBox";
            this.supplyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplyIDTextBox.TabIndex = 5;
            // 
            // startLocationIDLabel
            // 
            startLocationIDLabel.AutoSize = true;
            startLocationIDLabel.Location = new System.Drawing.Point(18, 218);
            startLocationIDLabel.Name = "startLocationIDLabel";
            startLocationIDLabel.Size = new System.Drawing.Size(90, 13);
            startLocationIDLabel.TabIndex = 6;
            startLocationIDLabel.Text = "Start Location ID:";
            // 
            // startLocationIDTextBox
            // 
            this.startLocationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplyRoutesBindingSource, "StartLocationID", true));
            this.startLocationIDTextBox.Location = new System.Drawing.Point(114, 215);
            this.startLocationIDTextBox.Name = "startLocationIDTextBox";
            this.startLocationIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.startLocationIDTextBox.TabIndex = 7;
            // 
            // endLocationIDLabel
            // 
            endLocationIDLabel.AutoSize = true;
            endLocationIDLabel.Location = new System.Drawing.Point(18, 244);
            endLocationIDLabel.Name = "endLocationIDLabel";
            endLocationIDLabel.Size = new System.Drawing.Size(87, 13);
            endLocationIDLabel.TabIndex = 8;
            endLocationIDLabel.Text = "End Location ID:";
            // 
            // endLocationIDTextBox
            // 
            this.endLocationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplyRoutesBindingSource, "EndLocationID", true));
            this.endLocationIDTextBox.Location = new System.Drawing.Point(114, 241);
            this.endLocationIDTextBox.Name = "endLocationIDTextBox";
            this.endLocationIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.endLocationIDTextBox.TabIndex = 9;
            // 
            // routeDetailsLabel
            // 
            routeDetailsLabel.AutoSize = true;
            routeDetailsLabel.Location = new System.Drawing.Point(18, 270);
            routeDetailsLabel.Name = "routeDetailsLabel";
            routeDetailsLabel.Size = new System.Drawing.Size(74, 13);
            routeDetailsLabel.TabIndex = 10;
            routeDetailsLabel.Text = "Route Details:";
            // 
            // routeDetailsTextBox
            // 
            this.routeDetailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplyRoutesBindingSource, "RouteDetails", true));
            this.routeDetailsTextBox.Location = new System.Drawing.Point(114, 267);
            this.routeDetailsTextBox.Name = "routeDetailsTextBox";
            this.routeDetailsTextBox.Size = new System.Drawing.Size(100, 20);
            this.routeDetailsTextBox.TabIndex = 11;
            // 
            // SupplyRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(routeIDLabel);
            this.Controls.Add(this.routeIDTextBox);
            this.Controls.Add(supplyIDLabel);
            this.Controls.Add(this.supplyIDTextBox);
            this.Controls.Add(startLocationIDLabel);
            this.Controls.Add(this.startLocationIDTextBox);
            this.Controls.Add(endLocationIDLabel);
            this.Controls.Add(this.endLocationIDTextBox);
            this.Controls.Add(routeDetailsLabel);
            this.Controls.Add(this.routeDetailsTextBox);
            this.Controls.Add(this.supplyRoutesDataGridView);
            this.Controls.Add(this.supplyRoutesBindingNavigator);
            this.Name = "SupplyRoutes";
            this.Text = "SupplyRoutes";
            this.Load += new System.EventHandler(this.SupplyRoutes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.militaryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyRoutesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyRoutesBindingNavigator)).EndInit();
            this.supplyRoutesBindingNavigator.ResumeLayout(false);
            this.supplyRoutesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyRoutesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MilitaryDBDataSet militaryDBDataSet;
        private System.Windows.Forms.BindingSource supplyRoutesBindingSource;
        private MilitaryDBDataSetTableAdapters.SupplyRoutesTableAdapter supplyRoutesTableAdapter;
        private MilitaryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator supplyRoutesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton supplyRoutesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView supplyRoutesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox routeIDTextBox;
        private System.Windows.Forms.TextBox supplyIDTextBox;
        private System.Windows.Forms.TextBox startLocationIDTextBox;
        private System.Windows.Forms.TextBox endLocationIDTextBox;
        private System.Windows.Forms.TextBox routeDetailsTextBox;
    }
}