using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmDantoc
    {
        public long DanTocId { get; set; }
        public string? MaDanToc { get; set; }
        public string? TenDanToc { get; set; }
        public long? QuocGiaId { get; set; }
        public long? NhomDanTocId { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
    }
}
