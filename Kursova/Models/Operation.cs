using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models;

public enum OperationType 
{
    Inbound,
    Outbound,
    WritedOff,
    Added
}
public class Operation // Базовий клас операції над продуктом
{
    public OperationType OperationType { get; set; }
    public DateTime DateTime { get; set; }
    public string ProductName { get; set; }
    public int changedQuantity { get; set; }
    public string DisplayName { get; set; }

    public Operation(OperationType OperationType, DateTime DateTime, string ProductName, int changedQuantity)
    {
        this.OperationType = OperationType;
        this.DateTime = DateTime;
        this.ProductName = ProductName;
        this.changedQuantity = changedQuantity;
        DisplayName = $"[{DateTime}] {GetOperationTypeString()} {ProductName} у кількості {changedQuantity}";
    }

    private string GetOperationTypeString()
    {
        return OperationType switch
        {
            OperationType.Added => "Вперше прибуло",
            OperationType.Inbound => "Прибуло",
            OperationType.Outbound => "Видано",
            OperationType.WritedOff => "Списано",
        };
    }
}
