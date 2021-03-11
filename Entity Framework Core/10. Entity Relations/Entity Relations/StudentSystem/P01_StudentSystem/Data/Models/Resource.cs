using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models
{
    public class Resource
    {

        [Key]
        public int ResourceId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Column("Url", TypeName = "varchar(max)")]
        public string Url { get; set; }

        public ResourceType ResourceType { get; set; }

        //foreign key
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
