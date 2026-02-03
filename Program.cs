using StockControl;
using StockControl.Models;
public class Program
{
    static void Main(string[] args)
    {
        Produto testeProduto = new Produto
        {
            NameProduct = "Teclado",
            PrecoProduct = 1500
        };
        
        testeProduto.DisplaySummary();
    }
}
