using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmTongiao
    {
        public long TonGiaoId { get; set; }
        public string? MaTonGiao { get; set; }
        public string? TenTonGiao { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
    }
}
