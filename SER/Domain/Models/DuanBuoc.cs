using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DuanBuoc
    {
        public int Id { get; set; }
        public int? DuAnId { get; set; }
        public int? QuyTrinhId { get; set; }
        public int? BuocId { get; set; }
        public string? TenBuoc { get; set; }
        public bool? AllowEdit { get; set; }
        public string? PartialView { get; set; }
        public int? SoNgayThuHien { get; set; }
        public DateTime? NgayBatDauDuKien { get; set; }
        public DateTime? NgayKetThucDuKien { get; set; }
        public DateTime? NgayBatDauThucTe { get; set; }
        public DateTime? NgayKetThucThucTe { get; set; }
        public string? TrachNhiemThucHien { get; set; }
        public int? Stt { get; set; }
        public bool? Used { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsKetThuc { get; set; }

        public virtual Duan? DuAn { get; set; }
    }
}
