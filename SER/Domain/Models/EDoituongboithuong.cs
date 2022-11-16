using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class EDoituongboithuong
    {
        public long DoiTuongBoiThuongId { get; set; }
        public string? TenDoiTuong { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
    }
}
