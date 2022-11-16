using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class EPartilal
    {
        public long Id { get; set; }
        public string? PartialCode { get; set; }
        public string? PartialName { get; set; }
        public string? MoTa { get; set; }
    }
}
