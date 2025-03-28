public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public string GetName()
    {
        return _customerName;
    }
    public void SetName(string value)
    {
        _customerName = value;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address value)
    {
        _address = value;
    }
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}