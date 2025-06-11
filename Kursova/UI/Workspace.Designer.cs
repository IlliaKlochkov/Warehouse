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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workspace));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
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
            друкToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_products).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "&Файл";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(181, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(181, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 26);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(181, 26);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(181, 26);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(181, 26);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(181, 26);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(179, 26);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(179, 26);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(176, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(179, 26);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(179, 26);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(179, 26);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(176, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(179, 26);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(161, 26);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(161, 26);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(150, 26);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(150, 26);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(150, 26);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(150, 26);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView_products);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 725);
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
            dataGridView_products.Size = new Size(1087, 725);
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
            ToolStripMenuItem_removeProduct.Name = "ToolStripMenuItem_removeProduct";
            ToolStripMenuItem_removeProduct.Size = new Size(152, 40);
            ToolStripMenuItem_removeProduct.Text = "Видалити";
            ToolStripMenuItem_removeProduct.Click += ToolStripMenuItem_removeProduct_Click;
            // 
            // ToolStripMenuItem_editProduct
            // 
            ToolStripMenuItem_editProduct.AutoSize = false;
            ToolStripMenuItem_editProduct.Name = "ToolStripMenuItem_editProduct";
            ToolStripMenuItem_editProduct.Size = new Size(162, 40);
            ToolStripMenuItem_editProduct.Text = "Редагувати";
            ToolStripMenuItem_editProduct.Click += ToolStripMenuItem_editProduct_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.Dock = DockStyle.Right;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripTextBox_SearchByName, ToolStripMenuItem_SearchByName, ToolStripMenuItem_FilterProduct, ToolStripMenuItem_Invoice, ToolStripMenuItem_editProduct, ToolStripMenuItem_removeProduct, друкToolStripMenuItem });
            menuStrip2.Location = new Point(1087, 28);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(6, 2, 6, 2);
            menuStrip2.Size = new Size(175, 725);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripTextBox_SearchByName
            // 
            toolStripTextBox_SearchByName.Margin = new Padding(1, 10, 1, 0);
            toolStripTextBox_SearchByName.Name = "toolStripTextBox_SearchByName";
            toolStripTextBox_SearchByName.Size = new Size(160, 27);
            toolStripTextBox_SearchByName.KeyDown += toolStripTextBox_SearchByName_KeyDown;
            // 
            // ToolStripMenuItem_SearchByName
            // 
            ToolStripMenuItem_SearchByName.AutoSize = false;
            ToolStripMenuItem_SearchByName.Margin = new Padding(0, 0, 0, 10);
            ToolStripMenuItem_SearchByName.Name = "ToolStripMenuItem_SearchByName";
            ToolStripMenuItem_SearchByName.Size = new Size(152, 30);
            ToolStripMenuItem_SearchByName.Text = "Пошук";
            ToolStripMenuItem_SearchByName.Click += ToolStripMenuItem_SearchByName_Click;
            // 
            // ToolStripMenuItem_FilterProduct
            // 
            ToolStripMenuItem_FilterProduct.AutoSize = false;
            ToolStripMenuItem_FilterProduct.Name = "ToolStripMenuItem_FilterProduct";
            ToolStripMenuItem_FilterProduct.Size = new Size(168, 40);
            ToolStripMenuItem_FilterProduct.Text = "Фільтрувати";
            ToolStripMenuItem_FilterProduct.Click += ToolStripMenuItem_FilterProduct_Click;
            // 
            // ToolStripMenuItem_Invoice
            // 
            ToolStripMenuItem_Invoice.AutoSize = false;
            ToolStripMenuItem_Invoice.Name = "ToolStripMenuItem_Invoice";
            ToolStripMenuItem_Invoice.Size = new Size(168, 40);
            ToolStripMenuItem_Invoice.Text = "Формування накладної";
            ToolStripMenuItem_Invoice.Click += ToolStripMenuItem_Invoice_Click;
            // 
            // друкToolStripMenuItem
            // 
            друкToolStripMenuItem.AutoSize = false;
            друкToolStripMenuItem.Name = "друкToolStripMenuItem";
            друкToolStripMenuItem.Size = new Size(162, 40);
            друкToolStripMenuItem.Text = "Друк ";
            // 
            // Workspace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 753);
            Controls.Add(panel1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip1);
            Name = "Workspace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_products).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
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
    }
}