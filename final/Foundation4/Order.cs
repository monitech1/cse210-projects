using System;
public class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = products.Sum(product => product.Price * product.Quantity);
        if (customer.IsInUSA())
        {
            total += 5.0m; // USA shipping cost
        }
        else
        {
            total += 35.0m; // International shipping cost
        }
        return total;
    }

    public string GetPackingLabel()
    {
        // Construct packing label string
        string packingLabel = $"Packing Label for Order\n\nCustomer: {customer.Name}\n";
        foreach (var product in products)
        {
            packingLabel += $"{product.Name} (ID: {product.Id})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        // Construct shipping label string
        string shippingLabel = $"Shipping Label for Order\n\nCustomer: {customer.Name}\n";
        shippingLabel += customer.GetFullAddress();
        return shippingLabel;
    }
}
