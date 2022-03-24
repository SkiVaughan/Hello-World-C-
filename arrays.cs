using System;

public class ArrayExample
{

    public static void Main()
    {
        //create an array of integers

        int[] myArr = new int[35]; //array creation expression

        Console.WriteLine("The value at the last index is: " + myArr[19]);


        myArr[0] = 99;

        Console.WriteLine("The value at index 0 is: " + myArr[0]);
        Console.WriteLine("The value at index 0 is: " + myArr[1]);
        Console.WriteLine("The value at index 0 is: " + myArr[2]);
        Console.WriteLine("The value at index 0 is: " + myArr[3]);

        for(int i=0; i < myArr.Length; i++)
        {
            Console.WriteLine($"The value at index {i} is {myArr[i]}");

        }

        for(int i=0; i< myArr.Length; i++)
        {

            myArr[i] = i*5;

        }
        Console.WriteLine("\n\n\nValues in elements after updates");
        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine($"The value at index {i} is {myArr[i]}");

        }
        int total = 0;
        for(int i=0; i<myArr.Length; i++)
        {

            total += myArr[i];

        }
        Console.WriteLine($"The sum of all the elements is {total}");
        Console.WriteLine($"The avg of the all elements is {total / myArr.Length}");

        //creatng an array using an initializer list 
        int[] myArr2 = { 44, 77, 22, 55, 68, 88, 64, 34, -12, };

        decimal[] myArrDec = new decimal[100];

        string[] rainbowcolors = new string[7];

        rainbowcolors[0] = "red";
        rainbowcolors[1] = "orange";
        rainbowcolors[2] = "yellow";
        rainbowcolors[3] = "green";
        rainbowcolors[4] = "blue";
        rainbowcolors[5] = "indigo";
        rainbowcolors[6] = "violet";


        for (int i=0; i< rainbowcolors.Length; i++)
        {
            rainbowcolors[i] = Console.ReadLine();

        }
    }

}
