using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class ChusohuuTemp
    {
        public int? Id { get; set; }
        public int? DuAnId { get; set; }
        public string? Ma { get; set; }
        public string? HoTen { get; set; }
        public string? Cccd { get; set; }
        public string? DiaChiGiaiToa { get; set; }
        public string? DiaChiThuongTru { get; set; }
        public int? PhuongXaId { get; set; }
        public string? SoDienThoai { get; set; }
        public string? GhiChu { get; set; }
    }
}
