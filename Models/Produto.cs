namespace StockControl.Models;

public class Produto : Entity
{
    public string NameProduct { get; set; }
    public decimal PrecoProduct { get; set; }
    public override void DisplaySummary()
    {
        base.DisplaySummary();
        Console.WriteLine($"Produto: {NameProduct}");
        Console.WriteLine($"Preço: {PrecoProduct:C}");
    }
}