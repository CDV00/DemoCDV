using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class Connguoi
    {
        public long ConNguoiId { get; set; }
        public string? HoTen { get; set; }
        public string? NgaySinh { get; set; }
        public string? ThangSinh { get; set; }
        public string? NamSinh { get; set; }
        public string? NoiSinh { get; set; }
        public string? NguyenQuan { get; set; }
        public string? MaSoThueCaNhan { get; set; }
        public string? DiaChiThuongTru { get; set; }
        public string? Email { get; set; }
        public string? SoDt { get; set; }
        public long? DanTocId { get; set; }
        public long? QuocGiaId { get; set; }
        public long? TonGiaoId { get; set; }
        public string? SoDinhDanh { get; set; }
        public long? TrinhDoId { get; set; }
        public int? GioiTinh { get; set; }
        public long? LoaiCaNhanId { get; set; }
        public long? DiaChiTinhThanhId { get; set; }
        public long? DiaChiQuanHuyenId { get; set; }
        public long? DiaChiPhuongXaId { get; set; }
        public string? ChoOhienTai { get; set; }
        public string? ThongTinLienHe { get; set; }
        public string? DiaChiCu { get; set; }
        public string? SoNha { get; set; }
        public string? KhuPho { get; set; }
        public long? DiaChiDuongId { get; set; }
        public string? TenDuong { get; set; }
        public bool IsPublic { get; set; }
        public string? Avatar { get; set; }
    }
}
