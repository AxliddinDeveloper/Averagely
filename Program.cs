using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVERAGELY.Classes;

namespace AVERAGELY
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            QuarterlyScore quarterlyScore= new QuarterlyScore();
            AnnualScore annualScore= new AnnualScore();
            InputOutput inputOutput = new InputOutput();
            inputOutput.Inputoutput();
            int choose = int.Parse(Console.ReadLine());
            Console.Clear();
            decimal score = 0;
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