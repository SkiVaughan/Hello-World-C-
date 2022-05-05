using System;

//Assignment: Assignment 5 - BankingApplication

public class Account
{
    //Instance Variables
    private string accountID;

    private string accountName;

    private decimal[,] deposits;

    private decimal balance;

    //constructors
    public Account (string accID, string name, decimal[,] deposit)
    {
        accountID = accID;
        accountName = name;
        deposits = deposit;
    }

    public Account (Account acc) : this (acc.accountID, acc.accountName, acc.deposits)
    {

    }

    //Methods
    public void UpdateAcctBalance() //Update Account Balance Method, adds the deposits to the balance instance variable
    {
        for (int row = 0; row < deposits.GetLength(0); row++)   //for loop for rows
        {
            for (int col = 0; col < deposits.GetLength(1); col++)   //for loop for columns
            {
                balance += deposits[row, col];  //adds deposit values to balance instance variable
            }
        }
    }

    public override string ToString()   //ToString method to display the account information
    {
        string str = String.Format($"\n\nID: {accountID}\nName: {accountName}\nDeposits: \t{DisplayDeposits():c}\nBalance: {balance:c}\nAvg Deposit for past 3 weeks: {FindAvgDeposit():c}\nHighest amount deposited: {FindHighestDeposit():c}\nLowest amount deposited: {FindLowestDeposit():c}");
         
        return str;
    }

    public string DisplayDeposits() //DisplayDeposits method to display a formatted string of deposits
    {
        string str = "";

        for (int row = 0; row < deposits.GetLength(0); row++)   //for loop for rows
        {
            for (int col = 0; col < deposits.GetLength(1); col++)   //for loop for columns
            {
                str += $"{deposits[row, col]:c} | ";
            }
            str += "\n\t\t";
        }
        return str;
    }

    public decimal FindAvgDeposit() //FindAvgDeposit method to find the average deposit of the account
    {
        decimal total = 0;
        //local variable for total

        for (int row = 0; row < deposits.GetLength(0); row++)   //for loop for rows
        {
            for (int col = 0; col < deposits.GetLength(1); col++)   //for loop for columns
            {
                total += deposits[row, col];
                //adds deposits value to total variable
            }
        }
        decimal avgDeposit = total / 3;
        //avgDeposit variable that holds the average deposit (total / count)

        return avgDeposit;
    }

    public decimal FindHighestDeposit()//FindHighestDeposit method to find the highest deposit of the account
    {
        decimal maxDeposit = 0;
        //local variable for maxDeposit

        for (int row = 0; row < deposits.GetLength(0); row++)   //for loop for rows
        {
            for (int col = 0; col < deposits.GetLength(1); col++)   //for loop for columns
            {
                if (maxDeposit < deposits[row, col])    //checks if maxDeposit is less than the deposit value at the current index
                    //if maxDeposit is less, it will execute the body
                {
                    maxDeposit = deposits[row, col];
                    //assigns the deposit value to maxDeposit variable
                }
            }
        }
        return maxDeposit;
    }

    public decimal FindLowestDeposit()//FindLowestDeposit method to find the lowest deposit of the account
    {
        decimal minDeposit = 0;
        //local variable for minDeposit

        for (int row = 0; row < deposits.GetLength(0); row++)   //for loop for rows
        {
            for (int col = 0; col < deposits.GetLength(1); col++)   //for loop for columns
            {
                if (minDeposit == 0 || minDeposit > deposits[row, col]) //checks if minDeposit is more than the deposit value as the current index, or if minDeposit is = 0
                    //if one of the conditions is true, it will execute the body
                {
                    minDeposit = deposits[row, col];
                    //assigns the deposit value to minDeposit
                }
            }
        }
        return minDeposit;
    }
}
