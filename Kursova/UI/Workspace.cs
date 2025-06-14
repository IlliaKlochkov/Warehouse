using System.Drawing.Printing;
using System.Windows.Forms;
using Warehouse.DatabaseRepo;

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

    private void dataGridView_products_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            WarehouseUtils.DeleteProductWithConfirmation(dataGridView_products, _database);
        }
    }


    // Кнопки з панелі інструментів
    private void ToolStripMenuItem_SearchByName_Click(object sender, EventArgs e)
    {
        string searchPrompt = toolStripTextBox_SearchByName.Text;
        _database.SearchByName(searchPrompt);
    }

    private void ToolStripMenuItem_FilterProduct_Click(object sender, EventArgs e)
    {
        FilterProduct filterForm = new FilterProduct(_database);
        filterForm.Show();
    }

    private void ToolStripMenuItem_Invoice_Click(object sender, EventArgs e)
    {
        InvoiceForm invoiceForm = new InvoiceForm(_database);
        invoiceForm.ShowDialog();

        dataGridView_products.Refresh();
    }

    private void ToolStripMenuItem_editProduct_Click(object sender, EventArgs e)
    {
        try
        {
            WarehouseUtils.ValidateRowSelection(dataGridView_products);
            DataGridViewRow selectedRow = dataGridView_products.SelectedRows[0];
            EditProduct editProductForm = new EditProduct(_database, selectedRow);

            editProductForm.Show();
        }
        catch (InvalidOperationException)
        {

        }
    }

    private void ToolStripMenuItem_removeProduct_Click(object sender, EventArgs e)
    {
        WarehouseUtils.DeleteProductWithConfirmation(dataGridView_products, _database);
    }

    private void ToolStripMenuItem_Details_Click(object sender, EventArgs e)
    {
        WarehouseUtils.ValidateRowSelection(dataGridView_products);
        DataGridViewRow selectedRow = dataGridView_products.SelectedRows[0];
        DetailsForm detailsForm = new DetailsForm(selectedRow, _database);

        detailsForm.Show();
    }
    private void ToolStripMenuItem_Print_Click(object sender, EventArgs e)
    {
        PrintDocument printDoc = new PrintDocument();
        printDoc.PrintPage += (s, ev) =>
        {
            using Font font = new Font("Times New Roman", 14);
            ev.Graphics.DrawString(
                WarehouseUtils.WarehouseProductsToString(_database), 
                font,
                Brushes.Black,
                new RectangleF(50, 50, ev.PageBounds.Width - 100, ev.PageBounds.Height - 100)
                );
        };

        using PrintDialog printDialog = new PrintDialog
        {
            Document = printDoc
        };
        if (printDialog.ShowDialog() == DialogResult.OK)
        {
            printDoc.Print();
        }
    }


    // Обробники подій для кнопок панелі інструментів
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


    //Кнопки з горизонтального меню
    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var file = new OpenFileDialog
        {
            Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*"
        };

        if (file.ShowDialog() == DialogResult.OK)
        {
            string filepath = file.FileName;
            var database = DatabaseManager.LoadDataFromFile(filepath);

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

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        if (_database != null)
        {
            _database.SortChanged -= OnSortChanged;
        }
        base.OnFormClosed(e);
    }


}
