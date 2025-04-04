// LN - The class gets the address of the customer and checks if the address is in South Africa (SA).
public class Address
{

    //LN  - Encapsulation is used to hide the data members of the class.
    //LN - The private access modifier is used to restrict access to the data members of the class.
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    //LN - The constructor is used to initialize the data members of the class.
    //LN - The constructor takes four parameters: streetAddress, city, stateProvince, and country.
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    //LN - The public method IsInSA() checks if the country is South Africa (SA).
    //LN - The method returns true if the country is SA, otherwise it returns false.
    public bool IsInSA()
    {
        return _country.Trim().ToLower() == "sa";
    }

    //LN - The public method GetFullAddress() returns the full address as a string.
    //LN - The method concatenates the street address, city, state/province, and country into a single string.
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}