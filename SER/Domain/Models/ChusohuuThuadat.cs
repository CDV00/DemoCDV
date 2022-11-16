using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class ChusohuuThuadat
    {
        public int Id { get; set; }
        public int? ChuSoHuuId { get; set; }
        public string? SoTo { get; set; }
        public string? SoThua { get; set; }
        public bool? MotPhan { get; set; }
        public string? BanDo { get; set; }
        public string? MaMucDichSuDung { get; set; }
        public string? GiayChungNhan { get; set; }
        public string? LoaiCongTrinhTaiSanTrenDat { get; set; }
        public int? PhuongXaId { get; set; }
        public decimal? DienTich { get; set; }
        public decimal? DienTichThuHoi { get; set; }
        public decimal? DienTichConLai { get; set; }
        public string? GhiChu { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Chusohuu? ChuSoHuu { get; set; }
    }
}
