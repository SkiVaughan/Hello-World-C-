using System;


public class Account
{
    //Attributes  (implemented through variables)

   /* private string name; */  //instance variable called name.
    private decimal balance; //use decimal wheneever you are working with currency
   
    public string Name { set; get; } //auto implemented property for the name instance variable


    //creating a custom constructor

    public Account(string initName, decimal initBal)
    {
        Name = initName;
        balance = initBal;

    }


    //Behaviors   (implemented through methods)

    //public void SetName(string custName)
    //{
    //    name = custName; //Assigns the parameter's value to the instance variable name

    //}

    //public string GetName()
    //{
    //    return name;

    //}

    //property for balance

    public decimal Balance
    {
        set
        {
            if(value >= 0)
            {
                balance = value;
            }

        }
        get
        {
            return balance;

        }


    }



    //public void SetBalance(decimal amt)
    //{
    //    if(amt >= 0)
    //    {
    //        balance = amt;

    //    }

    //}
    //public decimal GetBalance()
    //{
    //    return balance;

    //}

    public void Deposit(decimal amtToDep)
    {
        Balance = Balance + amtToDep;


    }

    public void Withdrawl(decimal amtToWD)
    {

        Balance = Balance - amtToWD;


    }




}
