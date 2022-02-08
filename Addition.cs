using System;

public class Addition
{

  //Main Method

    public static void Main()
    {
        //We are going to take two number and add them up
        // Lets create some variables
        //Variables have datatype, size, name, and value
        

        // VARIABLE DATA TYPES
        //Integers (byte, short, int, long)
        //Floating-point (float, double, decimal)
        //Char
        //Boolean (True or False)
        //String

        //3 Variables
        // For whole numbers use int

       
        byte sampleVar = 90;
        short sampleShort = 100;
        char mychar = 'A';
        float myfloat = 5.5;
        double myDouble = 6.6;
        string firstName = "Vaughan";

        int num1 = 25; //Declared and initialized the num1 variable
        int num2 = 45; //Declared and initialized the num2 variable
        int sum = num1 + num2;

        // ASSIGNMENT OPERATORS
        // = Makes whatever is on the righthand side of the = equal to whatever is on the left hand side
        // This console code will write this line in the console and then with the concatination of the +sum print that after

        Console.WriteLine("The sum of the 2 numbers is " + sum);


    }

}
