using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Finally_project.Database.Models;
using Finally_project.Database.Maps;

namespace Finally_project.Database.CreateData
{
    public partial class ModelQuanLyCuaHangQuanAo : DbContext
    {
        public ModelQuanLyCuaHangQuanAo()
            : base("name=ModelQuanLyCuaHangQuanAo")
        {
        }

        public virtual DbSet<ChiTietDonHangNhap> ChiTietDonHangNhaps { get; set; }
        public virtual DbSet<ChiTietDonHangXuat> ChiTietDonHangXuats { get; set; }
        public virtual DbSet<DonHangNhap> DonHangNhaps { get; set; }
        public virtual DbSet<DonHangXuat> DonHangXuats { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ChiTietDonHangNhapMap());
            modelBuilder.Configurations.Add(new ChiTietDonHangXuatMap());
            modelBuilder.Configurations.Add(new DonHangNhapMap());
            modelBuilder.Configurations.Add(new DonHangXuatMap());
            modelBuilder.Configurations.Add(new KhachHangMap());
            modelBuilder.Configurations.Add(new NhaCungCapMap());
            modelBuilder.Configurations.Add(new NhanVienMap());
            modelBuilder.Configurations.Add(new SanPhamMap());
            modelBuilder.Configurations.Add(new TaiKhoanMap());
        }
    }
}
