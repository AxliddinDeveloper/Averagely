using System;

namespace AVERAGELY.Classes
{
    public class Choose
    {
        public void choose()
        {
            QuarterlyScore quarterlyScore= new QuarterlyScore();
            AnnualScore annualScore= new AnnualScore();
            int choose = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("you have defaulted!");
                break;
            }
        }
    }
}