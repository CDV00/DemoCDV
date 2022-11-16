using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DmBuocPhongbanxuly
    {
        public int Id { get; set; }
        public int? BuocId { get; set; }
        public int? PhongBanId { get; set; }
        public int? Stt { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
