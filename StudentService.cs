using HW1_SCD.Models;

namespace HW1_SCD.Services
{
    public class StudentService
    {
        private readonly List<Student> _students=new List<Student>() { };
        private int _nextId = 0;
        public Student Create(Student student)
        {
            student.StudentId = _nextId++;
            _students.Add(student);
            return student;
        }
        public bool Update(int id, Student updatedStudent) 
        {
            var existing = _students.FirstOrDefault(p => p.StudentId == id);
            if (existing == null)
                return false;

            existing.Name = updatedStudent.Name;
            existing.Email = updatedStudent.Email;
            existing.Department = updatedStudent.Department;
            existing.cgpa = updatedStudent.cgpa;

            return true;



        }

        public bool Delete(int id) 
        {
            var student = _students.FirstOrDefault(p => p.StudentId == id);
            if (student != null)
            {
                return true;
            
            }
            _students.Remove(student);
            return false;
        
        }

        public List<Student> GetStudents() 
        {  
            return _students;
        }

        public Student GetById(int id) 
        { 
            Student std=_students.Where(p=>p.StudentId== id).FirstOrDefault();
            return std;
        
        }



    }
}
