using System.Collections.Concurrent;
using System.Numerics;

public class address
{
    private string streetName;
    private string city;
    private string state;
    private string country;

    public bool location(string country)
    {
        if (country == "US")
            return true;
        return false;
    }
    
    public string addressTogether(string street, string city, string state, string country)
    {
        string address = $"{street}\n {city}, {state}\n {country}";
        return address;
        
    }
}