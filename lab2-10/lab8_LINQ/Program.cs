using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 12, 7, 18, 10, 25, 22, 9, 30, 14 };
        var result = numbers.Where(n => n % 2 == 0 && n > 10).OrderByDescending(n => n).ToList();
        Console.WriteLine("Even numbers > 10, descending:");
        foreach (int n in result)
        {
            Console.WriteLine(n);
        }
        Console.ReadKey();
    }
}