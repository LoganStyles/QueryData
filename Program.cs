
// The Three Parts of a LINQ Query:
// 1. Data source.
int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

// 2. Query creation.
// numberQuery is an IEnumerable<int>
var numberQuery = from num in numbers where (num % 2) != 0 select num;

// 3. Query execution.
foreach (int num in numberQuery)
{
    Console.WriteLine("{0} ", num);
}
