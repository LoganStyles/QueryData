using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        //eager loading - basic example
        var selectedEmployees = context.Employees
                                .Include(emp => emp.Studio)
                                .Include(emp => emp.Albums)
                                .ToList();

        // System.Console.WriteLine();
        // foreach (var emp in selectedEmployees)
        // {
        //     System.Console.WriteLine("{0} works at {1} office.", emp.LastName, emp.Studio.City);
        // }
        
        //eager loading - multiple includes
        System.Console.WriteLine();
        foreach (var emp in selectedEmployees)
        {
            Console.WriteLine("{0} works at {1} office and has the following album(s).", emp.LastName, emp.Studio.City);

            foreach(var album in emp.Albums)
            {
                System.Console.WriteLine(album.Title);
            }
            System.Console.WriteLine();
        }
    }
}
