﻿using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        //  eager loading
        var selectedEmployees = context.Employees
            .Include(emp => emp.Studio) //including a Studio reference navigation property
            .ToList();

        Console.WriteLine();
        foreach (var emp in selectedEmployees)
        {
            Console.WriteLine("{0} works at the {1} office.", emp.LastName, emp.Studio.City);
        }
    }
}
