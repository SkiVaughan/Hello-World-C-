using System;
using System.IO;


namespace InvoiceApplication

{
    class InvoiceTest
    {
        
        public static void Main()
        {
            int menuOption;
            int Item = 0;
            Console.WriteLine("Enter your Name:");
            string str = Console.ReadLine();

            Invoice.displayMessage(str);
             string input = Console.ReadLine();


            while (input != null)

            {
                Console.WriteLine("Enter your Item:");
                menuOption = Convert.ToInt32(Console.ReadLine());
                switch (menuOption)
                {
                    case 1:
                        Item = 1;
                        Invoice.AddItem(Item);
                        break;
                    case 2:
                        Item = 2;
                        Invoice.AddItem(Item);
                        break;
                    case 3:
                        Item = 3;
                        Invoice.AddItem(Item);
                        break;
                    case 4:
                        Item = 4;
                        Invoice.AddItem(Item);
                        break;
                    case 5:
                        Item = 5;
                        Invoice.AddItem(Item);
                        break;
                    case 0:
                        done(Invoice.displayTotal);
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }



        }




    }

}
