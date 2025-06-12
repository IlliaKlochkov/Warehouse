using Warehouse.UI;
using Warehouse.DatabaseRepo;
namespace Warehouse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Database _database = DatabaseManager.LoadDataFromFile();

            if (_database == null)
            {
                _database = new Database();
            }
            Application.Run(new Workspace(_database));
        }
    }
}