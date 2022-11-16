using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmPhuongxa
    {
        public long PhuongXaId { get; set; }
        public string? MaPhuongXa { get; set; }
        public string? TenPhuongXa { get; set; }
        public long? QuanHuyenId { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
    }
}
