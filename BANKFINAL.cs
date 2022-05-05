using System;

//Assignment: Assignment 5 - BankingApplication

public class Bank
{

    //Instance Variables
    private Account[] accountsArray = new Account[10];

    public bool AddAccount(Account acc) //AddAccount method that will add an account to the accountsArray, and display true if it was successful
    {
        bool accAdded = false;
        //local bool variable which will be used to determine if an account was added

        for (int i = 0; i < accountsArray.Length; i++)
        {
            if (accountsArray[i] == null)
                //checks if the value at the current index is null (empty)
            {
                //assign the employee into this cell and assigns accAdded variable to true
                accountsArray[i] = acc;
                accAdded = true;
                break;
            }
            
        }
        if (accAdded != true) //if an account was not added it will print the following...
        {
            Console.WriteLine("There is no more room to assign additional employees. The employee was NOT added.");
        } //end of if
        return accAdded;
    }

    public void ApplyDeposits() //ApplyDeposits method that will apply deposits to the account within accountsArray
    {
        for (int row = 0; row < accountsArray.Length; row++)   //for loop for rows
        { 
            if (accountsArray[row] != null)
                //only executes the body if the index holds a value (an account)
            {
                accountsArray[row].UpdateAcctBalance();
                //call to the UpdateAcctBalance method
            }
        }
    }

    public override string ToString()
    {
        string str = "";

        for (int row = 0; row < accountsArray.Length; row++)   //for loop for rows
        {
            if (accountsArray[row] != null)
                //checks to ensure that the index holds a value (an account)
            {
                str += accountsArray[row] + "\n";
                //adds the ToString of the account to the str variable
            }
            else
            //else will execute if there is no account
            {
                str += $"\nNo account found\n";
                //adds the string to the str variable
            }
        }
        return str;
    }
}
