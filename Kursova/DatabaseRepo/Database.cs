using Kursova.Models;
using System.ComponentModel;
using System.Text.Json;

namespace Kursova.DatabaseRepo;

public class Database
{
    private const string FilePath = "products.json";
    public List<Product> WarehouseTableData { get; private set; }
    public BindingList<Product> WarehouseTableView { get; private set; }

    public Database()
    {
        if (File.Exists(FilePath))
        {
            string json = File.ReadAllText(FilePath);
            WarehouseTableData = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }
        else
        {
            //Product testProduct = new Product(1, "test", "м", 10, 10);
            //Product testProduct2 = new Product(2, "test2", "м", 5, 20);
            WarehouseTableData = new List<Product> { };
            WarehouseTableView = new BindingList<Product>(WarehouseTableData);
        }
    }


    public void AddProduct(Product product)
    {
        WarehouseTableData.Add(product);
        WarehouseTableView = new BindingList<Product>(WarehouseTableData);
    }
    public void SortByParametr(string parametr)
    {
        List<Product> sortedList;
        switch (parametr)
        {
            case "Name":
                sortedList = WarehouseTableData.OrderBy(p => p.Name).ToList();
                break;
            case "PricePerUnit":
                sortedList = WarehouseTableData.OrderBy(p => p.PricePerUnit).ToList();
                break;
            case "Quantity":
                sortedList = WarehouseTableData.OrderBy(p => p.Quantity).ToList();
                break;
            case "LastDeliveryDate":
                sortedList = WarehouseTableData.OrderBy(p => p.LastDeliveryDate).ToList();
                break;
            default:
                return; 
        }

        WarehouseTableData = sortedList;
        WarehouseTableView = new BindingList<Product>(WarehouseTableData);
    }


    public void Save()
    {
        string json = JsonSerializer.Serialize(WarehouseTableData, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }
}
