using System.ComponentModel;
using System.Windows.Forms;
using Warehouse.DatabaseRepo;
using Warehouse.Models;

namespace Warehouse.UI;

public partial class Workspace : Form
{
    private DatabaseManager _databaseManager = new DatabaseManager();
    private Database _database;

    private string _lastSortedColumn = "";
    private SortOrder _lastSortOrder = SortOrder.None;

    public Workspace(Database database)
    {
        InitializeComponent();

        _database = database;

        _database.SortChanged += OnSortChanged;

        dataGridView_products.AutoGenerateColumns = false;
        dataGridView_products.DataSource = _database.WarehouseTableView;
    }

    private void OnSortChanged(string columnName, SortOrder sortOrder)
    {
        _lastSortedColumn = columnName;
        _lastSortOrder = sortOrder;

        UpdateSortGlyphs();
    }

    private void UpdateSortGlyphs()
    {
        foreach (DataGridViewColumn column in dataGridView_products.Columns)
        {
            column.HeaderCell.SortGlyphDirection = SortOrder.None;
        }


        if (!string.IsNullOrEmpty(_lastSortedColumn) && _lastSortOrder != SortOrder.None)
        {
            foreach (DataGridViewColumn column in dataGridView_products.Columns)
            {
                if (column.Name == _lastSortedColumn)
                {
                    column.HeaderCell.SortGlyphDirection = _lastSortOrder;
                    break;
                }
            }
        }
    }

    public void UpdateDataGridView()
    {
        if (dataGridView_products.DataSource != _database.WarehouseTableView)
        {
            dataGridView_products.DataSource = _database.WarehouseTableView;
        }

        UpdateSortGlyphs();
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
    }

    private void ValidateRowSelection()
    {
        if (dataGridView_products.SelectedRows.Count <= 0)
        {
            MessageBox.Show("Виберіть рядок для редагування", "Попередження",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            throw new InvalidOperationException("Не вибрано рядок");
        }
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

        }
    }

    private void dataGridView_products_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            DeleteProductWithConfirmation();
        }
    }

    // Кнопки з меню
    private void toolStripMenuItem_addProduct_Click(object sender, EventArgs e)
    {
        AddProduct addProductForm = new AddProduct(_database);
        addProductForm.Show();
    }

    private void ToolStripMenuItem_removeProduct_Click(object sender, EventArgs e)
    {
        DeleteProductWithConfirmation();
    }

    private void ToolStripMenuItem_editProduct_Click(object sender, EventArgs e)
    {
        try
        {
            ValidateRowSelection();
            DataGridViewRow selectedRow = dataGridView_products.SelectedRows[0];
            EditProduct editProductForm = new EditProduct(_database, selectedRow);

            editProductForm.Show();
        }
        catch (InvalidOperationException)
        {

        }
    }

    private void ToolStripMenuItem_editQuantity_Click(object sender, EventArgs e)
    {
        try
        {
            ValidateRowSelection();
            DataGridViewRow selectedRow = dataGridView_products.SelectedRows[0];
            EditingQuantity editQuantityForm = new EditingQuantity(_database, selectedRow);
            editQuantityForm.Show();
        }
        catch (InvalidOperationException)
        {

        }
    }

    private void ToolStripMenuItem_FilterProduct_Click(object sender, EventArgs e)
    {
        FilterProduct filterForm = new FilterProduct(_database);
        filterForm.Show();
    }

    private void ToolStripMenuItem_SearchByName_Click(object sender, EventArgs e)
    {
        string searchPrompt = toolStripTextBox_SearchByName.Text;
        _database.SearchByName(searchPrompt);
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var file = new OpenFileDialog
        {
            Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*"
        };

        if (file.ShowDialog() == DialogResult.OK)
        {
            string filepath = file.FileName;
            var database = _databaseManager.LoadDataFromFile(filepath);

            if (database == null)
            {
                MessageBox.Show($"Виникла помилка при загрузці проекту \n {_database}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Відписуємося від попередньої бази даних
            _database.SortChanged -= OnSortChanged;

            _database = database;

            // Підписуємося на нову базу даних
            _database.SortChanged += OnSortChanged;

            // Скидаємо інформацію про сортування
            _lastSortedColumn = "";
            _lastSortOrder = SortOrder.None;

            UpdateDataGridView();
        }
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // Відписуємося від попередньої бази даних
        _database.SortChanged -= OnSortChanged;

        _database = new Database();

        // Підписуємося на нову базу даних
        _database.SortChanged += OnSortChanged;

        // Скидаємо інформацію про сортування
        _lastSortedColumn = "";
        _lastSortOrder = SortOrder.None;

        UpdateDataGridView();
    }

    private void toolStripTextBox_SearchByName_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string searchPrompt = toolStripTextBox_SearchByName.Text;
            _database.SearchByName(searchPrompt);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        // Відписуємося від подій при закритті форми
        if (_database != null)
        {
            _database.SortChanged -= OnSortChanged;
        }
        base.OnFormClosed(e);
    }

    private void toolStripMenuItem3_Click(object sender, EventArgs e)
    {

    }
}
