using System;

public class Competition
{

    private string compname;
    private int[,] scores;

    public Competition(string cname, int[,] teamScores)
    {
        compname = cname;
        scores = teamScores;

    }

    public void ProcessScores()
    {
        for(int row = 0; row < scores.GetLength(0); row++)
        {
            for(int col = 0; col < scores.GetLength(1); col++)
            {
                Console.Write($" {row},{col}= + {scores[row, col]}  ");

            }
            Console.WriteLine("Team Avg: " + GetTeamAvg(row));

            Console.WriteLine();
        }

        //array to count the values in each range
        int[] scoreCounters = new int[11];

        for (int row = 0; row < scores.GetLength(0); row++)
        {
            for (int col = 0; col < scores.GetLength(1); col++)
            {
                scoreCounters[scores[row, col] / 10]++;


            }
        }    
           //print out the elements of the scoreCounters array
           for(int i=0; i<scoreCounters.Length; i++)
            {
                Console.WriteLine($"{i}0s - {scoreCounters[i]}");


            }



        }
    public decimal GetTeamAvg(int row)
    {
        int total = 0;

        for(int i=0; i < scores.GetLength(1); i++)
        {
            total += scores[row, i];


        }
        decimal avg = (decimal) total / scores.GetLength(1);

        return avg;
    }




    }





