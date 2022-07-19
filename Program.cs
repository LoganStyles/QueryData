

int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };


var numberQuery = from num in numbers 
                    where (num % 2) != 0 
                    select num;


Console.WriteLine(numberQuery.Count());
