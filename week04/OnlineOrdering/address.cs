using System.Collections.Concurrent;
using System.Data;
using System.Numerics;

public class Address
{
    private string streetName;
    private string city;
    private string state;
    private string country;

    public Address(string _street, string _city, string _state, string _country)
    {
        streetName = _street;
        city = _city;
        state = _state;
        country = _country;
    }

    public bool Location()
    {
        if (country == "US")
            return true;
        return false;
    }
    
    public string GetFullAddress()
    {
        string address = $"{streetName}\n {city}, {state}\n {country}";
        return address;
        
    }
}