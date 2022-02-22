using System;

public class Gradebook
{
    //Attributes

    public string CourseName { get; set; }

    public int NumofCredits { get; set; }


    public Gradebook(string CName, int NumCredits)
    {

        CourseName = CName;

        NumofCredits = NumCredits;


    }

    public void AssessGrade()
    {
        int count = 0;
        int grade;
        int total = 0;

        while(count <= 10)
        {
            Console.Write("Please enter a grade: ");

            
            grade = int.Parse(Console.ReadLine());
            if (grade > 100)
            {
                Console.WriteLine("Incorrect Entry");

            }

            total = total + grade;

            count = count + 1;

        }

        double avg = (double)total / 10;

        Console.WriteLine("The average of the ten grades is: " + avg);





    }





}


