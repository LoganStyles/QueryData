using System.ComponentModel.DataAnnotations.Schema;
namespace QueryData.Models.Entities{

    public class Student
    {

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("Department")]
        public long DepartmentCode { get; set; }
        public Department Department { get; set; }
    }
}