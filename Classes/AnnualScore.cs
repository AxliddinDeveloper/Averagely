using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVERAGELY.Classes
{
    public class AnnualScore
    {
        public void CalculateTheAnnualScore()
        {
            decimal score = 0;

            for (int iteration = 1; iteration <= 4; iteration++)
            {
                Console.Write("enter your quarterly grades: ");
                score += decimal.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"your annual score: {score/4}\n");

            if (score/4 >= 4)
                Console.WriteLine("\tGread!\n");
            else if (score/4 < 4 && score/4 >= 3)
                Console.WriteLine("\tsatisfactory!\n");
            else
                Console.WriteLine("\tunsatisfied!\n");
        }
    }
}