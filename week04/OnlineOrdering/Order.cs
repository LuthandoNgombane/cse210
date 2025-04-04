// LN - The class gets the order details, including the products, customer information, and shipping costs.
// LN - The class uses encapsulation to hide the data members of the class.
public class Order
{
    //LN - The private access modifier is used to restrict access to the data members of the class.
    //LN - The class contains a list of products, a customer object, and shipping costs for South Africa and international orders.
    private List<Product> _products;
    private Customer _customer;
    private const decimal ShippingCostSA = 5.00m;
    private const decimal ShippingCostInternational = 35.00m;

    //LN - The constructor is used to initialize the data members of the class.
    //LN - The constructor takes a customer object as a parameter.
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    //LN - The public method AddProduct() adds a product to the order.
    //LN - The method takes a product object as a parameter and adds it to the list of products.
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //LN - The public method CalculateTotalCost() calculates the total cost of the order.
    public decimal CalculateTotalCost()
    {
        decimal productTotal = _products.Sum(product => product.GetTotalCost());
        decimal shippingCost = _customer.LivesInSA() ? ShippingCostSA : ShippingCostInternational;
        return productTotal + shippingCost;
    }

    //LN - The public method GetPackingLabel() generates a packing label for the order.
    //LN - The method returns a string containing the packing label with product names and IDs.
    //LN - The method iterates through the list of products and appends their names and IDs to the label.
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    //LN - The public method GetShippingLabel() generates a shipping label for the order.
    //LN - The method returns a string containing the shipping label with customer name and address.
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}