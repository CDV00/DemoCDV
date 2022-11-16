using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmquytrinhBuoc
    {
        public int Id { get; set; }
        public int? QuyTrinhId { get; set; }
        public string? TenBuoc { get; set; }
        public bool? AllowEdit { get; set; }
        public string? PartialView { get; set; }
        public int? SoNgayThucHien { get; set; }
        public string? TrachNhiemThucHien { get; set; }
        public int? Stt { get; set; }
        public bool? Used { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
