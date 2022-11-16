using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmChucvu
    {
        public long ChucVuId { get; set; }
        public string? MaChucVu { get; set; }
        public string? TenChucVu { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
        public long? CapDonViId { get; set; }
        public int? ThuTuHienThi { get; set; }
    }
}
