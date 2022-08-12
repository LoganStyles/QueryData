using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        //drilling down multiple levels
        var selectedEmployees = context.Employees
            .Include(emp => emp.Albums) //including a collection property
            .ThenInclude(alb => alb.Tags) //drilling down to include the Tags property of Albums
            .ToList();

        foreach (var emp in selectedEmployees)
        {
            Console.WriteLine("{0} has the following album(s).", emp.LastName);

            foreach (var album in emp.Albums)
            {
                Console.WriteLine("{0} - This album has the following tag(s)", album.Title);

                foreach (var tags in album.Tags)
                {
                    Console.WriteLine("{0} ", tags.Title);
                }
            }
            Console.WriteLine();
        }
    }
}
