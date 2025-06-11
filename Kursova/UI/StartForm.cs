using Warehouse.DatabaseRepo;

namespace Warehouse.UI;

public partial class StartForm : Form
{
    private Database _database = new Database();
    public StartForm()
    {
        InitializeComponent();
    }

    private void StartForm_Shown(object sender, EventArgs e)
    {
        Database? previousProject = DatabaseManager.LoadDataFromFile();
        if (previousProject != null)
        {
            _database = previousProject;
            LoadWorkplace(_database);
        }
    }


    private void LoadWorkplace(Database _database)
    {
        Workspace workspace = new Workspace(_database);
        workspace.FormClosed += (s, e) =>
        {
            DatabaseManager.SaveData(_database);
            this.Close();
        };

        workspace.Show();
        this.Hide();
    }


    private void buttonCreateProject_Click(object sender, EventArgs e)
    {
        LoadWorkplace(_database);
    }

    private void buttonOpenProject_Click(object sender, EventArgs e)
    {
        using var file = new OpenFileDialog
        {
            Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*"
        };


        if (file.ShowDialog() == DialogResult.OK)
        {
            string filepath = file.FileName;
            var _database = DatabaseManager.LoadDataFromFile(filepath);

            if (_database == null)
            {
                MessageBox.Show($"Виникла помилка при загрузці проекту \n {_database}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadWorkplace(_database);
        }
    }
}
