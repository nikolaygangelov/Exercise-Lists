

namespace _3._House_Party
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            while (numberOfCommands > 0)
            {
                string command = Console.ReadLine();
                string[] commandParameters = command.Split();
                string firstCommandParameter = commandParameters[0];
                string secondCommandParameter = commandParameters[1];
                string thirdCommandParameter = commandParameters[2];

                if(secondCommandParameter == "is" && thirdCommandParameter == "going!")
                {
                    if (!guestList.Contains(firstCommandParameter))
                    {
                        guestList.Add(firstCommandParameter);
                    }
                    else
                    {
                        Console.WriteLine($"{firstCommandParameter} is already in the list!");
                    }
                }
                else if(secondCommandParameter == "is" && thirdCommandParameter == "not")
                {
                    if (guestList.Contains(firstCommandParameter))
                    {
                        guestList.Remove(firstCommandParameter);
                    }
                    else
                    {
                        Console.WriteLine($"{firstCommandParameter} is not in the list!");
                    }
                }

                numberOfCommands--;
            }
            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}
