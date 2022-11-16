using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class ChusohuuBuocTinhtranghientai
    {
        public int Id { get; set; }
        public int? ChuSoHuuId { get; set; }
        public int? BuocId { get; set; }
        public int? TinhTrangHienTaiId { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Chusohuu? ChuSoHuu { get; set; }
    }
}
