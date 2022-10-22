

namespace Problem_3___Moving_Target
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> movingTargets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] inputParameters = command.Split();
                string commandType = inputParameters[0];
                int index = int.Parse(inputParameters[1]);

                if (commandType == "Shoot")//52 74 23 44 96 110 index = 1
                {
                    if (index < 0 || index >= movingTargets.Count)
                    {
                        continue;
                    }

                    int power = int.Parse(inputParameters[2]);//80
                    movingTargets[index] -= power;//74-80=-14
                    if(movingTargets[index] <= 0)
                    {
                        movingTargets.RemoveAt(index);
                    }
                }
                else if(commandType == "Add")
                {
                    int value = int.Parse(inputParameters[2]);

                    if (index < 0 || index >= movingTargets.Count)
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }

                    movingTargets.Insert(index, value);

                }
                else if(commandType == "Strike")//52 23 44 96 110; index = 2
                {
                    int radius = int.Parse(inputParameters[2]);//1

                    if((index - radius) < 0 || (index + radius) >= movingTargets.Count)
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }

                    movingTargets.RemoveRange((index - radius), index + radius);

                }
            }
            Console.WriteLine(string.Join('|', movingTargets));
        }
    }
}
