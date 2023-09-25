using System;

namespace AVERAGELY.Classes
{
    public class QuarterlyScore
    {
        public void CalculateTheQuarterScore()
        {
            try
            {
                int subjectsNum = 0;
                decimal score = 0;

                Console.Write("Enter the number of your subjects: ");
                subjectsNum = int.Parse(Console.ReadLine());
                Console.Clear();

                for (int iteration = 1; iteration <= subjectsNum; iteration++)
                {
                    Console.Write("Enter your grade in the subject: ");
                    score += decimal.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Your quarterly score: {score / subjectsNum}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}