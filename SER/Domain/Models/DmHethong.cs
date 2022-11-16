using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmHethong
    {
        public long HeThongId { get; set; }
        public string? TenHeThong { get; set; }
        public string? TenVietTat { get; set; }
        public string? TenHienThi { get; set; }
        public string? MoTa { get; set; }
        public string? LienKet { get; set; }
        public bool? HienThiLienKet { get; set; }
        public bool? Used { get; set; }
        public long? MaLoaiHeThongId { get; set; }
        public int? ThuTuHienThi { get; set; }
    }
}
