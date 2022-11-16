using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmDonvi
    {
        public long DonViId { get; set; }
        public string? MaDonVi { get; set; }
        public string? TenDonVi { get; set; }
        public string? TenVietTat { get; set; }
        public long? DonViCapChaId { get; set; }
        public int? Cap { get; set; }
        public long? CapDonViId { get; set; }
        public long? LoaiDonViId { get; set; }
        public string? SoNha { get; set; }
        public long? DuongId { get; set; }
        public long? TinhThanhId { get; set; }
        public long? QuanHuyenId { get; set; }
        public long? PhuongXaId { get; set; }
        public string? DiaChiDayDu { get; set; }
        public string? DienThoai { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
    }
}
