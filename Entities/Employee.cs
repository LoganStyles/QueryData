using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueryData
{
    public class Employee{

        public Employee()
        {
            Albums = new HashSet<Album>();
        }

        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Age { get; set; }

        [InverseProperty("Employee")]
        public virtual Studio Studio { get; set; }
        
        [InverseProperty(nameof(Album.Employee))]
        public virtual ICollection<Album> Albums { get; set; }
    }
}