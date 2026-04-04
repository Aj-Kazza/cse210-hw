using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isAmerica;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsAmerica()
    {
        if (_country == "USA")
        {
            _isAmerica = true;
            return _isAmerica;
        }
        else
        {
            _isAmerica = false;
            return _isAmerica;
        }
    }

    public string GetDisplayText()
    {
        return $"{_street}\r\n{_city}\r\n{_state}\r\n{_country}";
    }

}