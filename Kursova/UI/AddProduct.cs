using Warehouse.DatabaseRepo;
using Warehouse.Models;

namespace Warehouse.UI;
public partial class AddProduct : Form
{
    private Database _invoiceDatabase;
    private Database _warehouseDatabase;

    public event EventHandler ProductAdded;
    private DateTime InvoiceDate;
    private bool isNewProduct = false;
    private bool isOutbound = false;

    public AddProduct(Database invoiceDatabase, Database warehouseDatabase, DateTime date, bool isoutbound)
    {
        InitializeComponent();

        _invoiceDatabase = invoiceDatabase;
        _warehouseDatabase = warehouseDatabase;
        isOutbound = isoutbound;
        InvoiceDate = date;

        if (isOutbound)
        {
            checkBox_NewProduct.Enabled = false;
        }

        WarehouseUtils.GenerateProductComboBox(_warehouseDatabase, comboBox_Id);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_NewProduct.Checked == true)
        {
            comboBox_Id.Enabled = false;

            textBox_Name.Enabled = true;
            textBox_MeasureUnit.Enabled = true;
            textBox_PricePerUnit.Enabled = true;

            isNewProduct = true;
        }
        else if (checkBox_NewProduct.Checked == false)
        {
            comboBox_Id.Enabled = true;
            textBox_Name.Enabled = false;
            textBox_MeasureUnit.Enabled = false;
            textBox_PricePerUnit.Enabled = false;

            isNewProduct = false;
        }
    }

    private void buttonAddProduct_Click(object sender, EventArgs e)
    {
        if (!isNewProduct)
        {
            handleExistingProduct();
            return;
        }

        handleNewProduct();
    }

    private bool isValidQuantity()
    {
        string rawQuaintity = textBox_Quantity.Text;

        if (rawQuaintity == string.Empty)
        {
            MessageBox.Show("Будь ласка, введіть кількість продукту", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        int quantity = int.Parse(rawQuaintity);
        int pricePerUnit = 1;

        if (isNewProduct)
        {
            pricePerUnit = int.Parse(textBox_PricePerUnit.Text);
        }


        if (quantity <= 0 || pricePerUnit <= 0)
        {
            MessageBox.Show("Кількість та ціна не можуть бути менші за 0", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }

    private void handleExistingProduct()
    {
        if (!isNewProduct & comboBox_Id.SelectedValue == null)
        {
            MessageBox.Show("Будь ласка, оберіть продукт з переліку", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!isValidQuantity())
        {
            return;
        }

        int selectedId = (int)comboBox_Id.SelectedValue;
        int quantity = int.Parse(textBox_Quantity.Text);
        Product selectedProduct = _warehouseDatabase.GetProductById(selectedId).Copy();

        if (!_invoiceDatabase.IsUniqueProduct(selectedProduct))
        {
            MessageBox.Show("Продукт з таким ім'ям та одиницею виміру вже доданий. Будь ласка, оберіть інше ім'я або одиницю виміру. 1",
                "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (isOutbound == true & selectedProduct.Quantity < quantity)
        {
            MessageBox.Show($"Недостатня кількість продукту на складі ({selectedProduct.Quantity})", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        selectedProduct.Quantity = quantity;
        selectedProduct.UpdateTotalPrice();

        _invoiceDatabase.AddProduct(selectedProduct);
        this.Close();
    }

    private void handleNewProduct()
    {
        string name = textBox_Name.Text;
        string measureUnit = textBox_MeasureUnit.Text;
        string rawQuantity = textBox_Quantity.Text;
        string rawPricePerUnit = textBox_PricePerUnit.Text;
        DateTime firstAddedDate = InvoiceDate;
        DateTime lastDeliveryDate = InvoiceDate;


        if (name == string.Empty || measureUnit == string.Empty || rawQuantity == string.Empty || rawPricePerUnit == string.Empty)
        {
            MessageBox.Show("Будь ласка заповніть всі поля", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (isValidQuantity() == false)
        {
            return;
        }

        int quantity = int.Parse(textBox_Quantity.Text);
        int pricePerUnit = int.Parse(textBox_PricePerUnit.Text);

        int id = _invoiceDatabase.GetNextProductId();

        Product product = new Product(id, name, measureUnit, pricePerUnit, quantity, firstAddedDate, lastDeliveryDate);

        if (!_warehouseDatabase.IsUniqueProduct(product))
        {
            MessageBox.Show("Продукт з таким ім'ям вже існує. Будь ласка, оберіть інше ім'я або одиницю виміру. 2",
                "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        _invoiceDatabase.AddProduct(product);
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