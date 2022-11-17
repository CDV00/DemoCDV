﻿using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class Chusohuu
    {
        public Chusohuu()
        {
            ChusohuuBuocTinhtranghientais = new HashSet<ChusohuuBuocTinhtranghientai>();
            ChusohuuHosos = new HashSet<ChusohuuHoso>();
            ChusohuuQuatrinhs = new HashSet<ChusohuuQuatrinh>();
            ChusohuuThuadats = new HashSet<ChusohuuThuadat>();
        }

        public int Id { get; set; }
        public int? DuAnId { get; set; }
        public string? Ma { get; set; }
        public string? HoTen { get; set; }
        public string? Cccd { get; set; }
        public DateTime? NgayCap { get; set; }
        public string? DiaChiGiaiToa { get; set; }
        public string? DiaChiThuongTru { get; set; }
        public int? PhuongXaId { get; set; }
        public int? GioiTinh { get; set; }
        public bool? IsChuHo { get; set; }
        public string? SoDienThoai { get; set; }
        public string? NamSinh { get; set; }
        public int? SoLuongNhanKhau { get; set; }
        public int? DoiTuong { get; set; }
        public string? TenToChuc { get; set; }
        public string? JsonRanhThua { get; set; }
        public double? KinhDo { get; set; }
        public double? ViDo { get; set; }
        public int? TinhTrangHienTaiId { get; set; }
        public int? BuocHienTaiId { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public string? GhiChu { get; set; }

        public virtual Duan? DuAn { get; set; }
        public virtual ICollection<ChusohuuBuocTinhtranghientai> ChusohuuBuocTinhtranghientais { get; set; }
        public virtual ICollection<ChusohuuHoso> ChusohuuHosos { get; set; }
        public virtual ICollection<ChusohuuQuatrinh> ChusohuuQuatrinhs { get; set; }
        public virtual ICollection<ChusohuuThuadat> ChusohuuThuadats { get; set; }
    }
}