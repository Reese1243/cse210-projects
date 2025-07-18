using System.Numerics;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _totalCost = 0;
    private List<string> _packingLabels = new List<string>();
    private string _shippingAddress;


    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
        foreach (Product product in _products)
        {
            string productid = product.GetProductID();
            string productname = product.GetProductName();
            _packingLabels.Add(productname);
            _packingLabels.Add(productid);
        }
        _shippingAddress = customer.GetName() + " " + customer.GetCustomerAddress();
    }

    public void CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            double pricePerUnit = product.GetPricerPerUnit();
            int quantity = product.GetQuantity();
            double TempTotal = pricePerUnit * quantity;
            total += TempTotal;
        }

        if (_customer.isInUSA() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        _totalCost = total;
    }

    public void DisplayShippingAddress()
    {
        Console.WriteLine(_shippingAddress);
    }

    public void DisplayPackingLabels()
    {
        foreach (string label in _packingLabels)
        {
            Console.WriteLine(label);
        }
    }

    public void DispalyTotalCost()
    {
        Console.WriteLine(_totalCost);
    }

}