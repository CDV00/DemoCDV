using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class ChusohuuThuadatTemp
    {
        public int? Stt { get; set; }
        public int? ChuSoHuuId { get; set; }
        public string? SoTo { get; set; }
        public string? SoThua { get; set; }
        public bool? MotPhan { get; set; }
        public string? MaMucDichSuDung { get; set; }
        public string? GiayChungNhan { get; set; }
        public int? PhuongXaId { get; set; }
        public decimal? DienTichThuHoi { get; set; }
        public decimal? ToanBo { get; set; }
        public decimal? DtmotPhan { get; set; }
        public decimal? DienTichConLai { get; set; }
        public string? GhiChu { get; set; }
    }
}
