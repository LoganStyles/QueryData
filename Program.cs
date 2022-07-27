class Program
{
    private static void Main(string[] args)
    {
        //data source
        List<Employee> employees = new List<Employee> {
                                    new Employee {FirstName="Felix", LastName="Donald", Salary=7000},
                                    new Employee {FirstName="Sandra", LastName="Yemi", Salary=5400},
                                    new Employee {FirstName="Femi", LastName="Fraser", Salary=4300},
                                    new Employee {FirstName="Jones", LastName="Blaze", Salary=6100}
                                    };

        //query for employee lastname & salary
        var employeesQuery = from employee in employees
                              select new {
                                LastName=employee.LastName, 
                                Salary=employee.Salary
                                };


        Console.WriteLine("\tLASTNAME \tSALARY");
        //execute the query
        foreach (var item in employeesQuery)
        {
            Console.WriteLine("\t{0} \t\t{1}", item.LastName, item.Salary);
        }
    }
}

public class Employee{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int Salary {get; set;}
}













