class Product
{
    private string _productName = "";
    private string _productID = "";
    private double _pricePerUnit = 0;
    private int _quantity = 0;

    public Product(string productName, string productID, double pricerPerUnit, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _pricePerUnit = pricerPerUnit;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public double GetPricerPerUnit()
    {
        return _pricePerUnit;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}