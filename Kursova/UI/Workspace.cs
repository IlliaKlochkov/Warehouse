using System.ComponentModel;
using Kursova.DatabaseRepo;
using Kursova.Models;


namespace Kursova.UI;

public partial class Workspace : Form
{
    private Database _database;

    public Workspace()
    {
        InitializeComponent();
        _database = new Database();

    }

    // Конструктор для загрузки даних з іншої форми
    public Workspace(string someData)
    {
        InitializeComponent();
        _database = new Database();

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }


    private void MainForm_Load(object sender, EventArgs e)
    {
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.DataSource = _database.WarehouseTableView;
    }

    private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        _database.SortByParametr("Name");
    }

    private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
        AddProduct addProductForm = new AddProduct(_database);
        addProductForm.ProductAdded += (s, args) =>
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _database.WarehouseTableView;
        };
        addProductForm.Show();
    }


    private void fontDialog1_Apply(object sender, EventArgs e)
    {

    }
}
