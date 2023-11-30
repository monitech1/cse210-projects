public class Product
{
    public string Name { get; }
    public int Id { get; }
    public decimal Price { get; }
    public int Quantity { get; }

    public Product(string name, int id, decimal price, int quantity)
    {
        Name = name;
        Id = id;
        Price = price;
        Quantity = quantity;
    }
}
