using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class ECapdonvi
    {
        public long CapDonViId { get; set; }
        public string? TenCapDonVi { get; set; }
        public string? MoTa { get; set; }
        public int? ThuTuHienThi { get; set; }
        public bool? Used { get; set; }
    }
}
