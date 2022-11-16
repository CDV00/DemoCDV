using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class Dmquytrinh
    {
        public int Id { get; set; }
        public string? MaQuyTrinh { get; set; }
        public string? TenQuyTrinh { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
