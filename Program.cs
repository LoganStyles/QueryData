class Program
{
    private static void Main(string[] args)
    {
        //data source
        List<Employee> employees =  new List<Employee> {
                                    new Employee {FirstName="Felix", LastName="Donald", Salary=7000},
                                    new Employee {FirstName="Sandra", LastName="Yemi", Salary=5400},
                                    new Employee {FirstName="Femi", LastName="Fraser", Salary=4300},
                                    new Employee {FirstName="Jones", LastName="Blaze", Salary=6100}
                                    };

        //query to group Employees
        var employeeSalaryQuery = employees
                                .GroupBy(e => e.Salary >= 5000);


        //execute the query
        foreach (var group in employeeSalaryQuery)
        {
            Console.WriteLine(group.Key == true ? "High earning employee(s)" : "Low earning employee(s)");

            foreach(var item in group)
            Console.WriteLine("\t{0} \t{1}", item.FirstName, item.Salary);
        }
    }
}

public class Employee{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int Salary {get; set;}
}
