using System;

class Order
{
    private Customer _customer;
    private List<Product> _products = [];
    private Address _address;
    private bool _isAmerica;
    private double _total;
    private double _shipping;

    public Order(Customer customer, Address address)
    {
        _customer = customer;
        _address = address;

        _isAmerica = _address.IsAmerica();
        if (_isAmerica == true)
        {
            _shipping = 5;
        }
        else
        {
            _shipping = 35;
        }
    }

    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            double subtotal = product.GetTotalPrice();
            total = total + subtotal;
        }
        total = total + _shipping;

        _total = total;

        return _total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel = packingLabel + $"{product.GetDisplayText()}\r\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetDisplayText()} \r\n{_address.GetDisplayText()}";
    }
}