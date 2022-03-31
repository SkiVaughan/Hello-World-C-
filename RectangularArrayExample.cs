using System;

namespace RectangularArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArr = new int[5, 3];

            myArr[4, 2] = 77;
            myArr[2, 1] = 66;

            for(int row = 0; row < myArr.GetLength(0); row++)//outer for loop going through the rows
            {
                for(int col = 0; col < myArr.GetLength(1); col++)
                {

                    Console.Write($" {row},{col} =" + myArr[row, col] + "\t"); // row=0, col=1

                }

                Console.WriteLine();
            }
            Console.WriteLine("\n\n\nUsing a foreach to print the values of the rectangular array");

            foreach(int elem in myArr)
            {
                Console.WriteLine(elem);


            }

        }
    }
}
