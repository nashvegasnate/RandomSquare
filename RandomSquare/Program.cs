using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

           

            //Console.WriteLine("Press enter to get a random number");
            //Console.ReadLine();
            var randomList = new List<int>();
            for (var a = 1; a <= 20; a++)
            {
                randomList.Add(rnd.Next(1, 50));
            }

            foreach (var random2 in randomList)
            {
                Console.WriteLine(random2);
            }

            var sqList = randomList.Select(num => num * num).ToList();
            sqList.RemoveAll(num => num % 2 != 0);
            foreach(var sqNum in sqList)
            {
                Console.WriteLine(sqNum);
            }

            
            
        }
    }
}
