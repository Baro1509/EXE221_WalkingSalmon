using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Category
    {
        public Category()
        {
            Jobs = new HashSet<Job>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public DateTime DateAdded { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
