using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class Dmtinhtrangchusohuu
    {
        public int Id { get; set; }
        public string? MaTinhTrang { get; set; }
        public string? TenTinhTrang { get; set; }
        public string? MauTinhTrang { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
        public bool? IsHienThiLenBanDo { get; set; }
        public int? Stt { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
