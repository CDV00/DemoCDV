using Microsoft.EntityFrameworkCore;
using SER.Domain.Models;

namespace SER.Infrastructure.Data
{
    public partial class VI_GPMBContext : DbContext
    {
        public VI_GPMBContext()
        {
        }

        public VI_GPMBContext(DbContextOptions<VI_GPMBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Canbo> Canbos { get; set; } = null!;
        public virtual DbSet<CanboDonvi> CanboDonvis { get; set; } = null!;
        public virtual DbSet<Chusohuu> Chusohuus { get; set; } = null!;
        public virtual DbSet<ChusohuuBuocTinhtranghientai> ChusohuuBuocTinhtranghientais { get; set; } = null!;
        public virtual DbSet<ChusohuuHm> ChusohuuHms { get; set; } = null!;
        public virtual DbSet<ChusohuuHoso> ChusohuuHosos { get; set; } = null!;
        public virtual DbSet<ChusohuuQuatrinh> ChusohuuQuatrinhs { get; set; } = null!;
        public virtual DbSet<ChusohuuTemp> ChusohuuTemps { get; set; } = null!;
        public virtual DbSet<ChusohuuThuadat> ChusohuuThuadats { get; set; } = null!;
        public virtual DbSet<ChusohuuThuadatTemp> ChusohuuThuadatTemps { get; set; } = null!;
        public virtual DbSet<Connguoi> Connguois { get; set; } = null!;
        public virtual DbSet<DmBuocPhongbanxuly> DmBuocPhongbanxulies { get; set; } = null!;
        public virtual DbSet<DmBuocTinhtrangchusohuu> DmBuocTinhtrangchusohuus { get; set; } = null!;
        public virtual DbSet<DmBuocTinhtrangduan> DmBuocTinhtrangduans { get; set; } = null!;
        public virtual DbSet<DmChucdanh> DmChucdanhs { get; set; } = null!;
        public virtual DbSet<DmChucvu> DmChucvus { get; set; } = null!;
        public virtual DbSet<DmDantoc> DmDantocs { get; set; } = null!;
        public virtual DbSet<DmDonvi> DmDonvis { get; set; } = null!;
        public virtual DbSet<DmDuong> DmDuongs { get; set; } = null!;
        public virtual DbSet<DmHethong> DmHethongs { get; set; } = null!;
        public virtual DbSet<DmPhuongxa> DmPhuongxas { get; set; } = null!;
        public virtual DbSet<DmQuanhuyen> DmQuanhuyens { get; set; } = null!;
        public virtual DbSet<DmQuocgium> DmQuocgia { get; set; } = null!;
        public virtual DbSet<DmTinhthanh> DmTinhthanhs { get; set; } = null!;
        public virtual DbSet<DmTongiao> DmTongiaos { get; set; } = null!;
        public virtual DbSet<DmTrinhdo> DmTrinhdos { get; set; } = null!;
        public virtual DbSet<Dmquytrinh> Dmquytrinhs { get; set; } = null!;
        public virtual DbSet<DmquytrinhBuoc> DmquytrinhBuocs { get; set; } = null!;
        public virtual DbSet<Dmtinhtrangchusohuu> Dmtinhtrangchusohuus { get; set; } = null!;
        public virtual DbSet<Dmtinhtrangduan> Dmtinhtrangduans { get; set; } = null!;
        public virtual DbSet<Dmtinhtrangkhokhan> Dmtinhtrangkhokhans { get; set; } = null!;
        public virtual DbSet<Dmvanban> Dmvanbans { get; set; } = null!;
        public virtual DbSet<Duan> Duans { get; set; } = null!;
        public virtual DbSet<DuanBuoc> DuanBuocs { get; set; } = null!;
        public virtual DbSet<DuanHoso> DuanHosos { get; set; } = null!;
        public virtual DbSet<DuanQuatrinh> DuanQuatrinhs { get; set; } = null!;
        public virtual DbSet<ECapdonvi> ECapdonvis { get; set; } = null!;
        public virtual DbSet<EDoituongboithuong> EDoituongboithuongs { get; set; } = null!;
        public virtual DbSet<ELoaidonvi> ELoaidonvis { get; set; } = null!;
        public virtual DbSet<EPartilal> EPartilals { get; set; } = null!;
        public virtual DbSet<Khokhan> Khokhans { get; set; } = null!;
        public virtual DbSet<MucDichSuDung> MucDichSuDungs { get; set; } = null!;
        public virtual DbSet<Tepdinhkem> Tepdinhkems { get; set; } = null!;
        public virtual DbSet<UserMaster> UserMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.*/
                optionsBuilder.UseSqlServer("Server=192.168.1.3,1436\\\\\\\\SQL2K16;Database=VI_GPMB;Persist Security Info=True;User ID=vietinfo;password=Vietinfo@#@!;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Canbo>(entity =>
            {
                entity.ToTable("CANBO");

                entity.Property(e => e.CanBoId).HasColumnName("CanBoID");

                entity.Property(e => e.ChucDanhId).HasColumnName("ChucDanhID");

                entity.Property(e => e.ChuyenMon).HasMaxLength(2000);

                entity.Property(e => e.ConNguoiId).HasColumnName("ConNguoiID");

                entity.Property(e => e.MaSoCanBo).HasMaxLength(20);

                entity.Property(e => e.NgheNghiep).HasMaxLength(2000);

                entity.Property(e => e.SoBhxh)
                    .HasMaxLength(20)
                    .HasColumnName("SoBHXH");
            });

            modelBuilder.Entity<CanboDonvi>(entity =>
            {
                entity.HasKey(e => e.CanBoDonViId)
                    .HasName("PK__CANBO_DO__CE98177A3BAF758A")
                    .IsClustered(false);

                entity.ToTable("CANBO_DONVI");

                entity.Property(e => e.CanBoDonViId).HasColumnName("CanBoDonViID");

                entity.Property(e => e.CanBoId).HasColumnName("CanBoID");

                entity.Property(e => e.ChucVuId).HasColumnName("ChucVuID");

                entity.Property(e => e.DonViId).HasColumnName("DonViID");
            });

            modelBuilder.Entity<Chusohuu>(entity =>
            {
                entity.ToTable("CHUSOHUU");

                entity.Property(e => e.BuocHienTaiId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(200)
                    .HasColumnName("CCCD");

                entity.Property(e => e.DiaChiGiaiToa).HasMaxLength(500);

                entity.Property(e => e.DiaChiThuongTru).HasMaxLength(500);

                entity.Property(e => e.HoTen).HasMaxLength(200);

                entity.Property(e => e.IsChuHo).HasColumnName("isChuHo");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Ma).HasMaxLength(50);

                entity.Property(e => e.NamSinh).HasMaxLength(50);

                entity.Property(e => e.SoDienThoai).HasMaxLength(200);

                entity.Property(e => e.TenToChuc).HasMaxLength(200);

                entity.Property(e => e.TinhTrangHienTaiId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.DuAn)
                    .WithMany(p => p.Chusohuus)
                    .HasForeignKey(d => d.DuAnId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CHUSOHUU_DUAN");
            });

            modelBuilder.Entity<ChusohuuBuocTinhtranghientai>(entity =>
            {
                entity.ToTable("CHUSOHUU_BUOC_TINHTRANGHIENTAI");

                entity.HasIndex(e => e.ChuSoHuuId, "IX_CHUSOHUU_BUOC_TINHTRANGHIENTAI_ChuSoHuuId");

                entity.HasOne(d => d.ChuSoHuu)
                    .WithMany(p => p.ChusohuuBuocTinhtranghientais)
                    .HasForeignKey(d => d.ChuSoHuuId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BUOC_CHUSOHUU");
            });

            modelBuilder.Entity<ChusohuuHm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CHUSOHUU_HM");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(200)
                    .HasColumnName("CCCD");

                entity.Property(e => e.Cshid).HasColumnName("CSHID");

                entity.Property(e => e.DiaChiGiaiToa).HasMaxLength(500);

                entity.Property(e => e.DiaChiThuongTru).HasMaxLength(500);

                entity.Property(e => e.HoTen).HasMaxLength(200);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsChuHo).HasColumnName("isChuHo");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Ma).HasMaxLength(50);

                entity.Property(e => e.NamSinh).HasMaxLength(50);

                entity.Property(e => e.SoDienThoai).HasMaxLength(200);

                entity.Property(e => e.TenToChuc).HasMaxLength(200);
            });

