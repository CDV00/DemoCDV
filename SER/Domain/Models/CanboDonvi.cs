using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class CanboDonvi
    {
        public long CanBoDonViId { get; set; }
        public long? CanBoId { get; set; }
        public long? DonViId { get; set; }
        public long? ChucVuId { get; set; }
        public bool? LaChucVuChinh { get; set; }
    }
}
