namespace Kursova.Models;

public class Product
{
    public string Name { get; set; }
    public string MeasureUnit { get; set; }
    public double PricePerUnit { get; set; }
    public double Quantity { get; set; }
    public DateTime LastDeliveryDate { get; set; }
    public double TotalPrice { get; set; }

    public Product(string name, string measureUnit, double pricePerUnit, double quantity, DateTime? lastDeliveryDate)
    {
        Name = name;
        MeasureUnit = measureUnit;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
        LastDeliveryDate = lastDeliveryDate.HasValue ? lastDeliveryDate.Value : DateTime.Now;
        TotalPrice = Quantity * PricePerUnit;
    }


    public void UpdateQuantity(double amount)
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

