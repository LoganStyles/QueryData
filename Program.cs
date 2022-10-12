using System.Globalization;

class Program
{
    private static void Main(string[] args)
    {
        var numbers = System.IO.File
            .ReadAllLines(@"C:\Input.txt")
            .Select(x => x.Split(',').Select(y => int.Parse(y)).ToArray())
            .ToList();

        foreach (var item in numbers)
        {
            var output = CalculateAverage(item);
            Console.WriteLine(output);
        }
    }

    public static int CalculateAverage(int[] input)
    {
        //write your code here
        var average = Convert.ToInt32(input.Average(a => a));
        return average;
    }
}
