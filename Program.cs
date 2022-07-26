//data source
List<Student> students = new List<Student> {
    new Student {FirstName="Felix", LastName="Donald", Grade=70},
    new Student {FirstName="Sandra", LastName="Yemi", Grade=54},
    new Student {FirstName="Jones", LastName="Blaze", Grade=61},
    new Student {FirstName="Charles", LastName="Fraser", Grade=43}

    };

//query to group students
var studentGroupQuery = students
                        .GroupBy(student=>student.Grade >=50);


//execute the query
foreach (var group in studentGroupQuery)
{
    Console.WriteLine(group.Key == true ? "Students who passed" : "Students who failed");

    foreach(var scoreGroup in group)
    Console.WriteLine("\t{0}", scoreGroup.FirstName);
}

public class Student{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int Grade {get; set;}
}













