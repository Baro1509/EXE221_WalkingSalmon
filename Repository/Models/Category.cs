using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
