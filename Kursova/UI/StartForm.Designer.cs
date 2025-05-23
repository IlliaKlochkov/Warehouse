namespace Warehouse.UI
{
    partial class StartForm
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
            panel2 = new Panel();
            panel1 = new Panel();
            buttonCreateProject = new Button();
            buttonOpenProject = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Location = new Point(0, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 0);
            panel1.TabIndex = 3;
            // 
            // buttonCreateProject
            // 
            buttonCreateProject.Font = new Font("Segoe UI", 24F);
            buttonCreateProject.Location = new Point(418, 323);
            buttonCreateProject.Name = "buttonCreateProject";
            buttonCreateProject.Size = new Size(100, 100);
            buttonCreateProject.TabIndex = 1;
            buttonCreateProject.Text = "➕";
            buttonCreateProject.UseVisualStyleBackColor = true;
            buttonCreateProject.Click += buttonCreateProject_Click;
            // 
            // buttonOpenProject
            // 
            buttonOpenProject.Font = new Font("Segoe UI", 30F);
            buttonOpenProject.Location = new Point(776, 323);
            buttonOpenProject.Name = "buttonOpenProject";
            buttonOpenProject.Size = new Size(100, 100);
            buttonOpenProject.TabIndex = 2;
            buttonOpenProject.Text = "📁";
            buttonOpenProject.UseVisualStyleBackColor = true;
            buttonOpenProject.Click += buttonOpenProject_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(218, 43);
            label1.Name = "label1";
            label1.Size = new Size(878, 120);
            label1.TabIndex = 0;
            label1.Text = "Програма не змогла знайти ваш проект :(\r\nви можете загрузити, або створити новий";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(399, 426);
            label2.Name = "label2";
            label2.Size = new Size(142, 41);
            label2.TabIndex = 5;
            label2.Text = "створити";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(752, 426);
            label3.Name = "label3";
            label3.Size = new Size(149, 41);
            label3.TabIndex = 6;
            label3.Text = "загрузити";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 753);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonCreateProject);
            Controls.Add(label1);
            Controls.Add(buttonOpenProject);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartForm";
            Shown += StartForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Button buttonCreateProject;
        private Button buttonOpenProject;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}