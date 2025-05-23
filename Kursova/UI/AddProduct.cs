using Warehouse.DatabaseRepo;
using Warehouse.Models;

namespace Warehouse.UI;
public partial class AddProduct : Form
{
    private Database _database;
    public event EventHandler ProductAdded;

    public AddProduct(Database database)
    {
        InitializeComponent();
        _database = database;
    }

    private void buttonAddProduct_Click(object sender, EventArgs e)
    {
        string name = textBoxProductName.Text;
        string measureUnit = textBoxProductMeasureUnit.Text;
        string rawQuantity = textBoxProductQuantity.Text;
        string rawPricePerUnit = textBoxPricePerUnit.Text;
        DateTime lastDeliveryDate = dateTimePickerProductTime.Value;

        int quantity;
        int pricePerUnit;

        if (name == string.Empty || measureUnit == string.Empty || rawQuantity == string.Empty || rawPricePerUnit == string.Empty)
        {
            MessageBox.Show("Будь ласка заповніть всі поля", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        quantity = int.Parse(textBoxProductQuantity.Text);
        pricePerUnit = int.Parse(textBoxPricePerUnit.Text);

        if (quantity <= 0 || pricePerUnit <= 0)
        {
            MessageBox.Show("Кількість та ціна не можуть бути менші за 0", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        int id = _database.GetNextProductId();

        Product product = new Product(id, name, measureUnit, pricePerUnit, quantity, lastDeliveryDate);
        _database.AddProduct(product);

        ProductAdded?.Invoke(this, EventArgs.Empty);

        this.Close();
    }

    private void enableOnlyLetterInput(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }

    private void enableOnlyDigitInput(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }
}