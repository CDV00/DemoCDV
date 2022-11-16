using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class ChusohuuQuatrinh
    {
        public int Id { get; set; }
        public int? ChuSoHuuId { get; set; }
        public int? BuocId { get; set; }
        public int? TinhTrangId { get; set; }
        public string? NoiDungXuLy { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? NgayXuLy { get; set; }
        public long? PhongBanXuLyId { get; set; }
        public long? PhongBanNhanId { get; set; }
        public string? LoaiXuLy { get; set; }
        public DateTime? HanXuLy { get; set; }
        public DateTime? NgayChuyen { get; set; }
        public int? ParentId { get; set; }
        public DateTime? NgayNhan { get; set; }
        public string? NoiDungYeuCau { get; set; }

        public virtual Chusohuu? ChuSoHuu { get; set; }
    }
}
