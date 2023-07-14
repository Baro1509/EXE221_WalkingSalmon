using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Repository.Models
{
    public partial class JobApplication
    {
        public int JobId { get; set; }
        public int StudentId { get; set; }
        public int? ReviewId { get; set; }

        [JsonIgnore]
        public virtual Job? Job { get; set; } = null!;
        [JsonIgnore]
        public virtual Review? Review { get; set; }
        [JsonIgnore]
        public virtual Student? Student { get; set; } = null!;
    }
}
