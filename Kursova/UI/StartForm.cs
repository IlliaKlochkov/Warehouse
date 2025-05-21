using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova.UI
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void buttonCreateProject_Click(object sender, EventArgs e)
        {
            Workspace workspace = new Workspace();
            workspace.FormClosed += (s, e) => this.Close();
            workspace.Show();

            this.Hide();
        }

        private void buttonOpenProject_Click(object sender, EventArgs e)
        {
            using var file = new OpenFileDialog
            {
                Filter = "Text Files (*.json)|*.json|All Files (*.*)|*.*"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {

                Workspace workspace = new Workspace();
                workspace.FormClosed += (s, e) => this.Close();
                workspace.Show();

                this.Hide();
            }

        }
    }
}
