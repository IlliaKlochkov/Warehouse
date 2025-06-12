using Warehouse.DatabaseRepo;
using Warehouse.Models;

namespace Warehouse;

public class WarehouseUtils
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
}
