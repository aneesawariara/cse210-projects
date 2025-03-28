using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;

        foreach(Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label: ";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductName()} ID: {product.GetProductId()}";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label: ";
        shippingLabel += $"{_customer.GetName()}\n ";
        shippingLabel += $"{_customer.GetAddress().GetFullAddress()}";

        return shippingLabel;
    }
}