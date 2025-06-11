using Warehouse.DatabaseRepo;

namespace Warehouse.UI
{
    public partial class FilterProduct : Form
    {
        private Database _database;
        public event EventHandler FilterApplied;

        public FilterProduct(Database database)
        {
            InitializeComponent();
            _database = database;
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            string[] selectionOptions = new string[] { "=", ">", "<" };
            comboBox1.Items.AddRange(selectionOptions);
            comboBox2.Items.AddRange(selectionOptions);
            comboBox3.Items.AddRange(selectionOptions);

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void buttonApplyFilterProduct_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? dateFrom = dateTimePicker1.Checked ? dateTimePicker1.Value.Date : null;
                DateTime? dateTo = dateTimePicker2.Checked ? dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1) : null;

                string measureUnit = textBoxFilterMeasureUnit.Text.Trim();

                string quantityOperator = comboBox1.SelectedItem?.ToString();
                int? quantityValue = GetIntegerValue(textBoxFilterQuantity.Text);

                string priceOperator = comboBox2.SelectedItem?.ToString();
                double? priceValue = GetDoubleValue(textBoxFilterPricePerUnit.Text); // Змінено на double

                string totalPriceOperator = comboBox3.SelectedItem?.ToString();
                double? totalPriceValue = GetDoubleValue(textBoxFilterTotalPrice.Text); // Змінено на double

                _database.ApplyFilter(dateFrom, dateTo, measureUnit,
                                    quantityOperator, quantityValue,
                                    priceOperator, priceValue,
                                    totalPriceOperator, totalPriceValue);

                FilterApplied?.Invoke(this, EventArgs.Empty);

                MessageBox.Show("Фільтр успішно застосовано!", "Інформація",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Перевірте правильність введених числових значень",
                               "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка при застосуванні фільтра: {ex.Message}",
                               "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResetFilterProduct_Click(object sender, EventArgs e)
        {
            _database.ClearFilter();
            FilterApplied?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("Фільтр скинуто!", "Інформація",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private int? GetIntegerValue(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return null;

            if (int.TryParse(text, out int value))
                return value;

            throw new FormatException($"Неправильне числове значення: {text}");
        }

        // Новий метод для роботи з double значеннями
        private double? GetDoubleValue(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return null;

            if (double.TryParse(text, out double value))
                return value;

            throw new FormatException($"Неправильне числове значення: {text}");
        }

        private void EnableOnlyDigitInput(object sender, KeyPressEventArgs e)
        {
            // Дозволяємо цифри, крапку, кому та Backspace для десяткових чисел
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBoxFilterQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Для кількості дозволяємо тільки цілі числа
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxFilterPricePerUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnableOnlyDigitInput(sender, e);
        }

        private void textBoxFilterTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnableOnlyDigitInput(sender, e);
        }
    }
}