﻿using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class ChusohuuHoso
    {
        public int Id { get; set; }
        public int? ChuSoHuuId { get; set; }
        public int? BuocId { get; set; }
        public int? TenVanBanId { get; set; }
        public string? SoVanBan { get; set; }
        public DateTime? NgayVanBan { get; set; }
        public string? DonVi { get; set; }
        public string? TrichYeu { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Chusohuu? ChuSoHuu { get; set; }
    }
}