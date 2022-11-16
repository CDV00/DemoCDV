using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class DuanQuatrinh
    {
        public int Id { get; set; }
        public int? DuAnId { get; set; }
        public int? BuocId { get; set; }
        public int? TinhTrangId { get; set; }
        public string? NoiDungXuLy { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? NgayXuLy { get; set; }

        public virtual Duan? DuAn { get; set; }
    }
}
