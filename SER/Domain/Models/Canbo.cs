using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class Canbo
    {
        public long CanBoId { get; set; }
        public string? NgheNghiep { get; set; }
        public string? MaSoCanBo { get; set; }
        public string? SoBhxh { get; set; }
        public long? ConNguoiId { get; set; }
        public string? ChuyenMon { get; set; }
        public long? ChucDanhId { get; set; }
    }
}
