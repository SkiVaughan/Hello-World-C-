using System;

public class Gradebooktest
{

    public static void Main()
    {
        Console.Write("Please enter the course name: ");
        string cn = Console.ReadLine();

        Console.Write("Please enter the number of credits: ");

        int numofCreds = int.Parse(Console.ReadLine());

        Gradebook mygb = new Gradebook(cn, numofCreds);


        mygb.AssessGrade();



    }


}
