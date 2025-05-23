using Warehouse.Models;
using System.ComponentModel;

namespace Warehouse.DatabaseRepo;

public class Database
{
    public List<Product> WarehouseTableData { get; set; }
    public BindingList<Product> WarehouseTableView { get; private set; }
    public int AutoIncrementId { get; set; }


    public Database(int AutoIncrementId = 0)
    {
        this.AutoIncrementId = AutoIncrementId;
        WarehouseTableData = new List<Product>();
        WarehouseTableView = new BindingList<Product>(WarehouseTableData);
    }

    public void RestoreBindingList()
    {
        if (WarehouseTableData == null)
            WarehouseTableData = new List<Product>();

        WarehouseTableView = new BindingList<Product>(WarehouseTableData);
    }

    public int GetNextProductId()
    {
        AutoIncrementId++;
        return AutoIncrementId;
    }

    public int GetProductIndexById(int id)
    {
        return WarehouseTableData.FindIndex(x => x.Id == id);
    }

    public bool IsValidIndex(int index)
    {
        return index >= 0 && index < WarehouseTableData.Count;
    }

    public void AddProduct(Product product)
    {
        WarehouseTableData.Add(product);
        WarehouseTableView = new BindingList<Product>(WarehouseTableData);
    }

    public void RemoveProduct(Product product)
    {
        WarehouseTableData.Remove(product);
        WarehouseTableView = new BindingList<Product>(WarehouseTableData);
    }

    public void EditProduct(int id, string name, string measureUnit, int pricePerUnit)
    {
        int productIndex = GetProductIndexById(id);

        WarehouseTableData[productIndex].Name = name;
        WarehouseTableData[productIndex].MeasureUnit = measureUnit;
        WarehouseTableData[productIndex].PricePerUnit = pricePerUnit;
        WarehouseTableData[productIndex].TotalPrice = WarehouseTableData[productIndex].Quantity * pricePerUnit;

        WarehouseTableView = new BindingList<Product>(WarehouseTableData);
    }

    public void EditQuantity(int id, int quantity)
    {
        int productIndex = GetProductIndexById(id);

        int temp = WarehouseTableData[productIndex].Quantity;
        WarehouseTableData[productIndex].Quantity = temp + quantity;

        WarehouseTableView = new BindingList<Product>(WarehouseTableData);
    }

    public void SortByParametr(string parametr, SortOrder sortOrder = SortOrder.Ascending)
    {
        List<Product> sortedList;

        switch (parametr)
        {
            case "Id":
                sortedList = sortOrder == SortOrder.Ascending
                    ? WarehouseTableView.OrderBy(p => p.Id).ToList()
                    : WarehouseTableView.OrderByDescending(p => p.Id).ToList();
                break;
            case "ProductName":
                sortedList = sortOrder == SortOrder.Ascending
                    ? WarehouseTableView.OrderBy(p => p.Name).ToList()
                    : WarehouseTableView.OrderByDescending(p => p.Name).ToList();
                break;
            case "MeasureUnit": 
                sortedList = sortOrder == SortOrder.Ascending
                    ? WarehouseTableView.OrderBy(p => p.MeasureUnit).ToList()
                    : WarehouseTableView.OrderByDescending(p => p.MeasureUnit).ToList();
                break;
            case "PricePerUnit":
                sortedList = sortOrder == SortOrder.Ascending
                    ? WarehouseTableView.OrderBy(p => p.PricePerUnit).ToList()
                    : WarehouseTableView.OrderByDescending(p => p.PricePerUnit).ToList();
                break;
            case "Quantity":
                sortedList = sortOrder == SortOrder.Ascending
                    ? WarehouseTableView.OrderBy(p => p.Quantity).ToList()
                    : WarehouseTableView.OrderByDescending(p => p.Quantity).ToList();
                break;
            case "LastDeliveryDate":
                sortedList = sortOrder == SortOrder.Ascending
                    ? WarehouseTableView.OrderBy(p => p.LastDeliveryDate).ToList()
                    : WarehouseTableView.OrderByDescending(p => p.LastDeliveryDate).ToList();
                break;
            case "TotalPrice":
                sortedList = sortOrder == SortOrder.Ascending
                    ? WarehouseTableView.OrderBy(p => p.TotalPrice).ToList()
                    : WarehouseTableView.OrderByDescending(p => p.TotalPrice).ToList();
                break;
            default:
                return;
        }

        WarehouseTableView = new BindingList<Product>(sortedList);
    }
}