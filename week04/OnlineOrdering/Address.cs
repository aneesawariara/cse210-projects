public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetStreetAddress()
    {
        return _street;
    }
    public void SetStreetAddress(string value)
    {
        _street = value;
    }

    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string value)
    {
        _city = value;
    }

    public string GetStateOrProvince()
    {
        return _state;
    }
    public void SetStateOrProvince(string value)
    {
        _state = value;
    }

    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string value)
    {
        _country = value;
    }


    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}