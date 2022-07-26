//data source
List<Employee> Employees = new List<Employee> {
    new Employee {FirstName="Felix", LastName="Donald", Salary=7000},
    new Employee {FirstName="Sandra", LastName="Yemi", Salary=5400},
    new Employee {FirstName="Jones", LastName="Blaze", Salary=6100},
    new Employee {FirstName="Charles", LastName="Fraser", Salary=4300}

    };

//query to group Employees
var EmployeeSalaryQuery = Employees
                        .GroupBy(e=>e.Salary >=5000);


//execute the query
foreach (var group in EmployeeSalaryQuery)
{
    Console.WriteLine(group.Key == true ? "High earning employee(s)" : "Low earning employee(s)");

    foreach(var salaryGroup in group)
    Console.WriteLine("\t{0}", salaryGroup.FirstName);
}

public class Employee{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int Salary {get; set;}
}













