namespace Warehouse.UI
{
    partial class AddProduct
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
            textBox_Name = new TextBox();
            textBox_MeasureUnit = new TextBox();
            textBox_Quantity = new TextBox();
            textBox_PricePerUnit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonAddProduct = new Button();
            checkBox_NewProduct = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            comboBox_Id = new ComboBox();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Enabled = false;
            textBox_Name.Location = new Point(12, 188);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(330, 27);
            textBox_Name.TabIndex = 0;
            // 
            // textBox_MeasureUnit
            // 
            textBox_MeasureUnit.Enabled = false;
            textBox_MeasureUnit.Location = new Point(12, 250);
            textBox_MeasureUnit.Name = "textBox_MeasureUnit";
            textBox_MeasureUnit.Size = new Size(160, 27);
            textBox_MeasureUnit.TabIndex = 3;
            textBox_MeasureUnit.KeyPress += enableOnlyLetterInput;
            // 
            // textBox_Quantity
            // 
            textBox_Quantity.Location = new Point(12, 312);
            textBox_Quantity.Name = "textBox_Quantity";
            textBox_Quantity.Size = new Size(330, 27);
            textBox_Quantity.TabIndex = 4;
            textBox_Quantity.KeyPress += enableOnlyDigitInput;
            // 
            // textBox_PricePerUnit
            // 
            textBox_PricePerUnit.Enabled = false;
            textBox_PricePerUnit.Location = new Point(190, 250);
            textBox_PricePerUnit.Name = "textBox_PricePerUnit";
            textBox_PricePerUnit.Size = new Size(152, 27);
            textBox_PricePerUnit.TabIndex = 5;
            textBox_PricePerUnit.KeyPress += enableOnlyDigitInput;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 28);
            label1.TabIndex = 6;
            label1.Text = "Додавання продукту до накладної";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 165);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 7;
            label2.Text = "Назва";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 227);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 8;
            label3.Text = "Одиниця виміру";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 289);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Кількість";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 227);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 10;
            label5.Text = "Ціна за одиницю";
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(12, 364);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(330, 47);
            buttonAddProduct.TabIndex = 12;
            buttonAddProduct.Text = "✅ Додати ";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // checkBox_NewProduct
            // 
            checkBox_NewProduct.AutoSize = true;
            checkBox_NewProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox_NewProduct.Location = new Point(12, 56);
            checkBox_NewProduct.Name = "checkBox_NewProduct";
            checkBox_NewProduct.Size = new Size(160, 29);
            checkBox_NewProduct.TabIndex = 13;
            checkBox_NewProduct.Text = "Новий продукт";
            checkBox_NewProduct.UseVisualStyleBackColor = true;
            checkBox_NewProduct.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 101);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 15;
            label6.Text = "ID продукту";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 289);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 9;
            label7.Text = "Кількість";
            // 
            // comboBox_Id
            // 
            comboBox_Id.FormattingEnabled = true;
            comboBox_Id.Location = new Point(12, 124);
            comboBox_Id.Name = "comboBox_Id";
            comboBox_Id.Size = new Size(330, 28);
            comboBox_Id.TabIndex = 16;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 423);
            Controls.Add(comboBox_Id);
            Controls.Add(label6);
            Controls.Add(checkBox_NewProduct);
            Controls.Add(buttonAddProduct);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_PricePerUnit);
            Controls.Add(textBox_Quantity);
            Controls.Add(textBox_MeasureUnit);
            Controls.Add(textBox_Name);
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private TextBox textBox_MeasureUnit;
        private TextBox textBox_Quantity;
        private TextBox textBox_PricePerUnit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonAddProduct;
        private CheckBox checkBox_NewProduct;
        private Label label6;
        private Label label7;
        private ComboBox comboBox_Id;
    }
}