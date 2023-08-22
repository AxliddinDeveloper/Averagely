using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVERAGELY.Classes
{
    public class QuarterlyScore
    {
        public void CalculateTheQuarterScore()
        {
            int subjectsNum = 0;
            decimal score = 0;
            Console.Write("enter the number of your subjects:");
            subjectsNum = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int iteration = 1; iteration <= subjectsNum; iteration++)
            {
                Console.Write("enter your grade in the subject:");
                score += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine($"your quarterly score: {score/subjectsNum}");            
        }
    }
}