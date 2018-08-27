using System;
using System.Collections.Generic;

namespace randomSquared
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            List<int> numList = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                numList.Add(randNum.Next(1,51));
            }

            List<int> squaredNums = new List<int>();
            List<int> oddNums = new List<int>();
            foreach (int num in numList)
            {
                squaredNums.Add(num*num);
            }

            foreach (int odd in squaredNums)
            {
                if ((odd % 2) != 0)
                {
                    oddNums.Add(odd);
                }
            }

            System.Console.WriteLine($"Squares: {String.Join(", ", squaredNums)}");
            System.Console.WriteLine($"Odds: {String.Join(", ", oddNums)}");
        }
    }
}
