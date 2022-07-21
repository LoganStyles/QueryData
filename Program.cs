char[] letters = new char[6] { 'B', 'D', 'A', 'C', 'B', 'A' };

// letterQuery is an IEnumerable<char>
var letterQuery = letters
                    .Where(l => l == 'A');

foreach (char item in letterQuery)
{
    Console.Write("{0} ", item);
}
Console.WriteLine();
