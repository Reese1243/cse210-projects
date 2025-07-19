class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

    public Address(string streeAddress, string city, string state, string country)
    {
        _streetAddress = streeAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public void DisplayFullAddress()
    {
        string fullAddress = _streetAddress + " " + _city + " " + _state + " " + _country;
        Console.WriteLine(fullAddress);
    }

     public string getFullLAddress()
    {
        string fullAddress = _streetAddress + ", " + _city + ", " + _state + ", " + _country;
        return fullAddress;
    }

    public string GetAddress()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }

   
}