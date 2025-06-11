namespace Warehouse.UI
{
    partial class Invoice
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
            dateTimePicker1 = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            додатиToolStripMenuItem = new ToolStripMenuItem();
            роздрукуватиToolStripMenuItem = new ToolStripMenuItem();
            застосуватиToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(514, 41);
            label1.TabIndex = 2;
            label1.Text = "Формування прибуткової накладної";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkBox_Outbound);
            panel1.Controls.Add(checkBox_Inbound);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 210);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(205, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { додатиToolStripMenuItem, роздрукуватиToolStripMenuItem, застосуватиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 161);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(888, 49);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // додатиToolStripMenuItem
            // 
            додатиToolStripMenuItem.AutoSize = false;
            додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            додатиToolStripMenuItem.Size = new Size(143, 45);
            додатиToolStripMenuItem.Text = "Додати";
            // 
            // роздрукуватиToolStripMenuItem
            // 
            роздрукуватиToolStripMenuItem.AutoSize = false;
            роздрукуватиToolStripMenuItem.Name = "роздрукуватиToolStripMenuItem";
            роздрукуватиToolStripMenuItem.Size = new Size(143, 45);
            роздрукуватиToolStripMenuItem.Text = "Роздрукувати ";
            // 
            // застосуватиToolStripMenuItem
            // 
            застосуватиToolStripMenuItem.AutoSize = false;
            застосуватиToolStripMenuItem.Name = "застосуватиToolStripMenuItem";
            застосуватиToolStripMenuItem.Size = new Size(143, 45);
            застосуватиToolStripMenuItem.Text = "Застосувати";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(888, 547);
            dataGridView1.TabIndex = 4;
            // 
            // InboundInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 547);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            MainMenuStrip = menuStrip1;
            Name = "InboundInvoice";
            Text = "Прибуткова накладна";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ToolStripMenuItem додатиToolStripMenuItem;
        private ToolStripMenuItem роздрукуватиToolStripMenuItem;
        private ToolStripMenuItem застосуватиToolStripMenuItem;
        private Label label3;
        private CheckBox checkBox_Outbound;
        private CheckBox checkBox_Inbound;
    }
}