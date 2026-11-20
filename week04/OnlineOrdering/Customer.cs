/*
 * Name: Brighton Munezi
 * Student ID: 30112119
 * Course: CS210
 * Assignment: W04 Assignment: Online Ordering Program
 * Date: 11/20/2026
 * Description: Brief description
 */

using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}