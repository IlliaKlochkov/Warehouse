using System.Text.Encodings.Web;
using System.Text.Json;

namespace Kursova.DatabaseRepo;

class DatabaseManager
{
    private const string filePath = "database.json";

    public static void SaveData(Database database)
    {
        var json = JsonSerializer.Serialize(database, new JsonSerializerOptions { 
            WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });

        File.WriteAllText(filePath, json);
    }

    public static Database LoadData()
    {
        if (!File.Exists(filePath))
            return new Database();

        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<Database>(json) ?? new Database();
    }
}
