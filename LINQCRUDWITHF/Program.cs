
using System.Linq;

namespace LINQCRUDWITHF
{
    public class demo
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source = HP-ELITEBOOK\\SQLEXPRESS;initial Catalog= ADODB;Integrated Security = true;";

            // Create a new instance of StudentDataContext with the connection string


            StudentDataContext dataContext = new StudentDataContext(connectionString);

            // Perform CRUD operations using dataContext.Student
            // For example:
            // Insert a new student
            dataContext.Student.InsertOnSubmit(new Student { Name = "John", Gender = "Male", Age = 20 });
            dataContext.SubmitChanges();

            // Retrieve all students
            var students = from s in dataContext.Student select s;

            // Update a student
            var studentToUpdate = dataContext.Student.Single(s => s.Name == "John");
            studentToUpdate.Age = 21;
            dataContext.SubmitChanges();

            // Delete a student
            var studentToDelete = dataContext.Student.Single(s => s.Name == "John");
            dataContext.Student.DeleteOnSubmit(studentToDelete);
            dataContext.SubmitChanges();
        }
    }
}


/*
namespace LINQCRUDWITHF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = HP-ELITEBOOK\\SQLEXPRESS;initial Catalog= ADODB;Integrated Security = true;";
            var studentRepo = new StudentRepository(connectionString);

            // Add new student
            //studentRepo.AddStudent(new Student { Name = "Pranav Goyal", Gender = "Male", Age = 26 });

            // Display all students
            //studentRepo.DisplayStudents();

            // Update student
            // studentRepo.UpdateStudent(new Student { StudentID = 1, Name = "Jane Smith", Gender = "Female", Age = 30 });

            // Delete student
            studentRepo.DeleteStudent(13);
            studentRepo.DisplayStudents();
        }
    }
}

*/