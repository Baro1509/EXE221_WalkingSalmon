using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Repository.Models
{
    public partial class Employer
    {
        public Employer()
        {
            Jobs = new HashSet<Job>();
        }

        public int EmployerId { get; set; }
        public string EmployerName { get; set; } = null!;
        public string? Company { get; set; }
        public string Email { get; set; } = null!;
        public string Pwd { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public byte EmployerStatus { get; set; }

        [JsonIgnore]
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
