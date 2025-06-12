using System.Reflection.Emit;
using Warehouse.DatabaseRepo;
using Warehouse.Models;

namespace Warehouse.UI;


public partial class InvoiceForm : Form
{
    private Database _invoiceDatabase;
    private Database _warehouseDatabase;
    private bool isChanging = false;

    public InvoiceForm(Database warehouseDatabase)
    {
        InitializeComponent();

        _warehouseDatabase = warehouseDatabase;
        _invoiceDatabase = new Database(warehouseDatabase.AutoIncrementId);


        dataGridView_Invoice.AutoGenerateColumns = false;
        dataGridView_Invoice.DataSource = _invoiceDatabase.WarehouseTableView;

    }

    private void checkBox_Inbound_CheckedChanged(object sender, EventArgs e)
    {
        if (isChanging) return;

        isChanging = true;

        if (checkBox_Inbound.Checked)
        {
            checkBox_Outbound.Checked = false;
        }

        isChanging = false;
    }

    private void checkBox_Outbound_CheckedChanged(object sender, EventArgs e)
    {
        if (isChanging) return;

        isChanging = true;

        if (checkBox_Outbound.Checked)
        {
            checkBox_Inbound.Checked = false;
        }

        isChanging = false;
    }

    private void ToolStripMenuItem_AddProduct_Click(object sender, EventArgs e)
    {
        if (checkBox_Inbound.Checked != true & checkBox_Outbound.Checked != true)
        {
            MessageBox.Show("Будь ласка, оберіть тип накладної (прибуткова або видаткова).", "Інфорамація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        DateTime invoiceDate = dateTimePicker.Value;
        AddProduct addProductForm = new AddProduct(_invoiceDatabase, _warehouseDatabase, invoiceDate, checkBox_Outbound.Checked);
        addProductForm.Show();
    }

    private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
    {
        try
        {
            WarehouseUtils.ValidateRowSelection(dataGridView_Invoice);
            DataGridViewRow selectedRow = dataGridView_Invoice.SelectedRows[0];
            EditProduct editProductForm;

            int productId = (int)selectedRow.Cells["Id"].Value;


            if (_warehouseDatabase.GetProductById(productId) == null)
            {
                editProductForm = new EditProduct(_invoiceDatabase, selectedRow, true, true);
            }
            else
            {
                editProductForm = new EditProduct(_invoiceDatabase, selectedRow, true);
            }

            editProductForm.Show();
        }
        catch (InvalidOperationException)
        {

        }
    }

    private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
    {
        WarehouseUtils.DeleteProductWithConfirmation(dataGridView_Invoice, _invoiceDatabase);
    }

    private void ToolStripMenuItem_Print_Click(object sender, EventArgs e)
    {

    }

    private void ToolStripMenuItem_ApllyChanges_Click(object sender, EventArgs e)
    {
        if (checkBox_Inbound.Checked != true & checkBox_Outbound.Checked != true)
        {
            MessageBox.Show("Будь ласка, оберіть тип накладної (прибуткова або видаткова).", "Інфорамація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // Перевірка на те чи достатньо продукту для списання
        if (checkBox_Outbound.Checked == true)
        {
            foreach (Product product in _invoiceDatabase.WarehouseTableData)
            {
                if (_warehouseDatabase.GetProductById(product.Id) == null)
                {
                    MessageBox.Show($"Продукт з ID {product.Id} не знайдено в складі.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int productIndex = _warehouseDatabase.GetProductIndexById(product.Id);
                if (_warehouseDatabase[productIndex].Quantity < product.Quantity)
                {
                    MessageBox.Show($"Недостатньо продукту з ID {product.Id} на складі для видачі.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        foreach (Product InvoiceProduct in _invoiceDatabase.WarehouseTableData)
        {
            Product existingProduct = _warehouseDatabase.GetProductById(InvoiceProduct.Id);

            if (existingProduct == null)
            {
                _warehouseDatabase.AddProduct(InvoiceProduct);
                int productId = _warehouseDatabase.GetProductIndexById(InvoiceProduct.Id);
                Product product = _warehouseDatabase[productId];


                OperationType operationType = OperationType.Added;
                Operation operation = new Operation(operationType, dateTimePicker.Value, _warehouseDatabase[productId].Name, InvoiceProduct.Quantity);
                _warehouseDatabase[productId].AddOperation(dateTimePicker.Value, operation);
            }
            else
            {
                int quantityToChange = checkBox_Inbound.Checked == true ? InvoiceProduct.Quantity : InvoiceProduct.Quantity * -1;
                int productIndex = _warehouseDatabase.GetProductIndexById(InvoiceProduct.Id);

                var data = _warehouseDatabase.WarehouseTableData;

                _warehouseDatabase[productIndex].Quantity += quantityToChange;
                _warehouseDatabase[productIndex].UpdateTotalPrice();

                // Додавання операції до історії
                OperationType operationType = checkBox_Inbound.Checked ? OperationType.Inbound : OperationType.Outbound;
                Operation operation = new Operation(operationType, dateTimePicker.Value, _warehouseDatabase[productIndex].Name, InvoiceProduct.Quantity);
                _warehouseDatabase[productIndex].AddOperation(dateTimePicker.Value, operation);


                if (checkBox_Inbound.Checked == true & _warehouseDatabase[productIndex].LastDeliveryDate < dateTimePicker.Value)
                {
                    _warehouseDatabase[productIndex].LastDeliveryDate = dateTimePicker.Value;
                }
            }
        }

        _warehouseDatabase.AutoIncrementId = _invoiceDatabase.AutoIncrementId;
        
        DatabaseManager.SaveData( _warehouseDatabase );

        MessageBox.Show("Операція успішна", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }

    private void dataGridView_Invoice_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            WarehouseUtils.DeleteProductWithConfirmation(dataGridView_Invoice, _invoiceDatabase);
        }
    }
}
