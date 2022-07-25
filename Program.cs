//data source
List<int> grades = new List<int>() {20,50,60,81,95,32,45};

//query for high scores
var highScoresQuery = from grade in grades
                        where grade > 69
                        select grade;


//execute the query
foreach (var item in highScoresQuery)
{
    Console.WriteLine(item);
}















