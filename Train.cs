

namespace _1._Train
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            int maxWagonCapacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] inputParameters = command.Split();

                if (inputParameters[0] == "Add")
                {
                    wagons.Add(int.Parse(inputParameters[1]));  
                }
                else if(inputParameters[0] != "Add" && inputParameters[0] != "end")
                {                                                                 
                    
                    for (int i = 0; i < wagons.Count; i++)                       
                    {                                                            
                        if (wagons[i] + int.Parse(inputParameters[0]) <= maxWagonCapacity)
                        {
                            wagons[i] = wagons[i] + int.Parse(inputParameters[0]);
                            break;
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(' ', wagons));

        }
    }
}
