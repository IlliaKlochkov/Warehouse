using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models;

public class ProductViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string MeasureUnit { get; set; }
    public double PricePerUnit { get; set; }
    public double Quantity { get; set; }
    public DateTime LastDeliveryDate { get; set; }
    public double TotalPrice { get; set; }
}
