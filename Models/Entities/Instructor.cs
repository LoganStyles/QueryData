using System.ComponentModel.DataAnnotations.Schema;
namespace QueryData.Models.Entities{

    public class Instructor
    {

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        
        [ForeignKey("Department")]
        public long DepartmentCode { get; set; }
        public Department Department { get; set; }

    }
}