            modelBuilder.Entity<ChusohuuHoso>(entity =>
            {
                entity.ToTable("CHUSOHUU_HOSO");

                entity.HasIndex(e => e.ChuSoHuuId, "IX_CHUSOHUU_HOSO_ChuSoHuuId");

                entity.Property(e => e.DonVi).HasMaxLength(200);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.NgayVanBan).HasColumnType("date");

                entity.Property(e => e.SoVanBan).HasMaxLength(50);

                entity.Property(e => e.TrichYeu).HasMaxLength(200);

                entity.HasOne(d => d.ChuSoHuu)
                    .WithMany(p => p.ChusohuuHosos)
                    .HasForeignKey(d => d.ChuSoHuuId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HOSO_CHUSOHUU");
            });

            modelBuilder.Entity<ChusohuuQuatrinh>(entity =>
            {
                entity.ToTable("CHUSOHUU_QUATRINH");

                entity.HasIndex(e => e.ChuSoHuuId, "IX_CHUSOHUU_QUATRINH_ChuSoHuuId");

                entity.Property(e => e.LoaiXuLy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoiDungXuLy).HasMaxLength(500);

                entity.Property(e => e.NoiDungYeuCau).HasMaxLength(500);

                entity.HasOne(d => d.ChuSoHuu)
                    .WithMany(p => p.ChusohuuQuatrinhs)
                    .HasForeignKey(d => d.ChuSoHuuId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_QUATRINH_CHUSOHUU");
            });

            modelBuilder.Entity<ChusohuuTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CHUSOHUU_TEMP");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(200)
                    .HasColumnName("CCCD");

                entity.Property(e => e.DiaChiGiaiToa).HasMaxLength(500);

                entity.Property(e => e.DiaChiThuongTru).HasMaxLength(500);

                entity.Property(e => e.HoTen).HasMaxLength(200);

                entity.Property(e => e.Ma).HasMaxLength(50);

                entity.Property(e => e.SoDienThoai).HasMaxLength(200);
            });

            modelBuilder.Entity<ChusohuuThuadat>(entity =>
            {
                entity.ToTable("CHUSOHUU_THUADAT");

                entity.HasIndex(e => e.ChuSoHuuId, "IX_CHUSOHUU_THUADAT_ChuSoHuuId");

                entity.Property(e => e.BanDo).HasMaxLength(50);

                entity.Property(e => e.DienTich).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DienTichConLai).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DienTichThuHoi).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GiayChungNhan).HasMaxLength(500);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.LoaiCongTrinhTaiSanTrenDat).HasMaxLength(200);

                entity.Property(e => e.MaMucDichSuDung).HasMaxLength(50);

                entity.Property(e => e.PhuongXaId).HasColumnName("PhuongXaID");

                entity.Property(e => e.SoThua).HasMaxLength(200);

                entity.Property(e => e.SoTo).HasMaxLength(50);

                entity.HasOne(d => d.ChuSoHuu)
                    .WithMany(p => p.ChusohuuThuadats)
                    .HasForeignKey(d => d.ChuSoHuuId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_THUADAT_CHUSOHUU");
            });

            modelBuilder.Entity<ChusohuuThuadatTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CHUSOHUU_THUADAT_TEMP");

                entity.Property(e => e.DienTichConLai).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DienTichThuHoi).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DtmotPhan)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("DTMotPhan");

                entity.Property(e => e.GiayChungNhan).HasMaxLength(500);

                entity.Property(e => e.MaMucDichSuDung).HasMaxLength(50);

                entity.Property(e => e.PhuongXaId).HasColumnName("PhuongXaID");

                entity.Property(e => e.SoThua).HasMaxLength(200);

                entity.Property(e => e.SoTo).HasMaxLength(50);

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.ToanBo).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Connguoi>(entity =>
            {
                entity.HasKey(e => e.ConNguoiId)
                    .HasName("PK__CONNGUOI__04399677D9AD83E9")
                    .IsClustered(false);

                entity.ToTable("CONNGUOI");

                entity.Property(e => e.ConNguoiId).HasColumnName("ConNguoiID");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ChoOhienTai)
                    .HasMaxLength(2000)
                    .HasColumnName("ChoOHienTai");

                entity.Property(e => e.DanTocId).HasColumnName("DanTocID");

                entity.Property(e => e.DiaChiCu).HasMaxLength(2000);

                entity.Property(e => e.DiaChiDuongId).HasColumnName("DiaChiDuongID");

                entity.Property(e => e.DiaChiPhuongXaId).HasColumnName("DiaChiPhuongXaID");

                entity.Property(e => e.DiaChiQuanHuyenId).HasColumnName("DiaChiQuanHuyenID");

                entity.Property(e => e.DiaChiThuongTru).HasMaxLength(2000);

                entity.Property(e => e.DiaChiTinhThanhId).HasColumnName("DiaChiTinhThanhID");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen).HasMaxLength(500);

                entity.Property(e => e.KhuPho).HasMaxLength(100);

                entity.Property(e => e.LoaiCaNhanId).HasColumnName("LoaiCaNhanID");

                entity.Property(e => e.MaSoThueCaNhan).HasMaxLength(20);

                entity.Property(e => e.NamSinh).HasMaxLength(4);

                entity.Property(e => e.NgaySinh).HasMaxLength(2);

                entity.Property(e => e.NguyenQuan).HasMaxLength(2000);

                entity.Property(e => e.NoiSinh).HasMaxLength(2000);

                entity.Property(e => e.QuocGiaId).HasColumnName("QuocGiaID");

                entity.Property(e => e.SoDinhDanh).HasMaxLength(20);

                entity.Property(e => e.SoDt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SoDT");

                entity.Property(e => e.SoNha).HasMaxLength(100);

                entity.Property(e => e.TenDuong).HasMaxLength(200);

                entity.Property(e => e.ThangSinh).HasMaxLength(5);

                entity.Property(e => e.ThongTinLienHe).HasMaxLength(2000);

                entity.Property(e => e.TonGiaoId).HasColumnName("TonGiaoID");

                entity.Property(e => e.TrinhDoId).HasColumnName("TrinhDoID");
            });

            modelBuilder.Entity<DmBuocPhongbanxuly>(entity =>
            {
                entity.ToTable("DM_BUOC_PHONGBANXULY");

                entity.Property(e => e.Stt).HasColumnName("STT");
            });

            modelBuilder.Entity<DmBuocTinhtrangchusohuu>(entity =>
            {
                entity.ToTable("DM_BUOC_TINHTRANGCHUSOHUU");

                entity.Property(e => e.IsMacDinh).HasColumnName("isMacDinh");

                entity.Property(e => e.Stt).HasColumnName("STT");
            });

            modelBuilder.Entity<DmBuocTinhtrangduan>(entity =>
            {
                entity.ToTable("DM_BUOC_TINHTRANGDUAN");

                entity.Property(e => e.Stt).HasColumnName("STT");
            });

            modelBuilder.Entity<DmChucdanh>(entity =>
            {
                entity.HasKey(e => e.ChucDanhId)
                    .HasName("PK__DM_CHUCD__76C81A8C2F42C061")
                    .IsClustered(false);

                entity.ToTable("DM_CHUCDANH");

                entity.Property(e => e.ChucDanhId).HasColumnName("ChucDanhID");

                entity.Property(e => e.MaChucDanh).HasMaxLength(5);

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.TenChucDanh).HasMaxLength(500);
            });

            modelBuilder.Entity<DmChucvu>(entity =>
            {
                entity.HasKey(e => e.ChucVuId)
                    .HasName("PK__DM_CHUCV__3457B660166B6387")
                    .IsClustered(false);

                entity.ToTable("DM_CHUCVU");

                entity.Property(e => e.ChucVuId).HasColumnName("ChucVuID");

                entity.Property(e => e.CapDonViId).HasColumnName("CapDonViID");

                entity.Property(e => e.MaChucVu).HasMaxLength(5);

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.TenChucVu).HasMaxLength(500);
            });

            modelBuilder.Entity<DmDantoc>(entity =>
            {
                entity.HasKey(e => e.DanTocId)
                    .HasName("PK__DM_DANTO__F44CC5B6BE02E10D")
                    .IsClustered(false);

                entity.ToTable("DM_DANTOC");

                entity.Property(e => e.DanTocId).HasColumnName("DanTocID");

                entity.Property(e => e.MaDanToc).HasMaxLength(5);

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.NhomDanTocId).HasColumnName("NhomDanTocID");

                entity.Property(e => e.QuocGiaId).HasColumnName("QuocGiaID");

                entity.Property(e => e.TenDanToc).HasMaxLength(500);
            });

            modelBuilder.Entity<DmDonvi>(entity =>
            {
                entity.HasKey(e => e.DonViId)
                    .HasName("PK__DM_DONVI__1CB88576D84B4D4C")
                    .IsClustered(false);

                entity.ToTable("DM_DONVI");

                entity.HasIndex(e => e.DonViCapChaId, "IDX_DM_DONVI_01");

                entity.Property(e => e.DonViId).HasColumnName("DonViID");

                entity.Property(e => e.CapDonViId).HasColumnName("CapDonViID");

                entity.Property(e => e.DiaChiDayDu).HasMaxLength(1000);

                entity.Property(e => e.DienThoai).HasMaxLength(50);

                entity.Property(e => e.DonViCapChaId).HasColumnName("DonViCapChaID");

                entity.Property(e => e.DuongId).HasColumnName("DuongID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Latitude).HasMaxLength(20);

                entity.Property(e => e.LoaiDonViId).HasColumnName("LoaiDonViID");

                entity.Property(e => e.Longitude).HasMaxLength(20);

                entity.Property(e => e.MaDonVi).HasMaxLength(20);

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.PhuongXaId).HasColumnName("PhuongXaID");

                entity.Property(e => e.QuanHuyenId).HasColumnName("QuanHuyenID");

                entity.Property(e => e.SoNha).HasMaxLength(100);

                entity.Property(e => e.TenDonVi).HasMaxLength(2000);

                entity.Property(e => e.TenVietTat).HasMaxLength(100);

                entity.Property(e => e.TinhThanhId).HasColumnName("TinhThanhID");

                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<DmDuong>(entity =>
            {
                entity.HasKey(e => e.DuongId)
                    .HasName("PK__DM_DUONG__A81CF1F76A4BC332");

                entity.ToTable("DM_DUONG");

                entity.Property(e => e.DuongId).HasColumnName("DuongID");

                entity.Property(e => e.MoTa).HasMaxLength(2000);

                entity.Property(e => e.TenDuong).HasMaxLength(200);

                entity.Property(e => e.TenVietTat).HasMaxLength(50);
            });

            modelBuilder.Entity<DmHethong>(entity =>
            {
                entity.HasKey(e => e.HeThongId)
                    .HasName("PK__DM_HETHO__2B8D4567F48D6584");

                entity.ToTable("DM_HETHONG");

                entity.Property(e => e.HeThongId).HasColumnName("HeThongID");

                entity.Property(e => e.LienKet).HasMaxLength(500);

                entity.Property(e => e.MaLoaiHeThongId).HasColumnName("MaLoaiHeThongID");

                entity.Property(e => e.MoTa).HasMaxLength(2000);

                entity.Property(e => e.TenHeThong).HasMaxLength(2000);

                entity.Property(e => e.TenHienThi).HasMaxLength(50);

                entity.Property(e => e.TenVietTat).HasMaxLength(50);
            });

            modelBuilder.Entity<DmPhuongxa>(entity =>
            {
                entity.HasKey(e => e.PhuongXaId)
                    .HasName("PK__DM_PHUON__F6BE5034EEAA8E59")
                    .IsClustered(false);

                entity.ToTable("DM_PHUONGXA");

                entity.Property(e => e.PhuongXaId).HasColumnName("PhuongXaID");

                entity.Property(e => e.MaPhuongXa).HasMaxLength(5);

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.QuanHuyenId).HasColumnName("QuanHuyenID");

                entity.Property(e => e.TenPhuongXa).HasMaxLength(500);
            });

            modelBuilder.Entity<DmQuanhuyen>(entity =>
            {
                entity.HasKey(e => e.QuanHuyenId)
                    .HasName("PK__DM_QUANH__23AD20E1CC1F4C7C")
                    .IsClustered(false);

                entity.ToTable("DM_QUANHUYEN");

                entity.Property(e => e.QuanHuyenId).HasColumnName("QuanHuyenID");

                entity.Property(e => e.MaQuanHuyen).HasMaxLength(5);

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.TenQuanHuyen).HasMaxLength(500);

                entity.Property(e => e.TinhThanhId).HasColumnName("TinhThanhID");
            });

            modelBuilder.Entity<DmQuocgium>(entity =>
            {
                entity.HasKey(e => e.QuocGiaId)
                    .HasName("PK__DM_QUOCG__E2005B5C6906E4D0")
                    .IsClustered(false);

                entity.ToTable("DM_QUOCGIA");

                entity.Property(e => e.QuocGiaId).HasColumnName("QuocGiaID");

                entity.Property(e => e.MaQuocGia).HasMaxLength(5);

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.TenQuocGia).HasMaxLength(500);
            });

            modelBuilder.Entity<DmTinhthanh>(entity =>
            {
                entity.HasKey(e => e.TinhThanhId)
                    .HasName("PK__DM_TINHT__EA88ACCBA6AA4941")
                    .IsClustered(false);

                entity.ToTable("DM_TINHTHANH");

                entity.Property(e => e.TinhThanhId).HasColumnName("TinhThanhID");

                entity.Property(e => e.MaTinhThanh).HasMaxLength(5);

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.QuocGiaId).HasColumnName("QuocGiaID");

                entity.Property(e => e.TenTinhThanh).HasMaxLength(500);
            });

            modelBuilder.Entity<DmTongiao>(entity =>
            {
                entity.HasKey(e => e.TonGiaoId)
                    .HasName("PK__DM_TONGI__91E1A9C63F93A9EA")
                    .IsClustered(false);

                entity.ToTable("DM_TONGIAO");

                entity.Property(e => e.TonGiaoId).HasColumnName("TonGiaoID");

                entity.Property(e => e.MaTonGiao).HasMaxLength(5);

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.TenTonGiao).HasMaxLength(500);
            });

            modelBuilder.Entity<DmTrinhdo>(entity =>
            {
                entity.HasKey(e => e.TrinhDoId)
                    .HasName("PK__DM_TRINH__ABDAD92841E8421F")
                    .IsClustered(false);

                entity.ToTable("DM_TRINHDO");

                entity.Property(e => e.TrinhDoId).HasColumnName("TrinhDoID");

                entity.Property(e => e.MaTrinhDo).HasMaxLength(5);

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.TenTrinhDo).HasMaxLength(500);
            });

            modelBuilder.Entity<Dmquytrinh>(entity =>
            {
                entity.ToTable("DMQUYTRINH");

                entity.Property(e => e.MaQuyTrinh).HasMaxLength(20);

                entity.Property(e => e.TenQuyTrinh).HasMaxLength(200);
            });

            modelBuilder.Entity<DmquytrinhBuoc>(entity =>
            {
                entity.ToTable("DMQUYTRINH_BUOC");

                entity.Property(e => e.AllowEdit).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartialView).HasMaxLength(200);

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenBuoc).HasMaxLength(500);

                entity.Property(e => e.TrachNhiemThucHien).HasMaxLength(500);
            });

            modelBuilder.Entity<Dmtinhtrangchusohuu>(entity =>
            {
                entity.ToTable("DMTINHTRANGCHUSOHUU");

                entity.Property(e => e.MaTinhTrang).HasMaxLength(20);

                entity.Property(e => e.MauTinhTrang).HasMaxLength(50);

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenTinhTrang).HasMaxLength(200);
            });

            modelBuilder.Entity<Dmtinhtrangduan>(entity =>
            {
                entity.ToTable("DMTINHTRANGDUAN");

                entity.Property(e => e.MaTinhTrang).HasMaxLength(20);

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenTinhTrang).HasMaxLength(200);
            });

            modelBuilder.Entity<Dmtinhtrangkhokhan>(entity =>
            {
                entity.ToTable("DMTINHTRANGKHOKHAN");

                entity.Property(e => e.MaTinhTrang).HasMaxLength(20);

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenTinhTrang).HasMaxLength(200);
            });

            modelBuilder.Entity<Dmvanban>(entity =>
            {
                entity.ToTable("DMVANBAN");

                entity.Property(e => e.MaVanBan).HasMaxLength(20);

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenVanBan).HasMaxLength(200);
            });

            modelBuilder.Entity<Duan>(entity =>
            {
                entity.ToTable("DUAN");

                entity.Property(e => e.DiaDiem).HasMaxLength(500);

                entity.Property(e => e.HinhThucSuDungDat).HasMaxLength(500);

                entity.Property(e => e.MaDuAn).HasMaxLength(50);

                entity.Property(e => e.TenDuAn).HasMaxLength(500);

                entity.Property(e => e.ViTri).HasMaxLength(500);
            });

            modelBuilder.Entity<DuanBuoc>(entity =>
            {
                entity.ToTable("DUAN_BUOC");

                entity.Property(e => e.IsKetThuc)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.PartialView).HasMaxLength(200);

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenBuoc).HasMaxLength(500);

                entity.Property(e => e.TrachNhiemThucHien).HasMaxLength(500);

                entity.HasOne(d => d.DuAn)
                    .WithMany(p => p.DuanBuocs)
                    .HasForeignKey(d => d.DuAnId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DUAN_BUOC_DUAN");
            });

            modelBuilder.Entity<DuanHoso>(entity =>
            {
                entity.ToTable("DUAN_HOSO");

                entity.Property(e => e.DonVi).HasMaxLength(200);

                entity.Property(e => e.DonViThucHien).HasMaxLength(200);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.NgayVanBan).HasColumnType("date");

                entity.Property(e => e.SoVanBan).HasMaxLength(50);

                entity.Property(e => e.TenCongViec).HasMaxLength(500);

                entity.Property(e => e.TrichYeu).HasMaxLength(200);

                entity.HasOne(d => d.DuAn)
                    .WithMany(p => p.DuanHosos)
                    .HasForeignKey(d => d.DuAnId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DUAN_HOSO_DUAN");
            });

            modelBuilder.Entity<DuanQuatrinh>(entity =>
            {
                entity.ToTable("DUAN_QUATRINH");

                entity.Property(e => e.NoiDungXuLy).HasMaxLength(500);

                entity.HasOne(d => d.DuAn)
                    .WithMany(p => p.DuanQuatrinhs)
                    .HasForeignKey(d => d.DuAnId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DUAN_QUATRINH_DUAN");
            });

            modelBuilder.Entity<ECapdonvi>(entity =>
            {
                entity.HasKey(e => e.CapDonViId)
                    .HasName("PK__E_CAPHAN__2EED65036327A7D0")
                    .IsClustered(false);

                entity.ToTable("E_CAPDONVI");

                entity.Property(e => e.CapDonViId)
                    .ValueGeneratedNever()
                    .HasColumnName("CapDonViID");

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.TenCapDonVi).HasMaxLength(500);
            });

            modelBuilder.Entity<EDoituongboithuong>(entity =>
            {
                entity.HasKey(e => e.DoiTuongBoiThuongId);

                entity.ToTable("E_DOITUONGBOITHUONG");

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.TenDoiTuong).HasMaxLength(200);
            });

            modelBuilder.Entity<ELoaidonvi>(entity =>
            {
                entity.HasKey(e => e.LoaiDonViId)
                    .HasName("PK__E_LOAIDO__46535E04410C22A9")
                    .IsClustered(false);

                entity.ToTable("E_LOAIDONVI");

                entity.Property(e => e.LoaiDonViId).HasColumnName("LoaiDonViID");

                entity.Property(e => e.MoTa).HasMaxLength(4000);

                entity.Property(e => e.TenLoaiDonVi).HasMaxLength(500);
            });

            modelBuilder.Entity<EPartilal>(entity =>
            {
                entity.ToTable("E_PARTILAL");

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.PartialCode).HasMaxLength(100);

                entity.Property(e => e.PartialName).HasMaxLength(200);
            });

            modelBuilder.Entity<Khokhan>(entity =>
            {
                entity.ToTable("KHOKHAN");

                entity.HasIndex(e => e.DuAnId, "IX_KHOKHAN_DuAnId");

                entity.Property(e => e.NgayBaoCao).HasColumnType("date");

                entity.HasOne(d => d.DuAn)
                    .WithMany(p => p.Khokhans)
                    .HasForeignKey(d => d.DuAnId);
            });

            modelBuilder.Entity<MucDichSuDung>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MucDichSuDung");

                entity.Property(e => e.GiaTri).HasMaxLength(150);

                entity.Property(e => e.Ma).HasMaxLength(3);
            });

            modelBuilder.Entity<Tepdinhkem>(entity =>
            {
                entity.ToTable("TEPDINHKEM");

                entity.Property(e => e.FileName).HasMaxLength(500);

                entity.Property(e => e.OriginalName).HasMaxLength(500);

                entity.Property(e => e.Path).HasMaxLength(500);

                entity.Property(e => e.Type).HasMaxLength(100);
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.ToTable("USER_MASTER");

                entity.HasIndex(e => new { e.DonViId, e.UserPortalId, e.Used }, "IDX_USER_MASTER_01");

                entity.HasIndex(e => e.UserPortalId, "IDX_USER_MASTER_02");

                entity.HasIndex(e => new { e.PhongBanId, e.DonViId, e.UserPortalId }, "IDX_USER_MASTER_03");

                entity.HasIndex(e => new { e.DonViId, e.UserPortalId }, "IDX_USER_MASTER_04");

                entity.HasIndex(e => e.UserPortalId, "IDX_USER_MASTER_05");

                entity.HasIndex(e => e.DonViId, "IDX_USER_MASTER_06");

                entity.HasIndex(e => new { e.DonViId, e.UserPortalId }, "IDX_USER_MASTER_07");

                entity.Property(e => e.UserMasterId).HasColumnName("User_MasterID");

                entity.Property(e => e.CanBoId).HasColumnName("CanBoID");

                entity.Property(e => e.DonViId).HasColumnName("DonViID");

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.PhongBanId).HasColumnName("PhongBanID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPortalId).HasColumnName("User_PortalID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public override int SaveChanges()
        {
            EntityStageModifier();
            return base.SaveChanges();
        }



        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            EntityStageModifier();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void EntityStageModifier()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                //var entity = entry.Entity.GetType().Name;
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.CurrentValues["CreatedDate"] = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.CurrentValues["UpdatedDate"] = DateTime.Now;
                        break;
                        //case EntityState.Deleted:
                        //    entry.State = EntityState.Modified;
                        //    entry.CurrentValues["isDeleted"] = true;
                        //    entry.CurrentValues["DateDeleted"] = DateTime.Now;
                        //    break;
                }
            }
        }

    }
}
