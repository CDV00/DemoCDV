using SER.Domain.Models;

namespace SER.Infrastructure.ViewModel.DuAn
{
    public class DuAnReponse
    {
        public int? Id { get; set; }
        public int? SLAnhHuong { get; set; }
        public int? SLDakiemDuyet { get; set; }
        public int? SLDaPheDuyet { get; set; }
        public string? MaDuAn { get; set; }
        public string? TenDuAn { get; set; }
        public string? MucTieuDuAn { get; set; }
        public string? NguonVonDauTu { get; set; }
        public string? HinhThucSuDungDat { get; set; }
        public double? DienTichThuHoi { get; set; }
        public int? SoTruongHopAnhHuong { get; set; }
        public string? ViTri { get; set; }
        public string? DiaDiem { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string? GhiChu { get; set; }
        public int? QuyTrinhId { get; set; }
        public string TenQuyTrinh { get; set; }
        public bool? Iso { get; set; }
        public int? TinhTrangHienTaiId { get; set; }
        public string TinhTrangHienTai { get; set; }
        public int? BuocHienTaiId { get; set; }
        public string BuocHienTai { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? JsonRanhDuAn { get; set; }
    }
}
