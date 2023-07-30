using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation {
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository {
        public List<Category> GetAllCategories() {
            return GetAll().ToList();
        }
    }
}
