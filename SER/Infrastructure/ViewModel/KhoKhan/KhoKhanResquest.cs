namespace SER.Infrastructure.ViewModel.KhoKhan
{
    public class KhoKhanResquest
    {
        public int Id { get; set; }
        public int? DuAnId { get; set; }
        public DateTime? NgayBaoCao { get; set; }
        public string? NoiDung { get; set; }
        public string? DeXuat { get; set; }
        public int? TinhTrangId { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? DonViBaoCao { get; set; }

    }
}
