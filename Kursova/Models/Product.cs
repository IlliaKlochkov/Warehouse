namespace Warehouse.Models;

public class Product // Базовий клас для товару на складі
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string MeasureUnit { get; set; }
    public double PricePerUnit { get; set; }
    public int Quantity { get; set; }
    public DateTime FirstAddedDate { get; set; }
    public DateTime LastDeliveryDate { get; set; }
    public double TotalPrice { get; set; }
    public Dictionary<DateTime, List<Operation>> Operations { get; set; }

    public Product(int Id, string Name, string MeasureUnit, double PricePerUnit,
        int Quantity, DateTime FirstAddedDate, DateTime LastDeliveryDate, double TotalPrice = -1, Dictionary<DateTime, List<Operation>>? Operations = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.MeasureUnit = MeasureUnit;
        this.PricePerUnit = PricePerUnit;
        this.Quantity = Quantity;
        this.LastDeliveryDate = LastDeliveryDate;
        this.FirstAddedDate = FirstAddedDate;
        if (TotalPrice == -1)
            this.TotalPrice = Quantity * PricePerUnit;
        else
            this.TotalPrice = TotalPrice;

        this.Operations = Operations ?? new Dictionary<DateTime, List<Operation>>();
    }


    public void UpdateTotalPrice()
    {
        TotalPrice = Math.Round(Quantity * PricePerUnit, 2);
    }

    public void UpdateInvoiceProduct(bool inbound, int quantityCanged, DateTime lastDeliveryDate)
    {
        quantityCanged = inbound ? quantityCanged : -quantityCanged;

        Quantity += quantityCanged;
        LastDeliveryDate = lastDeliveryDate;

        UpdateTotalPrice();
    }

    public void AddOperation(DateTime date, Operation operation)
    {
        var key = date.Date;

        if (!Operations.ContainsKey(key))
        {
            Operations[key] = new List<Operation>();
        }

        Operations[key].Add(operation);
    }


    public Product Copy()
    {
        Product productCopy = new Product(Id, Name, MeasureUnit, PricePerUnit, Quantity, FirstAddedDate, LastDeliveryDate, TotalPrice);
        return productCopy;
    }
}

