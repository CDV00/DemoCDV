using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class UserMaster
    {
        public long UserMasterId { get; set; }
        public string? UserName { get; set; }
        public string? HoTen { get; set; }
        public long? PhongBanId { get; set; }
        public long? DonViId { get; set; }
        public long? UserPortalId { get; set; }
        public long? CanBoId { get; set; }
        public bool? LaDonViChinh { get; set; }
        public bool? Used { get; set; }
    }
}
