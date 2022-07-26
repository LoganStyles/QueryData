internal class Program
{
    private static void Main(string[] args)
    {
        //data source
        List<Student> students = new List<Student> {
                                        new Student {FirstName="Felix", LastName="Donald", Grade=70},
                                        new Student {FirstName="Sandra", LastName="Yemi", Grade=54},
                                        new Student {FirstName="Jones", LastName="Blaze", Grade=61},
                                        new Student {FirstName="Charles", LastName="Fraser", Grade=43}

    };

        //query for high scores
        var studentGroupQuery = from student in students
                                group student by student.Grade >= 50;
                                // into g
                                // select g;

        //execute the query
        foreach (var group in studentGroupQuery)
        {
            // Console.WriteLine(group.Key);
            Console.WriteLine(group.Key == true ? "High scores" : "Low scores");

            foreach (var scoreGroup in group)
                Console.WriteLine("\t{0}", scoreGroup.FirstName);
        }
    }
}

public class Student{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int Grade {get; set;}
}













