namespace AVERAGELY.Classes
{
    public class AnnualScore
    {
        public void CalculateTheAnnualScore()
        {
            try
            {
                decimal score = 0;

                for (int iteration = 1; iteration <= 4; iteration++)
                {
                    Console.Write("Enter your quarterly grades: ");
                    score += decimal.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Your annual score: {score / 4}\n");

                if (score / 4 >= 4)
                    Console.WriteLine("\tGreat!\n");
                else if (score / 4 < 4 && score / 4 >= 3)
                    Console.WriteLine("\tSatisfactory!\n");
                else
                    Console.WriteLine("\tUnsatisfied!\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
    }
}

