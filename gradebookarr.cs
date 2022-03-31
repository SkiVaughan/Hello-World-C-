using System;


public class GradeBook
{
    private string courseName;

    private int[] grades;

    public GradeBook(string cn, int[] gradesInArray)
    {

        courseName = cn;

        grades = gradesInArray;

    }
    //public GradeBook(string cn, int someNumber)
    //{


    //}


    public void AssesGrades()
    {
        int total = 0;


        //for(int count=0; count < grades.Length; count++)
        //{

        //    total += grades[count];

        //}


        //SAME AS THE FOR LOOP ABOVE JUST SIMPLER
        foreach(int elem in grades)
        {
            total += elem;

        }


        decimal avg = (decimal) total / grades.Length;

        Console.WriteLine("The average of all the grades is: " + avg);


    }





}
