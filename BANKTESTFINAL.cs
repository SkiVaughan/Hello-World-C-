using System;

//Assignment: Assignment 5 - BankingApplication

public class BankTest
{

    public static void Main()
    {

        Bank myBank = new Bank();
        //call to Bank constructor to create myBank object

        //create 10 accounts and add them to myBank, displays true if the account was added
        Account acc1 = new Account("1", "Bugs Bunny", new decimal[,] { { 1m, 2.3m }, {102.10m, 145.10m }, { 15m, 48.6m } });



        Console.WriteLine(myBank.AddAccount(acc1));

        Account acc2 = new Account("2", "Daffy Duck", new decimal[,] { { 500m, 100.3m, 620.3m }, { 15.99m, 150.78m, 142.30m }, { 10m, 45.3m, 54m } });

        Console.WriteLine(myBank.AddAccount(acc2));

        Account acc3 = new Account("3", "Porky Pig", new decimal[,] { { 1000m, 5m}, { 87.36m, 152.70m }, { 14m, 48.3m } });

        Console.WriteLine(myBank.AddAccount(acc3));

        Account acc4 = new Account("4", "Yosemite Sam", new decimal[,] { { 458m, 149.25m, 14m, 56.2m }, { 142m, 475m, 98.36m, 4.25m }, { 48.26m, 1245.3m, 100m, 985m } });

        Console.WriteLine(myBank.AddAccount(acc4));

        Account acc5 = new Account("5", "Speedy Gonzales", new decimal[,] { { 5.25m }, { 10m }, { 20.56m} });

        Console.WriteLine(myBank.AddAccount(acc5));

        Account acc6 = new Account("6", "Tasmanian Devil", new decimal[,] { { 10.58m, 100.3m }, { 1.25m, 15.63m }, { 482m, 145.3m} });

        Console.WriteLine(myBank.AddAccount(acc6));

        Account acc7 = new Account("7", "Pepe Le Pew", new decimal[,] { { 1000.25m , 1.37m }, { 700m, 5.89m}, {782.69m, 256m } });

        Console.WriteLine(myBank.AddAccount(acc7));

        Account acc8 = new Account("8", "Road Runner", new decimal[,] { { 148.36m, 14.2m, 4m}, { 1893.25m, 157.31m, 5.89m }, {1458m, 56m, 2.65m } });

        Console.WriteLine(myBank.AddAccount(acc8));

        Account acc9 = new Account("9", "Sylvester", new decimal[,] { { 7420.36m, 256m, 55m, 14.99m }, { 215m, 2156.2m, 448.1m, 25m }, { 482.3m, 14m, 562m, 1.05m } });

        Console.WriteLine(myBank.AddAccount(acc9));

        Account acc10 = new Account("10", "Wile E. Coyote", new decimal[,] { { 15m, 47m }, { 48.2m, 160m }, { 148m, 369.89m } });

        Console.WriteLine(myBank.AddAccount(acc10));

        Account acc11 = new Account("11", "Tweety Bird", new decimal[,] { { 15m, 47m }, { 48.2m, 160m }, { 148m, 369.89m } });

        Console.WriteLine(myBank.AddAccount(acc10));

        //calls the ApplyDeposits method to apply deposits for each account
        myBank.ApplyDeposits();

        //displays myBank object
        Console.WriteLine(myBank);
    }
}
