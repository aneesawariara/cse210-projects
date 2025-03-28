public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        
        if (price >= 0)
        {
            _price = price;
        }
        else
        {
            _price = 0;
        }

        if (quantity >= 0)
        {
            _quantity = quantity;
        }
        else
        {
            _quantity = 0;
        }

    }

    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName(string value)
    {
        _productName = value;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public void SetProductId(string value)
    {
        _productId = value;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double value)
    {
       if (value >= 0)
       {
            _price = value;
       }
       else
       {
            _price = 0;
       }
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int value)
    {
        if (value >= 0)
        {
            _quantity = value;
        }
        else
        {
            _quantity = 0;
        }
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}