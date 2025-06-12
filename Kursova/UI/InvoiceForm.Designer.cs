namespace Warehouse.UI
{
    partial class InvoiceForm
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
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            checkBox_Outbound = new CheckBox();
            checkBox_Inbound = new CheckBox();
            label2 = new Label();
            dateTimePicker = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem_AddProduct = new ToolStripMenuItem();
            редагуватиToolStripMenuItem = new ToolStripMenuItem();
            видалитиToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem_Print = new ToolStripMenuItem();
            ToolStripMenuItem_ApllyChanges = new ToolStripMenuItem();
            dataGridView_Invoice = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            MeasureUnit = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            PricePerUnit = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            FirstDeliveryDate = new DataGridViewTextBoxColumn();
            LastDeliveryDate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Invoice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(336, 41);
            label1.TabIndex = 2;
            label1.Text = "Формування накладної";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkBox_Outbound);
            panel1.Controls.Add(checkBox_Inbound);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 210);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(20, 107);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 9;
            label3.Text = "Тип:";
            // 
            // checkBox_Outbound
            // 
            checkBox_Outbound.AutoSize = true;
            checkBox_Outbound.Font = new Font("Segoe UI", 11F);
            checkBox_Outbound.Location = new Point(220, 109);
            checkBox_Outbound.Name = "checkBox_Outbound";
            checkBox_Outbound.Size = new Size(124, 29);
            checkBox_Outbound.TabIndex = 8;
            checkBox_Outbound.Text = "Видаткова";
            checkBox_Outbound.UseVisualStyleBackColor = true;
            checkBox_Outbound.CheckedChanged += checkBox_Outbound_CheckedChanged;
            // 
            // checkBox_Inbound
            // 
            checkBox_Inbound.AutoSize = true;
            checkBox_Inbound.Font = new Font("Segoe UI", 11F);
            checkBox_Inbound.Location = new Point(76, 109);
            checkBox_Inbound.Name = "checkBox_Inbound";
            checkBox_Inbound.Size = new Size(138, 29);
            checkBox_Inbound.TabIndex = 7;
            checkBox_Inbound.Text = "Прибуткова";
            checkBox_Inbound.TextAlign = ContentAlignment.TopLeft;
            checkBox_Inbound.UseVisualStyleBackColor = true;
            checkBox_Inbound.CheckedChanged += checkBox_Inbound_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(19, 60);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 6;
            label2.Text = "Дата формування:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(205, 62);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(190, 27);
            dateTimePicker.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_AddProduct, редагуватиToolStripMenuItem, видалитиToolStripMenuItem, ToolStripMenuItem_Print, ToolStripMenuItem_ApllyChanges });
            menuStrip1.Location = new Point(0, 161);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(966, 49);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_AddProduct
            // 
            ToolStripMenuItem_AddProduct.AutoSize = false;
            ToolStripMenuItem_AddProduct.Image = Properties.Resources.plus_80;
            ToolStripMenuItem_AddProduct.Name = "ToolStripMenuItem_AddProduct";
            ToolStripMenuItem_AddProduct.Size = new Size(143, 45);
            ToolStripMenuItem_AddProduct.Text = "Додати";
            ToolStripMenuItem_AddProduct.Click += ToolStripMenuItem_AddProduct_Click;
            // 
            // редагуватиToolStripMenuItem
            // 
            редагуватиToolStripMenuItem.AutoSize = false;
            редагуватиToolStripMenuItem.Image = Properties.Resources.edit_80;
            редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            редагуватиToolStripMenuItem.Size = new Size(143, 45);
            редагуватиToolStripMenuItem.Text = "Редагувати";
            редагуватиToolStripMenuItem.Click += ToolStripMenuItem_Edit_Click;
            // 
            // видалитиToolStripMenuItem
            // 
            видалитиToolStripMenuItem.AutoSize = false;
            видалитиToolStripMenuItem.Image = Properties.Resources.delete_80;
            видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            видалитиToolStripMenuItem.Size = new Size(143, 45);
            видалитиToolStripMenuItem.Text = "Видалити";
            видалитиToolStripMenuItem.Click += ToolStripMenuItem_Delete_Click;
            // 
            // ToolStripMenuItem_Print
            // 
            ToolStripMenuItem_Print.AutoSize = false;
            ToolStripMenuItem_Print.Image = Properties.Resources.print_80;
            ToolStripMenuItem_Print.Name = "ToolStripMenuItem_Print";
            ToolStripMenuItem_Print.Size = new Size(143, 45);
            ToolStripMenuItem_Print.Text = "Друк";
            ToolStripMenuItem_Print.Click += ToolStripMenuItem_Print_Click;
            // 
            // ToolStripMenuItem_ApllyChanges
            // 
            ToolStripMenuItem_ApllyChanges.AutoSize = false;
            ToolStripMenuItem_ApllyChanges.Image = Properties.Resources.confirm_80;
            ToolStripMenuItem_ApllyChanges.Name = "ToolStripMenuItem_ApllyChanges";
            ToolStripMenuItem_ApllyChanges.Size = new Size(143, 45);
            ToolStripMenuItem_ApllyChanges.Text = "Застосувати";
            ToolStripMenuItem_ApllyChanges.Click += ToolStripMenuItem_ApllyChanges_Click;
            // 
            // dataGridView_Invoice
            // 
            dataGridView_Invoice.AllowUserToAddRows = false;
            dataGridView_Invoice.AllowUserToDeleteRows = false;
            dataGridView_Invoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Invoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Invoice.Columns.AddRange(new DataGridViewColumn[] { Id, ProductName, MeasureUnit, Quantity, PricePerUnit, TotalPrice, FirstDeliveryDate, LastDeliveryDate });
            dataGridView_Invoice.Dock = DockStyle.Fill;
            dataGridView_Invoice.Location = new Point(0, 210);
            dataGridView_Invoice.MultiSelect = false;
            dataGridView_Invoice.Name = "dataGridView_Invoice";
            dataGridView_Invoice.ReadOnly = true;
            dataGridView_Invoice.RowHeadersWidth = 51;
            dataGridView_Invoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Invoice.Size = new Size(966, 337);
            dataGridView_Invoice.TabIndex = 4;
            dataGridView_Invoice.KeyDown += dataGridView_Invoice_KeyDown;
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
            // FirstDeliveryDate
            // 
            FirstDeliveryDate.DataPropertyName = "FirstAddedDate";
            FirstDeliveryDate.HeaderText = "Дата завезення";
            FirstDeliveryDate.MinimumWidth = 6;
            FirstDeliveryDate.Name = "FirstDeliveryDate";
            FirstDeliveryDate.ReadOnly = true;
            FirstDeliveryDate.Visible = false;
            // 
            // LastDeliveryDate
            // 
            LastDeliveryDate.DataPropertyName = "LastDeliveryDate";
            LastDeliveryDate.HeaderText = "Дата завезення (Остання)";
            LastDeliveryDate.MinimumWidth = 6;
            LastDeliveryDate.Name = "LastDeliveryDate";
            LastDeliveryDate.ReadOnly = true;
            LastDeliveryDate.Visible = false;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 547);
            Controls.Add(dataGridView_Invoice);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "InvoiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Формування накладної";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Invoice).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private Label label2;
        private DateTimePicker dateTimePicker;
        private ToolStripMenuItem ToolStripMenuItem_AddProduct;
        private ToolStripMenuItem ToolStripMenuItem_Print;
        private ToolStripMenuItem ToolStripMenuItem_ApllyChanges;
        private Label label3;
        private CheckBox checkBox_Outbound;
        private CheckBox checkBox_Inbound;
        private DataGridView dataGridView_Invoice;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn MeasureUnit;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn PricePerUnit;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn FirstDeliveryDate;
        private DataGridViewTextBoxColumn LastDeliveryDate;
        private ToolStripMenuItem редагуватиToolStripMenuItem;
        private ToolStripMenuItem видалитиToolStripMenuItem;
    }
}