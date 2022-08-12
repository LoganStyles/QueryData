using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        
        var selectedEmployee = context.Employees.First();//fetch the first employee from the employees table
        Console.WriteLine("{0} has the following album(s).", selectedEmployee.LastName);

        context.Entry(selectedEmployee).Collection(emp => emp.Albums).Load();//load the Album property for the selected employee

        foreach (var album in selectedEmployee.Albums)
        {
            Console.WriteLine("{0} ", album.Title);
        }
        Console.WriteLine();

        context.Entry(selectedEmployee).Reference(emp => emp.Studio).Load(); //load the Studio property for the selected employee
        System.Console.WriteLine("{0} works in {1} city",selectedEmployee.LastName, selectedEmployee.Studio.City);
    }
}
