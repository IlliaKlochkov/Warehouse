using Warehouse.Models;
using Warehouse.DatabaseRepo;

namespace Warehouse.UI
{
    public partial class EditingQuantity : Form
    {
        private Database _database;

        public event EventHandler QuantityEdited;

        int productId;
        int quantity;

        public EditingQuantity(Database database, DataGridViewRow editedRow)
        {
            InitializeComponent();
            _database = database;

            productId = (int)editedRow.Cells["Id"].Value;
            quantity = (int)Convert.ToDouble(editedRow.Cells["Quantity"].Value);

            //textBoxEditQuantity.Text = editedRow.Cells["Quantity"].Value.ToString();
        }

        private void buttonEditRestock_Click(object sender, EventArgs e)
        {
            int value;
            if (textBoxEditQuantity.Text == string.Empty)
            {
                MessageBox.Show("Введіть кількість для списання/поповнення", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            value = int.Parse(textBoxEditQuantity.Text);
            
            if (value <= 0)
            {
                MessageBox.Show("Кількість не може бути меншою 0 або рівною 0", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _database.EditQuantity(productId, value);
            quantity += value;

            QuantityEdited?.Invoke(this, EventArgs.Empty);
        }

        private void buttonEditWriteOff_Click(object sender, EventArgs e)
        {
            int value;
            if (textBoxEditQuantity.Text == string.Empty)
            {
                MessageBox.Show("Введіть кількість для списання/поповнення", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            value = int.Parse(textBoxEditQuantity.Text);

            if (value <= 0)
            {
                MessageBox.Show("Кількість не може бути меншою 0 або рівною 0", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (quantity - value < 0)
            {
                MessageBox.Show("Кількість товару після списання не може бути меншою за 0 \nБудь ласка введіть коректне значення", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _database.EditQuantity(productId, -value);
            quantity -= value;

            QuantityEdited?.Invoke(this, EventArgs.Empty);
        }



        private void enableOnlyDigitInput(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
