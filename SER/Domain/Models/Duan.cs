using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class Duan
    {
        public Duan()
        {
            Chusohuus = new HashSet<Chusohuu>();
            DuanBuocs = new HashSet<DuanBuoc>();
            DuanHosos = new HashSet<DuanHoso>();
            DuanQuatrinhs = new HashSet<DuanQuatrinh>();
            Khokhans = new HashSet<Khokhan>();
        }

        public int Id { get; set; }
        public string? MaDuAn { get; set; }
        public string? TenDuAn { get; set; }
        public string? MucTieuDuAn { get; set; }
        public string? NguonVonDauTu { get; set; }
        public string? HinhThucSuDungDat { get; set; }
        public double? DienTichThuHoi { get; set; }
        public int? SoTruongHopAnhHuong { get; set; }
        public string? ViTri { get; set; }
        public string? DiaDiem { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string? GhiChu { get; set; }
        public int? QuyTrinhId { get; set; }
        public bool? Iso { get; set; }
        public int? TinhTrangHienTaiId { get; set; }
        public int? BuocHienTaiId { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? JsonRanhDuAn { get; set; }

        public virtual ICollection<Chusohuu> Chusohuus { get; set; }
        public virtual ICollection<DuanBuoc> DuanBuocs { get; set; }
        public virtual ICollection<DuanHoso> DuanHosos { get; set; }
        public virtual ICollection<DuanQuatrinh> DuanQuatrinhs { get; set; }
        public virtual ICollection<Khokhan> Khokhans { get; set; }
    }
}
