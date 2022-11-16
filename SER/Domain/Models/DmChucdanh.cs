using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmChucdanh
    {
        public long ChucDanhId { get; set; }
        public string? MaChucDanh { get; set; }
        public string? TenChucDanh { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
    }
}
