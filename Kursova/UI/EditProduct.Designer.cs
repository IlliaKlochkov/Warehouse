namespace Warehouse.UI
{
    partial class EditProduct
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
            buttonEditProduct = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxEditPricePerUnit = new TextBox();
            textBoxEditMeasureUnit = new TextBox();
            textBoxEditName = new TextBox();
            SuspendLayout();
            // 
            // buttonEditProduct
            // 
            buttonEditProduct.Location = new Point(12, 205);
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(319, 47);
            buttonEditProduct.TabIndex = 24;
            buttonEditProduct.Text = "✅ Зберегти зміни";
            buttonEditProduct.UseVisualStyleBackColor = true;
            buttonEditProduct.Click += buttonEditProduct_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 126);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 22;
            label5.Text = "Ціна за одиницю";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 20;
            label3.Text = "Одиниця виміру";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 19;
            label2.Text = "Назва";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 18;
            label1.Text = "Редагування продукту";
            // 
            // textBoxEditPricePerUnit
            // 
            textBoxEditPricePerUnit.Location = new Point(187, 149);
            textBoxEditPricePerUnit.Name = "textBoxEditPricePerUnit";
            textBoxEditPricePerUnit.Size = new Size(144, 27);
            textBoxEditPricePerUnit.TabIndex = 17;
            textBoxEditPricePerUnit.KeyPress += enableOnlyDigitInput;
            // 
            // textBoxEditMeasureUnit
            // 
            textBoxEditMeasureUnit.Location = new Point(12, 149);
            textBoxEditMeasureUnit.Name = "textBoxEditMeasureUnit";
            textBoxEditMeasureUnit.Size = new Size(142, 27);
            textBoxEditMeasureUnit.TabIndex = 15;
            textBoxEditMeasureUnit.KeyPress += enableOnlyLetterInput;
            // 
            // textBoxEditName
            // 
            textBoxEditName.Location = new Point(12, 75);
            textBoxEditName.Name = "textBoxEditName";
            textBoxEditName.Size = new Size(319, 27);
            textBoxEditName.TabIndex = 13;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 269);
            Controls.Add(buttonEditProduct);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEditPricePerUnit);
            Controls.Add(textBoxEditMeasureUnit);
            Controls.Add(textBoxEditName);
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProdict";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEditProduct;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxEditPricePerUnit;
        private TextBox textBoxEditMeasureUnit;
        private TextBox textBoxEditName;
    }
}