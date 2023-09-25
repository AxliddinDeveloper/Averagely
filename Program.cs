using System;

using AVERAGELY.Classes;

namespace AVERAGELY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuarterlyScore quarterlyScore = new QuarterlyScore();
            AnnualScore annualScore = new AnnualScore();
            InputOutput inputOutput = new InputOutput();
            inputOutput.Inputoutput();
            try
            {
                int choose = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (choose)
                {
                    case 1:
                        quarterlyScore.CalculateTheQuarterScore();
                        break;

                    case 2:
                        annualScore.CalculateTheAnnualScore();
                        break;

                    case 3:
                        Console.WriteLine("\nThank you for using our service!\n");
                        break;

                    default:
                        Console.WriteLine("You have defaulted!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
    }
}



