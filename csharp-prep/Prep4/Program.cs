using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter A list of number and type 0 when you are done ");
        List<int> numberList = new List<int>();        
        int number = -1;
        double doubleVal = 10000.000000;
        double smallestPositive = double.MaxValue;
        double smallestNegative = double.MinValue;
        while (number != 0)
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            numberList.Add(number);
        }
        numberList.Sort();
        
        foreach (double numb in numberList)
        {
            if( numb > 0 && numb  < smallestNegative)
            {
                doubleVal = numb;
            }
            
            // Console.WriteLine(numb);
            
        }
        Console.WriteLine("");
        int sum  = numberList.Sum();
        int maximum = numberList.Max();
        int minimum = numberList.Min();
        double average = numberList.Average();
        Console.WriteLine($"The Sum is:  {sum}");
        Console.WriteLine($"The Largest Number  is:  {maximum}");
        Console.WriteLine($"The Smallest number  is:  {minimum}");
        Console.WriteLine($"The Average is:  {average}");
        Console.WriteLine("");
        Console.WriteLine($"{doubleVal}");
        
    }
}

        //

// if (number > 0 && number < smallestPositive)
//                 smallestPositive = number;
//             else if (number < 0 && number > smallestNegative)
//                 smallestNegative = number;


//    if(num > max)
//             max = num;
//         if(num < min)
//             min = num;

//         sum += num;
//         squaresum += num * num;
//         count++;