using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers1 = { 17, 12, 5, 21, 30 };

        // var query = from element in numbers1 orderby element  select element;

        // int[] numbers2 = query.ToArray();

        // foreach (int value in numbers2)
        // {
        //     Console.Write("{0} ",value);
        // }
        //     Console.WriteLine();

        var selection = numbers1.OrderBy(n => n).Skip(2).Take(2);
        foreach (int item in selection)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}
