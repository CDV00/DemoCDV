using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmQuanhuyen
    {
        public long QuanHuyenId { get; set; }
        public string? MaQuanHuyen { get; set; }
        public string? TenQuanHuyen { get; set; }
        public long? TinhThanhId { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
    }
}
