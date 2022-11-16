using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmTinhthanh
    {
        public long TinhThanhId { get; set; }
        public long QuocGiaId { get; set; }
        public string? MaTinhThanh { get; set; }
        public string? TenTinhThanh { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
    }
}
