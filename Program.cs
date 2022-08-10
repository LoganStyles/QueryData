using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        //eager loading
        var selectedEmployees = context.Employees
                                .Include(emp => emp.Studio)
                                .ToList();

        System.Console.WriteLine();
        foreach (var emp in selectedEmployees)
        {
            System.Console.WriteLine("{0} works at {1}", emp.FirstName+" "+emp.LastName, emp.Studio.City);
        }
    }
}
