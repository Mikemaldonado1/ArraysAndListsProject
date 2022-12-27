using System;
using System.Collections.Generic;
//TODO:

// Create an int Array and populate numbers 1-10
int[] newArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



//Create Lists*********************************
List<int> evens = new List<int>();
List<int> odds = new List<int>();



//Code****************************************

foreach (var item in newArray)
{
    if (item % 2 == 0)
    {
        Console.WriteLine($"{item} is even");
        evens.Add(item);
    }
    else
    {
        Console.WriteLine($"{item} is odd");
        odds.Add(item);
    }
    
}

//Print****************************************

Console.WriteLine();


foreach (var item in evens)
{
    Console.WriteLine(item);
}

Console.WriteLine();

foreach (var item in odds)
{
    
    Console.WriteLine(item);
}


