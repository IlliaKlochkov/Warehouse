namespace Warehouse.UI
{
    partial class EditingQuantity
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
            buttonEditRestock = new Button();
            label1 = new Label();
            textBoxEditQuantity = new TextBox();
            buttonEditWriteOff = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonEditRestock
            // 
            buttonEditRestock.Location = new Point(9, 122);
            buttonEditRestock.Name = "buttonEditRestock";
            buttonEditRestock.Size = new Size(160, 47);
            buttonEditRestock.TabIndex = 32;
            buttonEditRestock.Text = "📥 Поповнити ";
            buttonEditRestock.UseVisualStyleBackColor = true;
            buttonEditRestock.Click += buttonEditRestock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(316, 28);
            label1.TabIndex = 28;
            label1.Text = "Списання/Поповнення продукту";
            // 
            // textBoxEditQuantity
            // 
            textBoxEditQuantity.Location = new Point(12, 76);
            textBoxEditQuantity.Name = "textBoxEditQuantity";
            textBoxEditQuantity.Size = new Size(316, 27);
            textBoxEditQuantity.TabIndex = 26;
            // 
            // buttonEditWriteOff
            // 
            buttonEditWriteOff.Location = new Point(185, 122);
            buttonEditWriteOff.Name = "buttonEditWriteOff";
            buttonEditWriteOff.Size = new Size(143, 47);
            buttonEditWriteOff.TabIndex = 33;
            buttonEditWriteOff.Text = "📤 Списати ";
            buttonEditWriteOff.UseVisualStyleBackColor = true;
            buttonEditWriteOff.Click += buttonEditWriteOff_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 53);
            label4.Name = "label4";
            label4.Size = new Size(261, 20);
            label4.TabIndex = 34;
            label4.Text = "Кількість для списання/поповнення";
            // 
            // EditingQuantity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 182);
            Controls.Add(label4);
            Controls.Add(buttonEditWriteOff);
            Controls.Add(buttonEditRestock);
            Controls.Add(label1);
            Controls.Add(textBoxEditQuantity);
            Name = "EditingQuantity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditingQuantity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEditRestock;
        private Label label1;
        private TextBox textBoxEditQuantity;
        private Button buttonEditWriteOff;
        private Label label4;
    }
}