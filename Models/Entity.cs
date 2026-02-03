namespace StockControl.Models;

public abstract class Entity
{
    public Guid Id { get; protected set; }
    public DateTime DataCriacao { get; private set; }

    protected Entity()
    {
        Id = Guid.NewGuid();
        DataCriacao = DateTime.Now;
    }

    public virtual void DisplaySummary()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Criado em: {DataCriacao}");
    }
}