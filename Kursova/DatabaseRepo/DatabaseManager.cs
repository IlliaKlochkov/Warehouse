﻿using System.Text.Encodings.Web;
using System.Text.Json;
namespace Warehouse.DatabaseRepo;

class DatabaseManager // Клас для збереження та завантаження з файлу даних бази
{
    private const string filePath = "warehouseDatabase.json";

    public static void SaveData(Database database)
    {
        var json = JsonSerializer.Serialize(database, new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        });

        File.WriteAllText(filePath, json);
    }

    public static Database? LoadDataFromFile(string filepath = filePath)
    {
        if (!File.Exists(filepath))
            return null;

        try
        {
            var json = File.ReadAllText(filepath);
            Database loadedDatabase = JsonSerializer.Deserialize<Database>(json) ?? new Database();

            loadedDatabase.RestoreBindingList();
            return loadedDatabase;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Не вдалося завантажити файл: " + ex.Message);
            return null;
        }
    }
}
