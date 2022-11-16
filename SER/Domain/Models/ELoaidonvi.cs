using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class ELoaidonvi
    {
        public long LoaiDonViId { get; set; }
        public string? TenLoaiDonVi { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
    }
}
