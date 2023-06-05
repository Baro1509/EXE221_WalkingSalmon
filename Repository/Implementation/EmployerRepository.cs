using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation {
    public class EmployerRepository : RepositoryBase<Employer>, IEmployerRepository {
        public void DeleteEmployer(int id) {
            Employer employer = GetEmployer(id);
            if (employer == null) {
                throw new Exception();
            }
            Delete(employer);
        }

        public Employer GetEmployer(int id) {
            return GetAll().Where(p => p.EmployerId == id).FirstOrDefault();
        }

        public List<Employer> GetEmployers() {
            return GetAll().ToList();
        }

        public Employer UpdateEmployer(Employer employer) {
            Employer db = GetEmployer(employer.EmployerId);
            if (db == null) {
                throw new Exception();
            }
            db.EmployerName = employer.EmployerName;
            db.EmployerStatus = employer.EmployerStatus;
            db.Phone = employer.Phone;
            db.Company = employer.Company;
            db.Email = employer.Email;
            db.Pwd = employer.Pwd;
            Update(db);
            return GetEmployer(db.EmployerId);
        }
    }
}
