public class Order
{
    private List<Product> _products;
    private double _shippingCost;

    public Order(List<string> productList, string personName, string street, string city, string stateOrProvince, string zipcode, string country)
    {
        _products = new List<Product>();
        Console.WriteLine("Shipping Label:\n");
        ShippingLabel(personName, street, city, stateOrProvince, zipcode, country);
        Console.WriteLine("Packing Label:\n");
        PackingLabel(productList);
    }
    private void PackingLabel(List<string> productList)
    {
        int productId = 1;
        foreach (string p in productList)
        {
            Product product = new Product(productId,p);
            string result = product.DisplayNameAndProductID();
            Console.WriteLine(result);
            _products.Add(product);
            productId++;
        }
    }
    private void ShippingLabel(string personName, string street, string city, string stateOrProvince, string zipcode, string country)
    {
        Customer customer = new Customer(personName, street, city, stateOrProvince, zipcode, country);
        
        if (customer.GetInCountry() == false)
        {
            _shippingCost = 35;
        }
        else
        {
            _shippingCost = 5;
        }
    }
    public void TotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalPrice();
        }
        total += _shippingCost;
        
        Console.WriteLine($"With a shipping cost of ${_shippingCost},\nThe total for your order comes to ${total}.\n");
        Console.WriteLine("********************************************************************************");
    }
}