namespace Warehouse.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string MeasureUnit { get; set; }
    public double PricePerUnit { get; set; }
    public int Quantity { get; set; }
    public DateTime FirstAddedDate { get; set; }
    public DateTime LastDeliveryDate { get; set; }
    public double TotalPrice { get; set; }

    public Product(int Id, string Name, string MeasureUnit, double PricePerUnit, int Quantity, DateTime FirstAddedDate, DateTime LastDeliveryDate, double TotalPrice = -1)
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
    }



    public void UpdateQuantity(int amount)
    {
        if (Quantity + amount < 0)
        {
            throw new InvalidOperationException("Недостатня кількість товару на складі.");
        }
        Quantity += amount;
    }

    public void UpdateLastDeliveryDate(DateTime deliveryDate)
    {
        if (deliveryDate > DateTime.Now)
        {
            throw new ArgumentException("Дата не може бути в майбутньому.");
        }
        LastDeliveryDate = deliveryDate;
    }
}

