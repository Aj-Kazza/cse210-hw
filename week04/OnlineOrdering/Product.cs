using System;
using System.Runtime.CompilerServices;

class Product
{
    private string _name;
    private string _id;
    private double _price;
    private double _quantity;
    private double _totalPrice;

    public Product(string name, string id, double price, double quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
        _totalPrice = price * quantity;
    }

    public string GetDisplayText()
    {
        double total = Math.Round(_totalPrice,2);
        return $"{_id,-10} {_name,-25}    x{_quantity}   ${total}";
    }

    public double GetTotalPrice()
    {
        return _totalPrice;
    }
}