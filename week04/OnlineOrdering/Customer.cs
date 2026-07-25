using System;

class Customer
{
    private string _name;
    private Address _address;
    private bool _isAmerica;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsAmerican()
    {
        _isAmerica = _address.IsAmerica();
        return _isAmerica;
    }

    public string GetDisplayText()
    {
        return _name;
    }
}