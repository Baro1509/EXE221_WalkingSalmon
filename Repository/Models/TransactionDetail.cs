using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Repository.Models
{
    public partial class TransactionDetail
    {
        public int TransactionId { get; set; }
        public int JobId { get; set; }
        public string TransactionCode { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public byte Purpose { get; set; }
        public byte TransStatus { get; set; }

        [JsonIgnore]
        public virtual Job? Job { get; set; }
    }
}
