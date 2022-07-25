//data source
List<int> grades = new List<int>() {20,50,60,81,95,32,45};

//query for ascending sort
var lowScoresQuery = from grade in grades
where grade > 50
select grade;

//query for descending sort
var descendingFruitsQuery = fruits
                            .OrderByDescending(fruit=>fruit); // descending order

//execute the query
Console.WriteLine("Ascending Order:");
foreach (string item in ascendingFruitsQuery)
{
    Console.WriteLine(item);
}

//execute the query
Console.WriteLine(Environment.NewLine + "Descending Order:");
foreach (string item in descendingFruitsQuery)
{
    Console.WriteLine(item);
}














