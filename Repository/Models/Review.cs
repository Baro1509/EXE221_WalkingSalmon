using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Review
    {
        public Review()
        {
            JobApplications = new HashSet<JobApplication>();
        }

        public int ReviewId { get; set; }
        public string? StudentComment { get; set; }
        public byte? StudentSatisfaction { get; set; }
        public string? EmployerComment { get; set; }
        public byte? EmployerSatisfaction { get; set; }
        public byte ReviewStatus { get; set; }

        public virtual ICollection<JobApplication> JobApplications { get; set; }
    }
}
