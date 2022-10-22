using System;

namespace Problem_1___Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {

            double foodInKg = double.Parse(Console.ReadLine());
            double hayInKg = double.Parse(Console.ReadLine());
            double coverInKg = double.Parse(Console.ReadLine());
            double weightInKg = double.Parse(Console.ReadLine());

            double foodInGr = foodInKg * 1000;
            double hayInGr = hayInKg * 1000;
            double coverInGr = coverInKg * 1000;
            double weightInGr = weightInKg * 1000;


            for (int i = 1; i <= 30; i++)
            {
                foodInGr -= 300;
                if (i % 2 == 0)
                {
                    hayInGr -= 0.05 * foodInGr;
                }
                if (i % 3 == 0)
                {
                    coverInGr = coverInGr - weightInGr / 3.00;
                }
                if (foodInGr <= 0 || hayInGr <= 0 || coverInGr <= 0)
                {
                    Console.WriteLine($"Merry must go to the pet store!");
                    break;
                }

            }

            if (foodInGr > 0 && hayInGr > 0 && coverInGr > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInGr/1000:f2}, Hay: {hayInGr/1000:f2}, Cover: {coverInGr/1000:f2}.");
            }
            
        }
    }
}
