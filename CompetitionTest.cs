using System;


public class CompetitionTest
{


    public static void Main()
    {

        string cname = "VEX Robotics";

        int[,] scores = { { 55,77,99,100,89
            },
                           {33,44,55,66,66
            },
                           {99,77,55,44,33
            },
                           {23,45,67,65,34
            },
        };


        Competition cm = new Competition(cname, scores);

        cm.ProcessScores();




        }
}
