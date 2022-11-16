using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class Dmvanban
    {
        public int Id { get; set; }
        public string? MaVanBan { get; set; }
        public string? TenVanBan { get; set; }
        public int? Loai { get; set; }
        public string? MoTa { get; set; }
        public bool? Used { get; set; }
        public int? Stt { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
