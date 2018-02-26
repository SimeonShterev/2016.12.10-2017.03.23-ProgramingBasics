namespace Equal_Pairs
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int pairsOfNumbers = int.Parse(Console.ReadLine());
            int pairSum = 0;
            int currentSum = 0;
            int maxDiff = 0;
            int currentDiff = 0;

            for (int i = 0; i < pairsOfNumbers; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                pairSum = firstNumber + secondNumber;
                currentDiff = Math.Abs(currentSum - pairSum);
                currentSum = pairSum;

                if (i > 0 && currentDiff > maxDiff)
                {
                    maxDiff = currentDiff;
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value={0}", pairSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}