using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
	public class EmployerRepository : RepositoryBase<Employer>, IEmployerRepository
	{
		public Employer AuthenticateEmployer(string email, string pwd)
		{
			return GetAll().Where(p => p.Email == email && p.Pwd == pwd && p.EmployerStatus != 0).FirstOrDefault();
		}

		public void CreateEmployer(Employer employer)
		{
			Create(employer);
		}

		public void DeleteEmployer(int id)
		{
			Employer employer = GetEmployer(id);
			if (employer == null)
			{
				throw new Exception();
			}
			employer.EmployerStatus = 0;
			Update(employer);
		}

		public Employer GetEmployer(int id)
		{
			return GetAll().Where(p => p.EmployerId == id && p.EmployerStatus != 0).FirstOrDefault();
		}

		public List<Employer> GetEmployers()
		{
			return GetAll().Where(p => p.EmployerStatus != 0).ToList();
		}

		public Employer UpdateEmployer(Employer employer)
		{
			Employer db = GetEmployer(employer.EmployerId);
			if (db == null)
			{
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
        public Employer UpdateEmployer(Employer employer) {
            Employer db = GetEmployer(employer.EmployerId);
            if (db == null) {
                throw new Exception();
            }
            db.EmployerName = employer.EmployerName;
            db.Phone = employer.Phone;
            db.Company = employer.Company;
            db.Email = employer.Email;
            db.Pwd = employer.Pwd;
            Update(db);
            return GetEmployer(db.EmployerId);
        }
    }
		public List<Employer> GetEmployers()
		{
			return GetAll().Where(p => p.EmployerStatus != 0).ToList();
		}

		public Employer UpdateEmployer(Employer employer)
		{
			Employer db = GetEmployer(employer.EmployerId);
			if (db == null)
			{
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
