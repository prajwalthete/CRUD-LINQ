
using System.Data.Linq.Mapping;

namespace LINQCRUDWITHF
{
    [Table(Name = "Student")]
    public class Student
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int StudentID { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Gender { get; set; }

        [Column]
        public int Age { get; set; }
    }

}
