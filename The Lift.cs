

namespace Problem_2___The_Lift
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            int waitingPeople = int.Parse(Console.ReadLine());//0
            int[] wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries) //0 0 0 0
                .Select(int.Parse)
                .ToArray();

            int maxPeopleOnWagon = 4;
            int maxPeopleOnLift = maxPeopleOnWagon * wagons.Length;//4*4=16
            int liftedPeople = 0;
            int sumOfPeople = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                int peopleOnWagon = wagons[i];//0
                if ((maxPeopleOnWagon - peopleOnWagon) <= waitingPeople)
                {
                    liftedPeople = maxPeopleOnWagon - peopleOnWagon;//4-0=4
                    peopleOnWagon += liftedPeople;//1+3
                    wagons[i] = peopleOnWagon;//4
                    waitingPeople -= liftedPeople;
                }
                else
                {
                    peopleOnWagon += waitingPeople;//3+0
                    wagons[i] = peopleOnWagon;//3
                    waitingPeople = 0;
                }
                sumOfPeople += peopleOnWagon;
            }

            if (waitingPeople == 0 && sumOfPeople < maxPeopleOnLift)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(string.Join(' ', wagons));
            }

            if(waitingPeople > 0 && sumOfPeople == maxPeopleOnLift)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(' ', wagons));
            }

            if(waitingPeople==0 && sumOfPeople == maxPeopleOnLift)
            {
                Console.WriteLine(string.Join(' ', wagons));
            }

        }
    }
}
