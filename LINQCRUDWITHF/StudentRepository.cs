namespace LINQCRUDWITHF
{
    using System;
    using System.Linq;

    public class StudentRepository
    {

        private readonly StudentDataContext _db;


        public StudentRepository(string connectionString)
        {
            _db = new StudentDataContext(connectionString);
        }



        public void AddStudent(Student student)
        {
            _db.Student.InsertOnSubmit(student);
            _db.SubmitChanges();
        }

        public void UpdateStudent(Student updatedStudent)
        {
            var student = _db.Student.FirstOrDefault(s => s.StudentID == updatedStudent.StudentID);
            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.Gender = updatedStudent.Gender;
                student.Age = updatedStudent.Age;
                _db.SubmitChanges();
            }
        }

        public void DeleteStudent(int studentID)
        {
            var student = _db.Student.FirstOrDefault(s => s.StudentID == studentID);
            if (student != null)
            {
                _db.Student.DeleteOnSubmit(student);
                _db.SubmitChanges();
            }
        }

        public void DisplayStudents()
        {
            var students = _db.Student;
            Console.WriteLine($"| {"ID",-5} | {"Name",-15} | {"Gender",-8} | {"Age",-5} |");
            Console.WriteLine("-------------------------------------------");
            foreach (var student in students)
            {
                Console.WriteLine($"| {student.StudentID,-5} | {student.Name,-15} | {student.Gender,-8} | {student.Age,-5} |");
            }
        }
    }

}
