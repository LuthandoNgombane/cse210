// LN - The class gets the name and address of the customer and checks if the address is in South Africa (SA).
// LN - The class uses encapsulation to hide the data members of the class.
public class Customer
{

    //LN - The private access modifier is used to restrict access to the data members of the class.
    private string _name;
    private Address _address;

    //LN - The constructor is used to initialize the data members of the class.
    //LN - The constructor takes two parameters: name and address.
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //LN - The public method GetName() returns the name of the customer.
    //LN - The method returns the name of the customer as a string.
    public string GetName()
    {
        return _name;
    }

    //LN - The public method GetAddress() returns the address of the customer.
    //LN - The method returns the address of the customer as an Address object.
    public Address GetAddress()
    {
        return _address;
    }

    //LN - The public method LivesInSA() checks if the address is in South Africa (SA).
    //LN - The method returns true if the address is in SA, otherwise it returns false.
    public bool LivesInSA()
    {
        return _address.IsInSA();
    }
}