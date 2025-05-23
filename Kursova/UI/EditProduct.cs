using Warehouse.DatabaseRepo;
using Warehouse.Models;

namespace Warehouse.UI;

public partial class EditProduct : Form
{
    Database _database;
    public event EventHandler ProductEdited;

    int productId;

    public EditProduct(Database database, DataGridViewRow editedRow)
    {
        InitializeComponent();
        _database = database;

        productId = (int)editedRow.Cells["Id"].Value;
                                                          

        textBoxEditName.Text = (string)editedRow.Cells["ProductName"].Value;
        textBoxEditMeasureUnit.Text = (string)editedRow.Cells["MeasureUnit"].Value;
        textBoxEditPricePerUnit.Text = ((double)editedRow.Cells["PricePerUnit"].Value).ToString();
    }
    private void buttonEditProduct_Click(object sender, EventArgs e)
    {
        string name = textBoxEditName.Text;
        string measureUnit = textBoxEditMeasureUnit.Text;
        int pricePerUnit = (int)double.Parse(textBoxEditPricePerUnit.Text);

        _database.EditProduct(productId, name, measureUnit, pricePerUnit);
        
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
}


