//data source
string[] fruits = new string[6]
{
    "oranges",
    "apples",
    "berries",
    "grapes",
    "bananas",
    "mangoes"
};

//query for ascending sort
var ascendingFruitsQuery =
    from fruit in fruits
    orderby fruit // ascending by default
    select fruit;

//query for descending sort
var descendingFruitsQuery =
    from fruit in fruits
    orderby fruit descending// descending order
    select fruit;

//execute the ascending sort query
Console.WriteLine("Ascending Order:");
foreach (string item in ascendingFruitsQuery)
{
    Console.WriteLine(item);
}

//execute the descending sort query
Console.WriteLine(Environment.NewLine + "Descending Order:");
foreach (string item in descendingFruitsQuery)
{
    Console.WriteLine(item);
}
