using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // The first order
        List<string> firstOrder = new List<string>{"Galaxy S Tablet, 899.99, 5", "Galaxy Z Flip Phone, 1599.99, 2"};
        Order orderOne = new Order(firstOrder,"James Richardson", "812 Silver Spear Drive", "Annandale", "Virginia", "22003", "US");
        orderOne.TotalPrice();

        // The second order;
        List<string> secondOrder = new List<string>{"Mac Book Pro, 1299.56, 3", "iPhone 15, 890.78, 1", "Apple Watch 10, 345.99, 3"};
        Order orderTwo = new Order(secondOrder,"John Adams", "1762 Edsel Road", "Delfrigs", "Midlothian", "EH12 5DS", "United Kingdom");
        orderTwo.TotalPrice();
    }
}