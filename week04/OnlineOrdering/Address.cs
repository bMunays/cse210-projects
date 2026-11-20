/*
 * Name: Brighton Munezi
 * Student ID: 30112119
 * Course: CS210
 * Assignment: W04 Assignment: Online Ordering Program
 * Date: 11/20/2026
 * Description: Brief description
 */

using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        string normalisedCountry = _country.Trim().ToUpper();
        return normalisedCountry == "USA" || normalisedCountry == "UNITED STATES";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}