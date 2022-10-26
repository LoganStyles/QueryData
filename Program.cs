﻿using Microsoft.EntityFrameworkCore;
using QueryData.Models.Data;
using QueryData.Models.Entities;

class Program
{
    private static void Main(string[] args)
    {
        //write code here

        var context = new SchoolContext();

        #region  students and their departments
        //using query method
        // var selectedStudents = context.Students
        // .Join(context.Departments,stud => stud.DepartmentCode,dept=>dept.Id,(studs,depts)=>new{
        //     StudentName = studs.LastName +" "+studs.FirstName
        //     DepartmentName = depts.Title,
        // });

        //using query syntax
        var selectedStudents = from studs in context.Students
                               join depts in context.Departments
                               on studs.DepartmentCode equals depts.Id
                               select new
                               {
                                   StudentName = studs.LastName + " " + studs.FirstName,
                                   DepartmentName = depts.Title
                               };

        Console.WriteLine("DEPARTMENT \tSTUDENTS");
        //execute the query
        foreach (var student in selectedStudents)
        {
            Console.WriteLine("{0} \t{1}", student.DepartmentName, student.StudentName);
        }

        #endregion


        #region instructors & departments
        int step =2;
        int resultSet=2;
        var selectedInstructors = context.Instructors
                                .Include(instructor => instructor.Department)
                                .OrderBy(instructor => instructor.LastName)
                                .Skip(step)
                                .Take(resultSet)
                                .Select(i => new
                                {
                                    Lastname = i.LastName,
                                    Firstname = i.FirstName,
                                    DepartmentTitle = i.Department.Title
                                });

        Console.WriteLine("---INSTRUCTORS---");
        Console.WriteLine("LASTNAME FIRSTNAME\tDEPARTMENT TITLE");
        //execute the query
        foreach (var instructor in selectedInstructors)
        {

            Console.WriteLine(
                "{0} \t{1} \t{2}",
            instructor.Lastname,
            instructor.Firstname,
            instructor.DepartmentTitle
            );

        }

        #endregion

    }


}
