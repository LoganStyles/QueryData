using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        var employees = context.Employees.FromSqlRaw("select * from Employees").ToList();

        foreach (var item in employees)
        {
            Console.WriteLine(item.FirstName);
        }
    }
}
