

namespace _2._Change_List
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] inputParameters = command
                    .Split()
                    .ToArray();

                string firstParameter = inputParameters[0];
                int secondParameter = int.Parse(inputParameters[1]);

                if(firstParameter == "Delete")
                {
                    if (items.Contains(secondParameter))
                    {
                        items.RemoveAll(x => x == secondParameter);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if(firstParameter == "Insert")
                {
                    int index = int.Parse(inputParameters[2]);

                    if (index < 0 || index >= items.Count)
                    {
                        continue;
                    }
                    items.Insert(index, secondParameter);
                }
            }
            Console.WriteLine(string.Join(' ', items));
        }
    }
}
