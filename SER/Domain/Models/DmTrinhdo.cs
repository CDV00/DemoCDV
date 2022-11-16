using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmTrinhdo
    {
        public long TrinhDoId { get; set; }
        public string? MaTrinhDo { get; set; }
        public string? TenTrinhDo { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
    }
}
