using System.ComponentModel.DataAnnotations.Schema;
namespace QueryData.Models.Entities{

    public class Student
    {

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long DepartmentCode { get; set; }
    }
}