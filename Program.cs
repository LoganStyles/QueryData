using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        //eager loading - multiple includes
        var selectedEmployees = context.Employees
            .Include(emp => emp.Studio) //including a reference navigation property
            .Include(emp => emp.Albums) //including a collection property
            .ThenInclude(alb => alb.Tags) //drilling down multiple levels
            .ToList();

        System.Console.WriteLine();
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
                System.Console.WriteLine("\tThis album has the following tags");

                foreach (var tags in album.Tags)
                {
                    System.Console.WriteLine("\t\t{0}",tags.Title);
                }
            }
            System.Console.WriteLine();
        }
    }
}
