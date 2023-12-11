public class Product
{
    private string _name;
    private double _price;
    private int _quantity;
    private int _productId;

    public Product(int productId, string product)
    {
        _productId = productId;
        string[] part = product.Split(",");
        _name = part[0];
        _price =  Convert.ToDouble(part[1]) * int.Parse(part[2]);
        _quantity = int.Parse(part[2]);
    }

    public string DisplayNameAndProductID()
    {
        return $"""
        Product ID: {_productId}
        Product: {_name}
        Price: ${_price.ToString("N2")} (each costs ${(_price/_quantity).ToString("N2")})
        Quantity: {_quantity}

        """;
    }
    public double TotalPrice()
    {
        return _price;
    }
}