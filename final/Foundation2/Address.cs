public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _zipcode;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string zipcode, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _zipcode = zipcode;
        _country = country;
    }
    public string GetAddress()
    {
        return $"""
        Adress: {_street},
                {_city}, {_stateOrProvince} {_zipcode}, {_country}
        """;
    }

    public bool InCountry()
    {
        if (_country == "USA" || _country == "US")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}