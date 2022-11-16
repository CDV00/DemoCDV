using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmBuocTinhtrangchusohuu
    {
        public int Id { get; set; }
        public int? BuocId { get; set; }
        public int? TinhTrangChuSoHuuId { get; set; }
        public bool? IsMacDinh { get; set; }
        public int? Stt { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
