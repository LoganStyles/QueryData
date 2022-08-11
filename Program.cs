using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        // multiple includes
        var selectedEmployees = context.Employees
            .Include(emp => emp.Studio) //including a reference navigation property
            .Include(emp => emp.Albums) //including a collection property
            .ToList();

        foreach (var emp in selectedEmployees)
        {
            Console.WriteLine(
                "{0} works at the {1} office and has the following album(s).",
                emp.LastName,
                emp.Studio.City
            );

            foreach (var album in emp.Albums)
            {
                System.Console.WriteLine(album.Title);
            }
                System.Console.WriteLine();
        }

    }
}
