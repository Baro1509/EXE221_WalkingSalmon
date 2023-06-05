using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation {
    public class EmployerRepository : RepositoryBase<Employer>, IEmployerRepository {
        public Employer GetEmployer(int id) {
            throw new NotImplementedException();
        }
    }
}
