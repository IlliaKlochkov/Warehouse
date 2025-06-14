namespace Warehouse.UI
{
    partial class FilterProduct
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxFilterMeasureUnit = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBoxFilterQuantity = new TextBox();
            label = new Label();
            label6 = new Label();
            textBoxFilterPricePerUnit = new TextBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            textBoxFilterTotalPrice = new TextBox();
            comboBox3 = new ComboBox();
            buttonApplyFilterProduct = new Button();
            buttonResetFilterProduct = new Button();
            checkBox_OnlyAvailable = new CheckBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.Location = new Point(12, 130);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(261, 130);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(201, 27);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.Value = new DateTime(2098, 11, 30, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(344, 28);
            label1.TabIndex = 19;
            label1.Text = "Фільтрування інвентарної відомості";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 20;
            label2.Text = "Дата завезення (Остання)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(222, 130);
            label3.Name = "label3";
            label3.Size = new Size(33, 25);
            label3.TabIndex = 21;
            label3.Text = "по";
            // 
            // textBoxFilterMeasureUnit
            // 
            textBoxFilterMeasureUnit.Location = new Point(15, 198);
            textBoxFilterMeasureUnit.Name = "textBoxFilterMeasureUnit";
            textBoxFilterMeasureUnit.Size = new Size(201, 27);
            textBoxFilterMeasureUnit.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 24;
            label4.Text = "Одиниця виміру ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(252, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(67, 28);
            comboBox1.TabIndex = 26;
            // 
            // textBoxFilterQuantity
            // 
            textBoxFilterQuantity.Location = new Point(337, 199);
            textBoxFilterQuantity.Name = "textBoxFilterQuantity";
            textBoxFilterQuantity.Size = new Size(125, 27);
            textBoxFilterQuantity.TabIndex = 27;
            textBoxFilterQuantity.KeyPress += enableOnlyDigitInput;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(252, 175);
            label.Name = "label";
            label.Size = new Size(70, 20);
            label.TabIndex = 28;
            label.Text = "Кількість";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 239);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 31;
            label6.Text = "Ціна за одиницю";
            // 
            // textBoxFilterPricePerUnit
            // 
            textBoxFilterPricePerUnit.Location = new Point(340, 263);
            textBoxFilterPricePerUnit.Name = "textBoxFilterPricePerUnit";
            textBoxFilterPricePerUnit.Size = new Size(125, 27);
            textBoxFilterPricePerUnit.TabIndex = 30;
            textBoxFilterPricePerUnit.KeyPress += enableOnlyDoubleInput;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(252, 262);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(67, 28);
            comboBox2.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 239);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 34;
            label5.Text = "Сума";
            // 
            // textBoxFilterTotalPrice
            // 
            textBoxFilterTotalPrice.Location = new Point(100, 263);
            textBoxFilterTotalPrice.Name = "textBoxFilterTotalPrice";
            textBoxFilterTotalPrice.Size = new Size(125, 27);
            textBoxFilterTotalPrice.TabIndex = 33;
            textBoxFilterTotalPrice.KeyPress += enableOnlyDigitInput;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(12, 262);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(67, 28);
            comboBox3.TabIndex = 32;
            // 
            // buttonApplyFilterProduct
            // 
            buttonApplyFilterProduct.Location = new Point(9, 311);
            buttonApplyFilterProduct.Name = "buttonApplyFilterProduct";
            buttonApplyFilterProduct.Size = new Size(213, 55);
            buttonApplyFilterProduct.TabIndex = 35;
            buttonApplyFilterProduct.Text = "Застосувати";
            buttonApplyFilterProduct.UseVisualStyleBackColor = true;
            buttonApplyFilterProduct.Click += buttonApplyFilterProduct_Click;
            // 
            // buttonResetFilterProduct
            // 
            buttonResetFilterProduct.Location = new Point(249, 311);
            buttonResetFilterProduct.Name = "buttonResetFilterProduct";
            buttonResetFilterProduct.Size = new Size(213, 55);
            buttonResetFilterProduct.TabIndex = 36;
            buttonResetFilterProduct.Text = "Скинути";
            buttonResetFilterProduct.UseVisualStyleBackColor = true;
            buttonResetFilterProduct.Click += buttonResetFilterProduct_Click;
            // 
            // checkBox_OnlyAvailable
            // 
            checkBox_OnlyAvailable.AutoSize = true;
            checkBox_OnlyAvailable.Font = new Font("Segoe UI", 10F);
            checkBox_OnlyAvailable.Location = new Point(15, 63);
            checkBox_OnlyAvailable.Name = "checkBox_OnlyAvailable";
            checkBox_OnlyAvailable.Size = new Size(368, 27);
            checkBox_OnlyAvailable.TabIndex = 37;
            checkBox_OnlyAvailable.Text = "Показувати тільки товари які є в наявності";
            checkBox_OnlyAvailable.UseVisualStyleBackColor = true;
            // 
            // FilterProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 378);
            Controls.Add(checkBox_OnlyAvailable);
            Controls.Add(buttonResetFilterProduct);
            Controls.Add(buttonApplyFilterProduct);
            Controls.Add(label5);
            Controls.Add(textBoxFilterTotalPrice);
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(textBoxFilterPricePerUnit);
            Controls.Add(comboBox2);
            Controls.Add(label);
            Controls.Add(textBoxFilterQuantity);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBoxFilterMeasureUnit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "FilterProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Фільтування";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxFilterMeasureUnit;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBoxFilterQuantity;
        private Label label;
        private Label label6;
        private TextBox textBoxFilterPricePerUnit;
        private ComboBox comboBox2;
        private Label label5;
        private TextBox textBoxFilterTotalPrice;
        private ComboBox comboBox3;
        private Button buttonApplyFilterProduct;
        private Button buttonResetFilterProduct;
        private CheckBox checkBox_OnlyAvailable;
    }
}