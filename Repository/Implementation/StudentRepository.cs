using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public void CreateStudent(Student student)
        {
            Create(student);
        }

        public void DeleteStudent(int id)
        {
            Student student = GetStudent(id);
            if (student == null)
            {
                throw new Exception();
            }
            student.StudentStatus = 0;
            Update(student);
        }

        public List<Student> GetAllStudent()
        {
            return GetAll().Where(p => p.StudentStatus != 0).ToList();
        }

        public Student GetStudent(int id)
        {
            return GetAll().Where(p => p.StudentId == id && p.StudentStatus != 0).FirstOrDefault();
        }

        public Student AuthenticateStudent(string email, string pwd)
        {
            return GetAll().Where(p => p.Email == email && p.Pwd == pwd && p.StudentStatus != 0).FirstOrDefault();
        }

        public Student UpdateStudent(Student student)
        {
            Student stu = GetStudent(student.StudentId);
            if (stu == null)
            {
                throw new Exception();
            }
            stu.FirstName = student.FirstName;
            stu.LastName = student.LastName;
            stu.Email = student.Email;
            stu.Pwd = student.Pwd;
            stu.Phone = student.Phone;
            stu.StudentAddress = student.StudentAddress;
            stu.StudentStatus = student.StudentStatus;
            Update(stu);
            return GetStudent(stu.StudentId);
        }
    }
}
