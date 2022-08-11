using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        #region  eager loading
        // var selectedEmployees = context.Employees
        //     .Include(emp => emp.Studio) //including a reference navigation property
        //     .ToList();

        // foreach (var emp in selectedEmployees)
        // {
        //     Console.WriteLine("{0} works at the {1} office.", emp.LastName, emp.Studio.City);
        //     System.Console.WriteLine();
        // }
        #endregion

        #region  eager loading - multiple includes
        // var selectedEmployees = context.Employees
        //     .Include(emp => emp.Studio) //including a reference navigation property
        //     .Include(emp => emp.Albums) //including a collection property
        //     .ToList();

        // foreach (var emp in selectedEmployees)
        // {
        //     Console.WriteLine(
        //         "{0} works at the {1} office and has the following album(s).",
        //         emp.LastName,
        //         emp.Studio.City
        //     );

        //     foreach (var album in emp.Albums)
        //     {
        //         System.Console.WriteLine(album.Title);
        //     }
        //         System.Console.WriteLine();
        // }
        #endregion

        #region  eager loading - multiple includes & drilling down multiple levels
        var selectedEmployees = context.Employees
            .Include(emp => emp.Studio) //including a reference navigation property
            .Include(emp => emp.Albums) //including a collection property
            .ThenInclude(alb => alb.Tags) //drilling down multiple levels
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
                System.Console.WriteLine("This album has the following tag(s)");

                foreach (var tags in album.Tags)
                {
                    System.Console.Write("{0} ", tags.Title);
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
        System.Console.WriteLine();
        }
        #endregion
    }
}
