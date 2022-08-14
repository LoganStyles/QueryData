using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueryData
{
    public class Album{

        public Album()
        {
            Tags = new HashSet<Tag>();
        }

        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public long EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Albums")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("AlbumId")]
        [InverseProperty(nameof(Tag.Albums))]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}