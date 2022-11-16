using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmQuocgium
    {
        public long QuocGiaId { get; set; }
        public string? MaQuocGia { get; set; }
        public string? TenQuocGia { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
    }
}
