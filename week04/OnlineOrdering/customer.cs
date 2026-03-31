public class Customer
{
    private string name;
    private Address addy;

    public Customer(string _name, Address address)
    {
        name = _name;
        addy = address;
    }

    public string GetName()
    {
        return name;
    }
    public Address GetAddress()
    {
        return addy;
    }

    public bool IsInUS()
    {
        return addy.Location();
    }
}