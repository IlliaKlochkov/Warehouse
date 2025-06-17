namespace Warehouse.UI
{
    partial class Workspace
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
            panel1 = new Panel();
            dataGridView_products = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FirstDeliveryDate = new DataGridViewTextBoxColumn();
            LastDeliveryDate = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            MeasureUnit = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            PricePerUnit = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            ToolStripMenuItem_removeProduct = new ToolStripMenuItem();
            ToolStripMenuItem_editProduct = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            toolStripTextBox_SearchByName = new ToolStripTextBox();
            ToolStripMenuItem_SearchByName = new ToolStripMenuItem();
            ToolStripMenuItem_FilterProduct = new ToolStripMenuItem();
            ToolStripMenuItem_Invoice = new ToolStripMenuItem();
            ToolStripMenuItem_Details = new ToolStripMenuItem();
            друкToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_products).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView_products);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 753);
            panel1.TabIndex = 2;
            // 
            // dataGridView_products
            // 
            dataGridView_products.AllowUserToAddRows = false;
            dataGridView_products.AllowUserToDeleteRows = false;
            dataGridView_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_products.Columns.AddRange(new DataGridViewColumn[] { Id, FirstDeliveryDate, LastDeliveryDate, ProductName, MeasureUnit, Quantity, PricePerUnit, TotalPrice });
            dataGridView_products.Dock = DockStyle.Fill;
            dataGridView_products.Location = new Point(0, 0);
            dataGridView_products.MultiSelect = false;
            dataGridView_products.Name = "dataGridView_products";
            dataGridView_products.ReadOnly = true;
            dataGridView_products.RowHeadersWidth = 51;
            dataGridView_products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_products.Size = new Size(1087, 753);
            dataGridView_products.TabIndex = 1;
            dataGridView_products.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            dataGridView_products.KeyDown += dataGridView_products_KeyDown;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 30F;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // FirstDeliveryDate
            // 
            FirstDeliveryDate.DataPropertyName = "FirstAddedDate";
            FirstDeliveryDate.HeaderText = "Дата завезення";
            FirstDeliveryDate.MinimumWidth = 6;
            FirstDeliveryDate.Name = "FirstDeliveryDate";
            FirstDeliveryDate.ReadOnly = true;
            // 
            // LastDeliveryDate
            // 
            LastDeliveryDate.DataPropertyName = "LastDeliveryDate";
            LastDeliveryDate.HeaderText = "Дата завезення (Остання)";
            LastDeliveryDate.MinimumWidth = 6;
            LastDeliveryDate.Name = "LastDeliveryDate";
            LastDeliveryDate.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "Name";
            ProductName.HeaderText = "Назва";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // MeasureUnit
            // 
            MeasureUnit.DataPropertyName = "MeasureUnit";
            MeasureUnit.FillWeight = 70F;
            MeasureUnit.HeaderText = "Од. виміру";
            MeasureUnit.MinimumWidth = 6;
            MeasureUnit.Name = "MeasureUnit";
            MeasureUnit.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "К-сть";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // PricePerUnit
            // 
            PricePerUnit.DataPropertyName = "PricePerUnit";
            PricePerUnit.HeaderText = "Ціна (од.)";
            PricePerUnit.MinimumWidth = 6;
            PricePerUnit.Name = "PricePerUnit";
            PricePerUnit.ReadOnly = true;
            // 
            // TotalPrice
            // 
            TotalPrice.DataPropertyName = "TotalPrice";
            TotalPrice.HeaderText = "Сума";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            // 
            // ToolStripMenuItem_removeProduct
            // 
            ToolStripMenuItem_removeProduct.AutoSize = false;
            ToolStripMenuItem_removeProduct.Image = Properties.Resources.delete_80;
            ToolStripMenuItem_removeProduct.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripMenuItem_removeProduct.Name = "ToolStripMenuItem_removeProduct";
            ToolStripMenuItem_removeProduct.Size = new Size(168, 60);
            ToolStripMenuItem_removeProduct.Text = "Видалити";
            ToolStripMenuItem_removeProduct.TextImageRelation = TextImageRelation.Overlay;
            ToolStripMenuItem_removeProduct.Click += ToolStripMenuItem_removeProduct_Click;
            // 
            // ToolStripMenuItem_editProduct
            // 
            ToolStripMenuItem_editProduct.AutoSize = false;
            ToolStripMenuItem_editProduct.Image = Properties.Resources.edit_80;
            ToolStripMenuItem_editProduct.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripMenuItem_editProduct.Name = "ToolStripMenuItem_editProduct";
            ToolStripMenuItem_editProduct.Size = new Size(168, 60);
            ToolStripMenuItem_editProduct.Text = "Редагувати";
            ToolStripMenuItem_editProduct.TextImageRelation = TextImageRelation.Overlay;
            ToolStripMenuItem_editProduct.Click += ToolStripMenuItem_editProduct_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.Dock = DockStyle.Right;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripTextBox_SearchByName, ToolStripMenuItem_SearchByName, ToolStripMenuItem_FilterProduct, ToolStripMenuItem_Invoice, ToolStripMenuItem_editProduct, ToolStripMenuItem_removeProduct, ToolStripMenuItem_Details, друкToolStripMenuItem });
            menuStrip2.Location = new Point(1087, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(6, 2, 6, 2);
            menuStrip2.Size = new Size(175, 753);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripTextBox_SearchByName
            // 
            toolStripTextBox_SearchByName.Margin = new Padding(1, 10, 1, 0);
            toolStripTextBox_SearchByName.MaxLength = 128;
            toolStripTextBox_SearchByName.Name = "toolStripTextBox_SearchByName";
            toolStripTextBox_SearchByName.Size = new Size(160, 27);
            toolStripTextBox_SearchByName.KeyDown += toolStripTextBox_SearchByName_KeyDown;
            // 
            // ToolStripMenuItem_SearchByName
            // 
            ToolStripMenuItem_SearchByName.AutoSize = false;
            ToolStripMenuItem_SearchByName.Image = Properties.Resources.search_80;
            ToolStripMenuItem_SearchByName.Margin = new Padding(0, 0, 0, 10);
            ToolStripMenuItem_SearchByName.Name = "ToolStripMenuItem_SearchByName";
            ToolStripMenuItem_SearchByName.Size = new Size(152, 28);
            ToolStripMenuItem_SearchByName.Text = "Пошук";
            ToolStripMenuItem_SearchByName.TextAlign = ContentAlignment.MiddleLeft;
            ToolStripMenuItem_SearchByName.Click += ToolStripMenuItem_SearchByName_Click;
            // 
            // ToolStripMenuItem_FilterProduct
            // 
            ToolStripMenuItem_FilterProduct.AutoSize = false;
            ToolStripMenuItem_FilterProduct.Image = Properties.Resources.filter_search_80;
            ToolStripMenuItem_FilterProduct.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripMenuItem_FilterProduct.Name = "ToolStripMenuItem_FilterProduct";
            ToolStripMenuItem_FilterProduct.Size = new Size(168, 60);
            ToolStripMenuItem_FilterProduct.Text = "Фільтрувати";
            ToolStripMenuItem_FilterProduct.TextImageRelation = TextImageRelation.Overlay;
            ToolStripMenuItem_FilterProduct.Click += ToolStripMenuItem_FilterProduct_Click;
            // 
            // ToolStripMenuItem_Invoice
            // 
            ToolStripMenuItem_Invoice.AutoSize = false;
            ToolStripMenuItem_Invoice.Image = Properties.Resources.invoice_80;
            ToolStripMenuItem_Invoice.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripMenuItem_Invoice.Name = "ToolStripMenuItem_Invoice";
            ToolStripMenuItem_Invoice.Size = new Size(168, 60);
            ToolStripMenuItem_Invoice.Text = "Формування \n накладної";
            ToolStripMenuItem_Invoice.TextImageRelation = TextImageRelation.Overlay;
            ToolStripMenuItem_Invoice.Click += ToolStripMenuItem_Invoice_Click;
            // 
            // ToolStripMenuItem_Details
            // 
            ToolStripMenuItem_Details.AutoSize = false;
            ToolStripMenuItem_Details.Image = Properties.Resources.info_80;
            ToolStripMenuItem_Details.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripMenuItem_Details.Name = "ToolStripMenuItem_Details";
            ToolStripMenuItem_Details.Size = new Size(168, 60);
            ToolStripMenuItem_Details.Text = "Детальна \nІнформація";
            ToolStripMenuItem_Details.TextImageRelation = TextImageRelation.Overlay;
            ToolStripMenuItem_Details.Click += ToolStripMenuItem_Details_Click;
            // 
            // друкToolStripMenuItem
            // 
            друкToolStripMenuItem.AutoSize = false;
            друкToolStripMenuItem.Image = Properties.Resources.print_80;
            друкToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            друкToolStripMenuItem.Name = "друкToolStripMenuItem";
            друкToolStripMenuItem.Size = new Size(168, 60);
            друкToolStripMenuItem.Text = "Друк ";
            друкToolStripMenuItem.TextImageRelation = TextImageRelation.Overlay;
            друкToolStripMenuItem.Click += ToolStripMenuItem_Print_Click;
            // 
            // Workspace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 753);
            Controls.Add(panel1);
            Controls.Add(menuStrip2);
            Name = "Workspace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Інвентарна відомість";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_products).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridView_products;
        private ToolStripMenuItem ToolStripMenuItem_removeProduct;
        private ToolStripMenuItem ToolStripMenuItem_editProduct;
        private MenuStrip menuStrip2;
        private ToolStripTextBox toolStripTextBox_SearchByName;
        private ToolStripMenuItem ToolStripMenuItem_SearchByName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstDeliveryDate;
        private DataGridViewTextBoxColumn LastDeliveryDate;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn MeasureUnit;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn PricePerUnit;
        private DataGridViewTextBoxColumn TotalPrice;
        private ToolStripMenuItem ToolStripMenuItem_FilterProduct;
        private ToolStripMenuItem ToolStripMenuItem_Invoice;
        private ToolStripMenuItem друкToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem_Details;
    }
}