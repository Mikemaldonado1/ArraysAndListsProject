using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] NewArray=new int[] {1,2,3,4,5,6,7,8,9,10};



            //Create Lists*********************************
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();



            //Evens****************************************
            for (int i = 1; i < 11; i++)
            {
                evens.Add(i);
                //Console.WriteLine(i);
            }


            foreach (var num in evens)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"This number is even: {num}");
                }
                
            }

            Console.WriteLine();

            //Odds***********************************
            for (int i = 1; i < 11; i++)
            {
                odds.Add(i);
                //Console.WriteLine(i);
            }


            foreach (var num1 in odds)
            {
                if (num1 % 2 != 0)
                {
                    Console.WriteLine($"This number is odd: {num1}");
                }

            }


        }
    }
}
