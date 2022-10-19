

namespace _4._List_Operations
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
            while ((command = Console.ReadLine()) != "End")
            {
                string[] inputParameters = command.Split();
                string firstParameter = inputParameters[0];
                string secondParameterString = inputParameters[1];


                if (firstParameter == "Add")
                {
                    int secondParameter = int.Parse(inputParameters[1]);
                    items.Add(secondParameter);
                }
                else if (firstParameter == "Insert")
                {
                    int secondParameter = int.Parse(inputParameters[1]);
                    int index = int.Parse(inputParameters[2]);

                    if (index < 0 || index >= items.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        items.Insert(index, secondParameter);
                    }
                }
                else if (firstParameter == "Remove")
                {
                    int index = int.Parse(inputParameters[1]); ;

                    if (index < 0 || index >= items.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        items.RemoveAt(index);
                    }
                }
                else if (firstParameter == "Shift" && secondParameterString == "left")
                {
                    int rotations = int.Parse(inputParameters[2]);
                    while (rotations > 0)
                    {
                        for (int i = 0; i < items.Count - 1; i++)
                        {
                            int firstNumber = items[i];
                            items[i] = items[i + 1];
                            items[i + 1] = firstNumber;
                        }
                        rotations--;
                    }

                }
                else if (firstParameter == "Shift" && secondParameterString == "right")
                {
                    int rotations = int.Parse(inputParameters[2]);
                    while (rotations > 0)
                    {
                        for (int i = items.Count - 1; i > 0; i--)
                        {
                            int firstNumber = items[i];
                            items[i] = items[i - 1];
                            items[i - 1] = firstNumber;
                        }
                        rotations--;
                    }

                }
            }
            Console.WriteLine(string.Join(' ', items));
        }
    }
}
