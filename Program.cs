using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        //fetch the first employee from the employees table
        var selectedEmployee = context.Employees.First();
        Console.WriteLine("{0} has the following album(s).", selectedEmployee.LastName);

        //load the Album property for the selected employee
        context.Entry(selectedEmployee)
                .Collection(emp => emp.Albums)
                .Load();

        foreach (var album in selectedEmployee.Albums)
        {
            Console.WriteLine("{0} ", album.Title);
        }
        Console.WriteLine();

        //load the Studio property for the selected employee
        context.Entry(selectedEmployee)
                .Reference(emp => emp.Studio)
                .Load();
                
        System.Console.WriteLine(
            "{0} works in {1} city",
            selectedEmployee.LastName,
            selectedEmployee.Studio.City
        );
    }
}
