﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface IEmployerRepository {
        public Employer GetEmployer(int id);
        public List<Employer> GetEmployers();
        public Employer UpdateEmployer(Employer employer);
        public void CreateEmployer(Employer employer);
        public void DeleteEmployer(int id);
    }
}
