using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class BillingAddress
    {
        public int BillingId { get; set; }
        public string BankName { get; set; } = null!;
        public string BankNumber { get; set; } = null!;
        public byte PriorityUsage { get; set; }
        public int StudentId { get; set; }

        public virtual Student Student { get; set; } = null!;
    }
}
