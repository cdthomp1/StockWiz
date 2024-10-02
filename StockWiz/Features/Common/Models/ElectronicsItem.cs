namespace StockWiz.Features.Common.Models;

public class ElectronicItem : Item
{
    public string Brand { get; set; }
    public int WarrantyPeriod { get; set; } // In months
}
