namespace Kursova.UI
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
            textBoxProductName = new TextBox();
            dateTimePickerProductTime = new DateTimePicker();
            textBoxProductMeasureUnit = new TextBox();
            textBoxProductQuantity = new TextBox();
            textBoxPricePerUnit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonAddProduct = new Button();
            SuspendLayout();
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(12, 85);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(271, 27);
            textBoxProductName.TabIndex = 0;
            // 
            // dateTimePickerProductTime
            // 
            dateTimePickerProductTime.Location = new Point(301, 83);
            dateTimePickerProductTime.Name = "dateTimePickerProductTime";
            dateTimePickerProductTime.Size = new Size(200, 27);
            dateTimePickerProductTime.TabIndex = 2;
            // 
            // textBoxProductMeasureUnit
            // 
            textBoxProductMeasureUnit.Location = new Point(12, 161);
            textBoxProductMeasureUnit.Name = "textBoxProductMeasureUnit";
            textBoxProductMeasureUnit.Size = new Size(142, 27);
            textBoxProductMeasureUnit.TabIndex = 3;
            // 
            // textBoxProductQuantity
            // 
            textBoxProductQuantity.Location = new Point(171, 161);
            textBoxProductQuantity.Name = "textBoxProductQuantity";
            textBoxProductQuantity.Size = new Size(152, 27);
            textBoxProductQuantity.TabIndex = 4;
            // 
            // textBoxPricePerUnit
            // 
            textBoxPricePerUnit.Location = new Point(341, 161);
            textBoxPricePerUnit.Name = "textBoxPricePerUnit";
            textBoxPricePerUnit.Size = new Size(160, 27);
            textBoxPricePerUnit.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(298, 28);
            label1.TabIndex = 6;
            label1.Text = "Додавання продукту до складу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 7;
            label2.Text = "Назва";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 8;
            label3.Text = "Одиниця виміру";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 138);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Кількість";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 138);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 10;
            label5.Text = "Ціна за одиницю";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 62);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 11;
            label6.Text = "Дата додавання";
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(12, 209);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(489, 47);
            buttonAddProduct.TabIndex = 12;
            buttonAddProduct.Text = "✅ Додати ";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 268);
            Controls.Add(buttonAddProduct);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPricePerUnit);
            Controls.Add(textBoxProductQuantity);
            Controls.Add(textBoxProductMeasureUnit);
            Controls.Add(dateTimePickerProductTime);
            Controls.Add(textBoxProductName);
            Name = "AddProduct";
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProductName;
        private DateTimePicker dateTimePickerProductTime;
        private TextBox textBoxProductMeasureUnit;
        private TextBox textBoxProductQuantity;
        private TextBox textBoxPricePerUnit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonAddProduct;
    }
}