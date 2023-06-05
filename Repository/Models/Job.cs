﻿using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Job
    {
        public Job()
        {
            JobApplications = new HashSet<JobApplication>();
        }

        public int JobId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string WorkLocation { get; set; } = null!;
        public string WorkType { get; set; } = null!;
        public double SalaryRate { get; set; }
        public string SalaryType { get; set; } = null!;
        public byte JobStatus { get; set; }
        public int EmployerId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Employer Employer { get; set; } = null!;
        public virtual ICollection<JobApplication> JobApplications { get; set; }
    }
}
