using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmDuong
    {
        public long DuongId { get; set; }
        public string? TenVietTat { get; set; }
        public string? TenDuong { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
    }
}
