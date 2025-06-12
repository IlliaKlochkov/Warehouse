using System.ComponentModel;
using System.Text.Json.Serialization;
using Warehouse.Models;

namespace Warehouse.DatabaseRepo;

public class Database
{
    public List<Product> WarehouseTableData { get; set; }
    [JsonIgnore]
    public BindingList<Product> WarehouseTableView { get; private set; }
    public int AutoIncrementId { get; set; }

    public List<Product> _filteredData;
    public bool _isFiltered = false;
    public bool _isOnlyAvailable = false;

    // Додаємо події для повідомлення про зміни сортування
    public event Action<string, SortOrder> SortChanged;

    public Database(int AutoIncrementId = 0)
    {
        this.AutoIncrementId = AutoIncrementId;
        WarehouseTableData = new List<Product>();
        WarehouseTableView = new BindingList<Product>();
        _filteredData = new List<Product>();

        RefreshView();
    }


    public void RestoreBindingList()
    {
        if (WarehouseTableData == null)
            WarehouseTableData = new List<Product>();

        RefreshView();
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

    public Product? GetProductById(int id)
    {
        var index = GetProductIndexById(id);
        if (!IsValidIndex(index))
        {
            return null;
        }

        return this[index];
    }

    public bool IsValidIndex(int index)
    {
        return index >= 0 && index < WarehouseTableData.Count;
    }

    public bool IsUniqueProduct(Product product)
    {
        return !WarehouseTableData.Any(p => p.Id == product.Id ||
                                           p.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase));
    }

    public void AddProduct(Product product)
    {
        WarehouseTableData.Add(product);

        if (_isFiltered)
        {
            RefreshView();
        }
        else
        {
            WarehouseTableView.Add(product);
        }
    }

    public void RemoveProduct(Product product)
    {
        WarehouseTableData.Remove(product);

        if (WarehouseTableView.Contains(product))
        {
            WarehouseTableView.Remove(product);
        }

        if (_isFiltered && _filteredData.Contains(product))
        {
            _filteredData.Remove(product);
        }
    }

    public void EditProduct(int id, string name, string measureUnit, int pricePerUnit, int Quantity)
    {
        int productIndex = GetProductIndexById(id);

        if (!IsValidIndex(productIndex)) return;

        var product = this[productIndex];
        product.Name = name;
        product.MeasureUnit = measureUnit;
        product.PricePerUnit = pricePerUnit;
        product.Quantity = Quantity;
        product.UpdateTotalPrice();

        NotifyItemChanged(product);
    }

    public void EditQuantity(int id, int quantity)
    {
        int productIndex = GetProductIndexById(id);

        if (!IsValidIndex(productIndex)) return;

        var product = this[productIndex];
        product.Quantity += quantity;
        product.LastDeliveryDate = DateTime.Now;

        NotifyItemChanged(product);
    }

    private void NotifyItemChanged(Product product)
    {
        var indexInView = WarehouseTableView.IndexOf(product);
        if (indexInView >= 0)
        {
            WarehouseTableView.ResetItem(indexInView);
        }
    }

    public void ApplyFilter(DateTime? dateFrom, DateTime? dateTo, string measureUnit,
                           string quantityOperator, int? quantityValue,
                           string priceOperator, double? priceValue,
                           string totalPriceOperator, double? totalPriceValue,
                           bool onlyAvailable)
    {
        _filteredData = WarehouseTableData.Where(product =>
        {
            if (dateFrom.HasValue && product.FirstAddedDate < dateFrom.Value)
                return false;
            if (dateTo.HasValue && product.FirstAddedDate > dateTo.Value)
                return false;
            if (!string.IsNullOrEmpty(measureUnit) &&
                !product.MeasureUnit.Contains(measureUnit, StringComparison.OrdinalIgnoreCase))
                return false;
            if (quantityValue.HasValue && !string.IsNullOrEmpty(quantityOperator))
            {
                if (quantityOperator == ">" && product.Quantity <= quantityValue.Value)
                    return false;
                if (quantityOperator == "<" && product.Quantity >= quantityValue.Value)
                    return false;
                if (quantityOperator == "=" && product.Quantity != quantityValue.Value)
                    return false;
            }
            if (priceValue.HasValue && !string.IsNullOrEmpty(priceOperator))
            {
                if (priceOperator == ">" && product.PricePerUnit <= priceValue.Value)
                    return false;
                if (priceOperator == "<" && product.PricePerUnit >= priceValue.Value)
                    return false;
                if (priceOperator == "=" && Math.Abs(product.PricePerUnit - priceValue.Value) > 0)
                    return false;
            }
            if (totalPriceValue.HasValue && !string.IsNullOrEmpty(totalPriceOperator))
            {
                if (totalPriceOperator == ">" && product.TotalPrice <= totalPriceValue.Value)
                    return false;
                if (totalPriceOperator == "<" && product.TotalPrice >= totalPriceValue.Value)
                    return false;
                if (totalPriceOperator == "=" && Math.Abs(product.TotalPrice - totalPriceValue.Value) > 0)
                    return false;
            }
            if (onlyAvailable && product.Quantity <= 0)
                return false;

            return true;
        }).ToList();

        _isFiltered = true;
        _isOnlyAvailable = onlyAvailable;
        RefreshView();
    }

