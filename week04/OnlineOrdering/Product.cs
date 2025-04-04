// LN - The class gets the product name, product ID, price per unit, and quantity of the product.
// LN - The class uses encapsulation to hide the data members of the class.
public class Product
{

    //LN - The private access modifier is used to restrict access to the data members of the class.
    private string _name;
    private string _productId;
    private decimal _pricePerUnit;
    private int _quantity;

    //LN - The constructor is used to initialize the data members of the class.
    //LN - The constructor takes four parameters: name, productId, pricePerUnit, and quantity.
    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    //LN - The public method GetTotalCost() calculates the total cost of the product.
    //LN - The method multiplies the price per unit by the quantity and returns the result as a decimal.
    public decimal GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    //LN - The public method GetName() returns the name of the product.
    //LN - The method returns the name of the product as a string.
    public string GetName()
    {
        return _name;
    }

    //LN - The public method GetProductId() returns the product ID of the product.
    //LN - The method returns the product ID of the product as a string.
    public string GetProductId()
    {
        return _productId;
    }
}