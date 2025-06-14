using Warehouse.DatabaseRepo;

namespace Warehouse.UI;

public partial class EditProduct : Form
{
    Database _database;
    public event EventHandler ProductEdited;

    int productId;

    public EditProduct(Database database, DataGridViewRow editedRow, bool isInvoice = false, bool isUnique = false)
    {
        InitializeComponent();
        _database = database;

        productId = (int)editedRow.Cells["Id"].Value;


        textBoxEditName.Text = (string)editedRow.Cells["ProductName"].Value;
        textBoxEditMeasureUnit.Text = (string)editedRow.Cells["MeasureUnit"].Value;
        textBoxEditPricePerUnit.Text = ((double)editedRow.Cells["PricePerUnit"].Value).ToString();
        textBoxEditQuantity.Text = ((int)editedRow.Cells["Quantity"].Value).ToString();



        if (isInvoice)
        {
            textBoxEditQuantity.Enabled = true;
        }

        if (isInvoice & !isUnique)
        {
            textBoxEditName.Enabled = false;
            textBoxEditMeasureUnit.Enabled = false;
            textBoxEditPricePerUnit.Enabled = false;
        }
    }

    private void buttonEditProduct_Click(object sender, EventArgs e)
    {
        string name = textBoxEditName.Text;
        string measureUnit = textBoxEditMeasureUnit.Text;
        double pricePerUnit = double.Parse(textBoxEditPricePerUnit.Text);
        int quantity = (int)double.Parse(textBoxEditQuantity.Text);

        _database.EditProduct(productId, name, measureUnit, pricePerUnit, quantity);

        ProductEdited?.Invoke(this, EventArgs.Empty);
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

    private void enableOnlyDoubleInput(object sender, KeyPressEventArgs e)
    {
        WarehouseUtils.enableOnlyDoubleInput(sender, e, textBoxEditPricePerUnit);
    }
}


