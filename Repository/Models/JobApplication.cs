using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class JobApplication
    {
        public int JobId { get; set; }
        public int StudentId { get; set; }
        public int? ReviewId { get; set; }

        public virtual Job Job { get; set; } = null!;
        public virtual Review? Review { get; set; }
        public virtual Student Student { get; set; } = null!;
    }
}
