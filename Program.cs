using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        var employees = context.Employees
                .Include(emp => emp.Albums)
                .AsSplitQuery()
                .ToList();

        //var employees = context.Employees.Include(emp => emp.Albums).ToList();

        foreach (var staff in employees)
        {
            Console.WriteLine(staff.LastName);

            foreach (var album in staff.Albums)
            {
                Console.WriteLine(album.Title);
            }
        }
    }
}
