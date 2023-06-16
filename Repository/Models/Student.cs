using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Repository.Models
{
    public partial class Student
    {
        public Student()
        {
            BillingAddresses = new HashSet<BillingAddress>();
            JobApplications = new HashSet<JobApplication>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Pwd { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string StudentAddress { get; set; } = null!;
        public byte StudentStatus { get; set; }

        [JsonIgnore]
        public virtual ICollection<BillingAddress> BillingAddresses { get; set; }
        [JsonIgnore]
        public virtual ICollection<JobApplication> JobApplications { get; set; }
    }
}
