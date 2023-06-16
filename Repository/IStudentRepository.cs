using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IStudentRepository
    {
        public Student GetStudent(int id);
        public Student AuthenticateStudent(string email, string pwd);
        public List<Student> GetAllStudent();
        public Student UpdateStudent(Student student);
        public void CreateStudent(Student student);
        public void DeleteStudent(int id);
    }
}
