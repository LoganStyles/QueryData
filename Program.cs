using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        var employees = context.Employees.Include(emp => emp.Albums).ToList();
        
    }
}
