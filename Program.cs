//data source
List<int> grades = new List<int>() {20,50,60,81,95,32,45};

//query for high scores
var highScoresQuery = grades.Where(g=>g > 69).Select(g=>g);

//execute the query
foreach (var item in highScoresQuery)
{
    Console.WriteLine(item);
}















