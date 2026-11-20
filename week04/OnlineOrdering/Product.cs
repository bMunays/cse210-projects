/*
 * Name: Brighton Munezi
 * Student ID: 30112119
 * Course: CS210
 * Assignment: W04 Assignment: Online Ordering Program
 * Date: 11/20/2026
 * Description: Brief description
 */

using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingInfo()
    {
        return $"{_name} ID: {_productId}";
    }
}