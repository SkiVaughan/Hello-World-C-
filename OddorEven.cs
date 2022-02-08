using System;


namespace OddorEven
{
    class OddorEven
    {
        

        public static void Main(string[] args)
        {
            int num1;
            Console.Write("Enter an Integer : ");
            num1 = int.Parse(Console.ReadLine());

            int result = (num1 % 2);
            
            
            if (result == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            if (result > 0)
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
