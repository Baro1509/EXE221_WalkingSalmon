using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Repository.Models
{
    public partial class BillingAddress
    {
        public int BillingId { get; set; }
        public string BankName { get; set; } = null!;
        public string BankNumber { get; set; } = null!;
        public byte PriorityUsage { get; set; }
        public int StudentId { get; set; }

        [JsonIgnore]
        public virtual Student? Student { get; set; } = null!;
    }
}
