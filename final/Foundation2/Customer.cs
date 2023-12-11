public class Customer
{
    private string _name;
    private bool _inCountry;

    public Customer(string name, string street, string city, string stateOrProvince, string zipcode, string country)
    {
        _name = name;

        NameAndAddress(street, city, stateOrProvince, zipcode, country);
    }

    private bool SetInsideCountry(bool result)
    {
        _inCountry = result;
        return _inCountry;
    }
    public bool GetInCountry()
    {
        return _inCountry;
    }
    private void NameAndAddress(string street, string city, string stateOrProvince, string zipcode, string country)
    {
        Address address = new Address(street, city, stateOrProvince, zipcode, country);
        bool insideCountryResult = address.InCountry();
        SetInsideCountry(insideCountryResult);

        Console.WriteLine($"Name: {_name}");
        string theAddress = address.GetAddress();
        Console.WriteLine(theAddress);
        Console.WriteLine();
    }
}
