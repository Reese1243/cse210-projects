class Customer
{
    private string _name = "";
    private Address _address;
    private bool _livesInUSA;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        LivesInUSA(_address);
    }


    public string GetName()
    {
        return _name;
    }

    public string GetCustomerAddress()
    {
        string customerAddress = _address.getFullLAddress();
        return customerAddress;
    }

    public void DisplayCustomerAddress()
    {
        _address.DisplayFullAddress();
    }

    // may remove this method later \/
    private void LivesInUSA(Address _address)
    {
        if (_address.GetCountry() != "USA")
        {
            _livesInUSA = false;
        }
        else
        {
            _livesInUSA = true;
        }
    }

    public bool isInUSA()
    {
        return _livesInUSA;
    }
}