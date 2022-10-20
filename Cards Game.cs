

namespace _6._Cards_Game
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            List<int> secondHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int count = firstHand.Count;
            while (firstHand.Count != 0 && secondHand.Count != 0)
            {
                int firstNumber = firstHand[0];
                int firstNumber2 = secondHand[0];

                if (firstNumber > firstNumber2)
                {
                    firstHand.Add(firstNumber2);
                    secondHand.Remove(firstNumber2);
                    firstHand.Add(firstNumber);
                    firstHand.Remove(firstNumber);
                }
                else if (firstNumber < firstNumber2)
                {
                    secondHand.Add(firstNumber);
                    secondHand.Add(firstNumber2);
                    firstHand.Remove(firstNumber);
                    secondHand.Remove(firstNumber2);
                }
                else if (firstNumber == firstNumber2)
                {
                    firstHand.Remove(firstNumber);
                    secondHand.Remove(firstNumber2);
                }
            }
            if (secondHand.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else if(firstHand.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
        }
    }
}
