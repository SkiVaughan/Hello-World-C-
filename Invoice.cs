using System;
using System.IO;

class Invoice
{
    public double subTotal;
    private static double itemPrice;
    static String invoice = "";
    static String invoiceString;
    static double invTotal = 0;
    static int quantity = 0;
    static bool ordering = true;
    // Method to Display Menu

    public static void displayMessage(String CustomerName)
    {
        Console.WriteLine("Student Name: Vaughan Koscinski");
        Console.WriteLine("Student ID: 800299516");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Welcome " + CustomerName + " to Dave's Online Cofee Shop\n");
        Console.WriteLine("Please Choose From the Following Products by entering the product code. Enter '0' to Exit.\n");
        Console.WriteLine("Product 1 Kona Blend -> $ 14.95");
        Console.WriteLine("Product 2 Cafe Verona -> $ 9.95");
        Console.WriteLine("Product 3 Espresso Roast -> $ 9.90");
        Console.WriteLine("Product 4 French Roast -> $ 10.45");
        Console.WriteLine("Product 5 Organic Shade Grown -> $ 13.45");
        Console.WriteLine("----------------------------------------------------");
    }

    // Method To Add Item To Menu

    public static double AddItem(int Item)
    {
        if (Item == 1)
        {
            itemPrice = 14.95;
            Console.WriteLine("Enter Quantity:");
            quantity = int.Parse(Console.ReadLine());
            invoice = invoice + "Product 1 Kona Blend -> $ " + itemPrice + " * " + quantity + " = " + itemPrice * quantity + "\n";
        }
        if (Item == 2)
        {
            itemPrice = 9.95;
            Console.WriteLine("Enter Quantity:");
            quantity = int.Parse(Console.ReadLine()); 
            invoice = invoice + "Product 2 Cafe Verona -> $ " + itemPrice + " * " + quantity + " = " + itemPrice * quantity + "\n";
        }
        if (Item == 3)
        {
            itemPrice = 9.90;
            Console.WriteLine("Enter Quantity:");
            quantity = int.Parse(Console.ReadLine());
            invoice = invoice + "Product 3 Espresso Roast -> $ " + itemPrice + " * " + quantity + " = " + itemPrice * quantity + "\n";
        }
        if (Item == 4)
        {
            itemPrice = 10.45;
            Console.WriteLine("Enter Quantity:");
            quantity = int.Parse(Console.ReadLine());
            invoice = invoice + "Product 4 French Roast -> $ " + itemPrice + " * " + quantity + " = " + itemPrice * quantity + "\n";
        }
        if (Item == 5)
        {
            itemPrice = 13.45;
            Console.WriteLine("Enter Quantity:");
            quantity = int.Parse(Console.ReadLine());
            invoice = invoice + "Product 5 Organic Shade Grown -> $ " + itemPrice + " * " + quantity + " = " + itemPrice * quantity + "\n";
        }

        displayTotal(itemPrice, quantity);

        return itemPrice;
    }

    // Method To Calculate Total
    public static double displayTotal(double itemPrice, double quant)
    {
        invTotal = invTotal + itemPrice * quant;
        return invTotal;
    }
    public static void DisplayMessage(double totalCost)
    {
        ordering = false;
        Console.WriteLine("Customer Name: " + invoiceString);
        Console.WriteLine("\n" + invoice);
        Console.WriteLine("Total Cost is" + totalCost + "$");
    }
}
