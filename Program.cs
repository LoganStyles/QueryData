using System.Globalization;

class Program
{
    private static void Main(string[] args)
    {
        //data source
        List<string> fruits = new List<string> { "apples", "berries", "bananas", "mangoes" };
        if (fruits.Any(fr => fr.Contains("an")))
        {
            Console.WriteLine("Yes, we have such fruits");
        }
        else
        {
            Console.WriteLine("There are no such fruits");
        }

        if (fruits.All(fr => fr.Length >=6))
        {
            Console.WriteLine("Yes, we have such fruits");
        }
        else
        {
            Console.WriteLine("There are no such fruits");
        }


    }
}
