public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zipcode;

    public Address(List<string> AddressList)
    {
        _street = AddressList[0];
        _city = AddressList[1];
        _state = AddressList[2];
        _zipcode = int.Parse(AddressList[3]);
    }

    public string DisplayAddress()
    {
        return $"""
        {_street},
        {_city}, {_state}, {_zipcode}
        """;
    }
}