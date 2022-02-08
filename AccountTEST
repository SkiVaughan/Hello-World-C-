using System;


public class AccountTest
{
    public static void Main()
    {
        //This statement creates a new acct and assigns this acct to the
        //variable called myAcct

        //prompt user for the initial values of the new object

        Console.Write("Please enter the name for the new account: ");

        string aName = Console.ReadLine();

        Console.Write("Please enter the initial balance for the new account: ");

        decimal aBal = decimal.Parse(Console.ReadLine());

        Account myAcct = new Account(aName, aBal);

        Console.WriteLine("The initial name in newly created account is : " + myAcct.Name);

        // myAcct.SetName("Vaughan Koscinski");

        //Console.WriteLine("The initial name in newly created account after it has been set is: " + myAcct.GetName());
        Account myAcct8 = new Account(aName, aBal); 

        //BALANCE BUILDING

        Console.WriteLine($"The initial balance of the newly created account is: {myAcct.Balance:c}"  );
        myAcct.Name = "Joe Shmoe";
        myAcct.Balance = 1500.25m;

        Console.WriteLine($"The updated name is: {myAcct.Name}");
        Console.WriteLine($"The updated balance is: {myAcct.Balance:c}");
        

        Console.WriteLine("\n\n\n");

        Console.Write("please enter an amount that you would like to deposit in your acct: $");
        

        decimal amt = Decimal.Parse(Console.ReadLine());

        //objectName.MethodName(values that match the paramaters)

        myAcct.Deposit(amt);
        



        Console.WriteLine($"The new balance after the deposit is: {myAcct.Balance:c}");
        Console.WriteLine($"The account holder name of the second acct is {myAcct8.Name} and the balance is {myAcct8.Balance:c}");
       

        //myAcct.SetBalance(100.52m);

        //Console.WriteLine("The new balance of the account is: " + myAcct.GetBalance());



        Console.Write("Please Enter an amount that you would like to withdrawl: ");
        decimal amtToWD = Decimal.Parse(Console.ReadLine());

        myAcct8.Withdrawl(amtToWD);

        Console.WriteLine($"The new balance after the withdrawl is: {myAcct8.Balance:c}");
        Console.ReadLine();

    }



}
