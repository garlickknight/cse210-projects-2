using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer _customer)
    {
        customer = _customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public float GetTotalCost()
    {
        const float usaShipping = 5f;
        const float internationalShipping = 35f;

        float total = 0f;
        foreach (Product p in products)
        {
            total += p.GetTotalCost();
        }

        total += customer.IsInUS() ? usaShipping : internationalShipping;
        return total;
    }

    public string GetPackingLabel()
    {
        var label = new StringBuilder();

        foreach (Product p in products)
        {
            label.AppendLine($"Item: {p.GetName()}, ID: {p.GetProductId()}");
        }

        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}