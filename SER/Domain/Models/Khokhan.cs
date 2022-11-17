using System.ComponentModel.DataAnnotations.Schema;

namespace SER.Domain.Models
{
    public partial class Khokhan
    {
        public Khokhan(Khokhan khokhan)
        {
            Id = khokhan.Id;
            DuAnId = khokhan.DuAnId;
            TenDuAn = khokhan.TenDuAn;
            NgayBaoCao = khokhan.NgayBaoCao;
            NoiDung = khokhan.NoiDung;
            DeXuat = khokhan.DeXuat;
            TinhTrangId = khokhan.TinhTrangId;
            CreatedUserId = khokhan.CreatedUserId;
            CreatedDate = khokhan.CreatedDate;
            UpdatedUserId = khokhan.UpdatedUserId;
            UpdatedDate = khokhan.UpdatedDate;
            DonViBaoCao = khokhan.DonViBaoCao;
            DuAn = khokhan.DuAn;
        }
        public Khokhan() { }

        public int Id { get; set; }
        public int? DuAnId { get; set; }
        [NotMapped]
        public string? TenDuAn { get; set; }
        public DateTime? NgayBaoCao { get; set; }
        public string? NoiDung { get; set; }
        public string? DeXuat { get; set; }
        [NotMapped]
        public string? TenTinhTrang { get; set; }
        public int? TinhTrangId { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? DonViBaoCao { get; set; }

        public virtual Duan? DuAn { get; set; }
    }
}
