

namespace _7._Append_Arrays
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();

            input.Reverse();

            List<int> firstListParsed = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                List<string> firstList = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < firstList.Count; j++)
                {
                    firstListParsed.Add(int.Parse(firstList[j]));

                }
            }
            Console.Write(string.Join(' ', firstListParsed) + ' ');


        }
    }
}
