using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace LINQCRUDWITHF
{
    [Database(Name = "ADODB")]
    internal class StudentDataContext : DataContext
    {
        public Table<Student> Student;

        public StudentDataContext(string connection) : base(connection)
        {

        }
    }
}
