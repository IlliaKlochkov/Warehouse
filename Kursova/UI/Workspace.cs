using System.ComponentModel;
using System.Windows.Forms;
using Warehouse.DatabaseRepo;
using Warehouse.Models;


namespace Warehouse.UI;

public partial class Workspace : Form
{
    private Database _database;
    private string _lastSortedColumn = "";
    private SortOrder _lastSortOrder = SortOrder.None;

    public Workspace(Database database)
    {
        InitializeComponent();

        _database = database;

        dataGridView_products.AutoGenerateColumns = false;
        updateDataGridView();

    }

    public void updateDataGridView()
    {
        var currentSortColumn = _lastSortedColumn;
        var currentSortOrder = _lastSortOrder;

        dataGridView_products.DataSource = null;
        dataGridView_products.DataSource = _database.WarehouseTableView;

        // Відновлює іконку сортування
        if (!string.IsNullOrEmpty(currentSortColumn) && currentSortOrder != SortOrder.None)
        {
            foreach (DataGridViewColumn column in dataGridView_products.Columns)
            {
                if (column.Name == currentSortColumn)
                {
                    column.HeaderCell.SortGlyphDirection = currentSortOrder;
                    break;
                }
            }
        }
    }

    private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        string sortParametr = dataGridView_products.Columns[e.ColumnIndex].Name;

        if (_lastSortedColumn == sortParametr)
        {
            _lastSortOrder = _lastSortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
        }
        else
        {
            _lastSortOrder = SortOrder.Ascending;
            _lastSortedColumn = sortParametr;
        }

        foreach (DataGridViewColumn column in dataGridView_products.Columns)
        {
            column.HeaderCell.SortGlyphDirection = SortOrder.None;
        }

        dataGridView_products.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = _lastSortOrder;

        _database.SortByParametr(sortParametr, _lastSortOrder);

        updateDataGridView();
    }


    private void DeleteProductWithConfirmation()
    {
        if (dataGridView_products.SelectedRows.Count <= 0)
        {
            MessageBox.Show("Виберіть рядок для видалення", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmation = MessageBox.Show("Ви впевнені у своєму виборі?", "Підтвердження", MessageBoxButtons.YesNo);

        if (confirmation == DialogResult.No)
        {
            return;
        }

        if (confirmation == DialogResult.Yes)
        {
            var selectedRow = dataGridView_products.SelectedRows[0];
            var selectedProduct = (Product)selectedRow.DataBoundItem;
            _database.RemoveProduct(selectedProduct);
            updateDataGridView();
        }
    }



    //  Кнопки з меню
    private void toolStripMenuItem_addProduct_Click(object sender, EventArgs e)
    {
        AddProduct addProductForm = new AddProduct(_database);
        addProductForm.ProductAdded += (s, args) =>
        {
            updateDataGridView();
        };
        addProductForm.Show();
    }


    private void ToolStripMenuItem_removeProduct_Click(object sender, EventArgs e)
    {
        DeleteProductWithConfirmation();
    }


    private void пршукToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void ToolStripMenuItem_editProduct_Click(object sender, EventArgs e)
    {
        DataGridViewRow selectedRow = dataGridView_products.SelectedRows[0];
        EditProduct addProductForm = new EditProduct(_database, selectedRow);
        addProductForm.ProductEdited += (s, args) =>
        {
            updateDataGridView();
        };
        addProductForm.Show();
    }

    private void dataGridView_products_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            DeleteProductWithConfirmation();
        }
    }

    private void ToolStripMenuItem_editQuantity_Click(object sender, EventArgs e)
    {
        DataGridViewRow selectedRow = dataGridView_products.SelectedRows[0];
        EditingQuantity addProductForm = new EditingQuantity(_database, selectedRow);
        addProductForm.QuantityEdited += (s, args) =>
        {
            updateDataGridView();
        };
        addProductForm.Show();
    }
}
