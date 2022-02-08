using System;


public class Testingnumbers
{


    //Main Method
    public static void Main()
    {
        int num1 = 55;
        int num2 = 4;

        double result = (double)num1 / num2; //55 / 4 results should be 13.75

        Console.WriteLine("The result of the division " + result);

        double changeAmt = 6.89;

        double wholeDollars = (int)changeAmt;

        Console.WriteLine("The whole dollars are " + wholeDollars);

        // Calling the Multipy method from the main method
        decimal resultofMultiply = (Multiply(55.45m, 77.99m));
        //Calls the Multiply method, recieves the result, and prints out the result

        Console.WriteLine("The result of the calling Multiply is: " + resultofMultiply);

        Console.WriteLine($"The result of the calling Multipy is {resultofMultiply:c}");

        //Prompt the user for two values

        Console.Write("Please enter a decimal value: ");
       
        decimal dec1 = Decimal.Parse(Console.ReadLine());
        
        Console.Write("Please enter another decimal value: ");
       
        decimal dec2 = Decimal.Parse(Console.ReadLine());
       
        
        // :c is a format specifier
        //:n is a format specifier
        Console.WriteLine(Multiply(dec1, dec2));

      
    }//End of the Main Method


    public static decimal Multiply(decimal myDecimal1, decimal myDecimal2) //Void means that nothing returns to the calling side
    {
        decimal result = myDecimal1 * myDecimal2;

        return result;

    }


}
