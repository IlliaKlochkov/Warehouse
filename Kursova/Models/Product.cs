namespace Warehouse.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string MeasureUnit { get; set; }
    public double PricePerUnit { get; set; }
    public int Quantity { get; set; }
    public DateTime LastDeliveryDate { get; set; }
    public double TotalPrice { get; set; }

    public Product(int Id, string Name, string MeasureUnit, double PricePerUnit, int Quantity, DateTime LastDeliveryDate)
    {
        this.Id = Id;
        this.Name = Name;
        this.MeasureUnit = MeasureUnit;
        this.PricePerUnit = PricePerUnit;
        this.Quantity = Quantity;
        this.LastDeliveryDate = LastDeliveryDate;
        this.TotalPrice = Quantity * PricePerUnit;
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

