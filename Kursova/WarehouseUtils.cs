using Warehouse.DatabaseRepo;
using Warehouse.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Warehouse;

public class WarehouseUtils // Допоміжний клас для різних утилітних функцій
{
    public static void GenerateProductComboBox(Database database, ComboBox comboBox)
    {
        var items = new List<KeyValuePair<int, string>>();

        foreach (var product in database.WarehouseTableData)
        {
            items.Add(new KeyValuePair<int, string>(product.Id, $"{product.Id} ( {product.Name} )"));
        }

        comboBox.DataSource = items;
        comboBox.DisplayMember = "Value";
        comboBox.ValueMember = "Key";
    }

    public static void GenerateOperationComboBox(Product product, ComboBox comboBox)
    {
        var items = product.Operations
            .Select(pair => new KeyValuePair<DateTime, string>(pair.Key.Date, pair.Key.ToString("dd.MM.yyyy")))
            .ToList();

        comboBox.DisplayMember = "Value";
        comboBox.ValueMember = "Key";
        comboBox.DataSource = items;
    }

    public static void ValidateRowSelection(DataGridView dataGridView)
    {
        if (dataGridView.SelectedRows.Count <= 0)
        {
            MessageBox.Show("Виберіть рядок для редагування", "Попередження",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            throw new InvalidOperationException("Не вибрано рядок");
        }
    }

    public static void DeleteProductWithConfirmation(DataGridView dataGridView, Database database)
    {
        if (dataGridView.SelectedRows.Count <= 0)
        {
            MessageBox.Show("Виберіть рядок для видалення", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirmation = MessageBox.Show("Ви впевнені у своєму виборі?", "Підтвердження", MessageBoxButtons.YesNo);

        if (confirmation == DialogResult.No)
        {
            return;
        }

        if (confirmation == DialogResult.Yes)
        {
            var selectedRow = dataGridView.SelectedRows[0];
            var selectedProduct = (Product)selectedRow.DataBoundItem;
            database.RemoveProduct(selectedProduct);

        }
    }

    public static string InvoiceToString(Database invoiceDatabase, bool isInbound, DateTime invoiceDate)
    { 
        double sum = 0;
        string result = "";
        string productText = "";

        string invoice = "Товарна накладна";
        string invoiceType = $"\nТип накладної: {(isInbound ? "Прибуткова" : "Видаткова")}";
        string date = $"\nДата: {invoiceDate.ToString("dd.MM.yyyy HH:mm")}\n";
        
        foreach (Product product in invoiceDatabase.WarehouseTableData)
        {
            sum += product.TotalPrice;

            productText += "\n----------------------------------------\n";
            productText += $"ID: {product.Id} \n";
            productText += $"Назва: {product.Name}\n";
            productText += $"Одиниця виміру: {product.MeasureUnit}\n";
            productText += $"Ціна за одиницю: {product.PricePerUnit.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)} грн.\n";
            productText += $"Кількість: {product.Quantity}\n";
            productText += $"Сума: {product.TotalPrice.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}\n";
        }


        string totalPrice = $"\nВсього на {sum.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)} грн.";
        result = invoice + invoiceType + productText + totalPrice;
        return result;
    }

    public static string WarehouseProductsToString(Database warehouseDatabase, DateTime? printDate = null)
    {
        double sum = 0;
        string result = "";
        string productText = "";

        string warehouse = "Інвентарна відомість (Залишки)\n";
        string date = $"Станом на {(printDate ?? DateTime.Now).ToString("dd.MM.yyyy HH:mm")}\n";

        foreach (Product product in warehouseDatabase.WarehouseTableData)
        {
            if (product.Quantity == 0) continue;
            sum += product.TotalPrice;

            productText += "\n----------------------------------------\n";
            productText += $"ID: {product.Id} \n";
            productText += $"Назва: {product.Name}\n";
            productText += $"Одиниця виміру: {product.MeasureUnit}\n";
            productText += $"Ціна за одиницю: {product.PricePerUnit.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)} грн.\n";
            productText += $"Кількість: {product.Quantity}\n";
            productText += $"Дата останнього надходження: {product.LastDeliveryDate.ToString("dd.MM.yyyy")}\n";
            productText += $"Сума: {product.TotalPrice.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}\n";
        }

        string totalPrice = $"\nВсього на {sum.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)} грн.";
        result = warehouse + date + productText + totalPrice;
        return result;
    }

    public static void enableOnlyLetterInput(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }

    public static void enableOnlyDoubleInput(object sender, KeyPressEventArgs e, TextBox textBox)
    {
        if (e.KeyChar == '.')
        {
            e.KeyChar = ',';
        }

        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
        {
            e.Handled = true;
            return;
        }

        if (e.KeyChar == ',')
        {
            if (textBox.Text.Contains(',') || !textBox.Text.Any(char.IsDigit))
            {
                e.Handled = true;
            }
        }
    }




    public static void enableOnlyDigitInput(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }
}