    public void ClearFilter()
    {
        _isFiltered = false;
        _isOnlyAvailable = false;
        _filteredData.Clear();
        RefreshView();
    }

    public void RefreshView()
    {
        var dataToShow = _isFiltered ? _filteredData : WarehouseTableData;

        // RaiseListChangedEvents для більш плавного оновлення
        WarehouseTableView.RaiseListChangedEvents = false;
        WarehouseTableView.Clear();
        foreach (var product in dataToShow)
        {
            WarehouseTableView.Add(product);
        }
        WarehouseTableView.RaiseListChangedEvents = true;
        WarehouseTableView.ResetBindings();
    }

    public void SortByParametr(string parametr, SortOrder sortOrder = SortOrder.Ascending)
    {
        var dataToSort = _isFiltered ? _filteredData : WarehouseTableData;
        List<Product> sortedList;

        switch (parametr)
        {
            case "Id":
                sortedList = sortOrder == SortOrder.Ascending
                    ? dataToSort.OrderBy(p => p.Id).ToList()
                    : dataToSort.OrderByDescending(p => p.Id).ToList();
                break;
            case "ProductName":
                sortedList = sortOrder == SortOrder.Ascending
                    ? dataToSort.OrderBy(p => p.Name).ToList()
                    : dataToSort.OrderByDescending(p => p.Name).ToList();
                break;
            case "MeasureUnit":
                sortedList = sortOrder == SortOrder.Ascending
                    ? dataToSort.OrderBy(p => p.MeasureUnit).ToList()
                    : dataToSort.OrderByDescending(p => p.MeasureUnit).ToList();
                break;
            case "PricePerUnit":
                sortedList = sortOrder == SortOrder.Ascending
                    ? dataToSort.OrderBy(p => p.PricePerUnit).ToList()
                    : dataToSort.OrderByDescending(p => p.PricePerUnit).ToList();
                break;
            case "Quantity":
                sortedList = sortOrder == SortOrder.Ascending
                    ? dataToSort.OrderBy(p => p.Quantity).ToList()
                    : dataToSort.OrderByDescending(p => p.Quantity).ToList();
                break;
            case "LastDeliveryDate":
                sortedList = sortOrder == SortOrder.Ascending
                    ? dataToSort.OrderBy(p => p.LastDeliveryDate).ToList()
                    : dataToSort.OrderByDescending(p => p.LastDeliveryDate).ToList();
                break;
            case "FirstAddedDate":
                sortedList = sortOrder == SortOrder.Ascending
                    ? dataToSort.OrderBy(p => p.FirstAddedDate).ToList()
                    : dataToSort.OrderByDescending(p => p.FirstAddedDate).ToList();
                break;
            case "TotalPrice":
                sortedList = sortOrder == SortOrder.Ascending
                    ? dataToSort.OrderBy(p => p.TotalPrice).ToList()
                    : dataToSort.OrderByDescending(p => p.TotalPrice).ToList();
                break;
            default:
                return;
        }

        // Оновлюємо відповідний список
        if (_isFiltered)
        {
            _filteredData = sortedList;
        }
        else
        {
            WarehouseTableData = sortedList;
        }

        // Використовуємо більш м'яке оновлення замість RefreshView()
        //WarehouseTableView.RaiseListChangedEvents = false;
        WarehouseTableView.Clear();
        foreach (var product in sortedList)
        {
            WarehouseTableView.Add(product);
        }
        //WarehouseTableView.RaiseListChangedEvents = true;
        WarehouseTableView.ResetBindings();


        RefreshView();

        // Повідомляємо про зміну сортування
        SortChanged?.Invoke(parametr, sortOrder);
    }

    public void SearchByName(string name)
    {
        name = name.Trim().ToLower();

        if (string.IsNullOrEmpty(name))
        {
            ClearFilter();
            return;
        }

        _filteredData = WarehouseTableData.Where(p => p.Name.ToLower().Contains(name)).ToList();
        _isFiltered = true;
        RefreshView();
    }

    public Product this[int index]
    {
        get { return WarehouseTableData[index]; }
    }
}