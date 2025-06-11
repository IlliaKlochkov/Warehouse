using Warehouse.Models;
using Warehouse.DatabaseRepo;

namespace Warehouse.UI
{
    public partial class EditingQuantity : Form
    {
        private Database _database;
        public event EventHandler QuantityEdited;

        private int _productId;
        private int _currentQuantity;

        public EditingQuantity(Database database, DataGridViewRow editedRow)
        {
            InitializeComponent();
            _database = database;

            _productId = (int)editedRow.Cells["Id"].Value;
            _currentQuantity = (int)Convert.ToDouble(editedRow.Cells["Quantity"].Value);

            // Підключаємо обробник подій для валідації введення
            textBoxEditQuantity.KeyPress += EnableOnlyDigitInput;
        }

        private void buttonEditRestock_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out int value))
                return;

            _database.EditQuantity(_productId, value);
            _currentQuantity += value;

            QuantityEdited?.Invoke(this, EventArgs.Empty);

            MessageBox.Show($"Товар поповнено на {value} одиниць", "Успішно",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void buttonEditWriteOff_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out int value))
                return;

            if (_currentQuantity - value < 0)
            {
                MessageBox.Show("Кількість товару після списання не може бути меншою за 0\nБудь ласка введіть коректне значення",
                               "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _database.EditQuantity(_productId, -value);
            _currentQuantity -= value;

            QuantityEdited?.Invoke(this, EventArgs.Empty);

            MessageBox.Show($"Списано {value} одиниць товару", "Успішно",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private bool ValidateInput(out int value)
        {
            value = 0;

            if (string.IsNullOrWhiteSpace(textBoxEditQuantity.Text))
            {
                MessageBox.Show("Введіть кількість для списання/поповнення", "Інформація",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!int.TryParse(textBoxEditQuantity.Text, out value))
            {
                MessageBox.Show("Введіть коректне числове значення", "Помилка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (value <= 0)
            {
                MessageBox.Show("Кількість не може бути меншою 0 або рівною 0", "Інформація",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void EnableOnlyDigitInput(object sender, KeyPressEventArgs e)
        {
            // Дозволяємо тільки цифри та клавішу Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}