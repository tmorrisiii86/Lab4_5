using System;
using System.Collections.Generic;

namespace Lab4_5_Thomas_Morris
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            List<int> score = new List<int>();
            score.Add(4400);
            score.Add(8900);
            score.Add(1200);
            score.Add(3700);
            score.Add(7200);

            //2
            Console.WriteLine("Scores From Low to High");

            score.Sort();

            foreach (int s in score)
            {
                Console.WriteLine(s);
            }

            //3
            Console.WriteLine("High Scores");

            score.Reverse();

            foreach(int s in score)
            {
                Console.WriteLine(s);
            }

            //4
            score.Add(2400);

            //5
            score.Remove(4400);
        }
    }
}
