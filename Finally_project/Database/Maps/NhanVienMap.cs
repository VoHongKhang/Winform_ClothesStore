using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Finally_project.Database.Models;

namespace Finally_project.Database.Maps
{
    internal class NhanVienMap :EntityTypeConfiguration<NhanVien>
    {
        public NhanVienMap()
        {
            Property(e => e.MaNV)
                .IsUnicode(false);

            Property(e => e.TenNV)
                .IsUnicode(false);

            Property(e => e.GioiTinh)
                .IsUnicode(false);

            Property(e => e.DiaChi)
                .IsUnicode(false);

            Property(e => e.DienThoai)
                .IsUnicode(false);

            HasMany(e => e.DonHangNhaps)
                .WithOptional(e => e.NhanVien)
                .WillCascadeOnDelete();

            HasMany(e => e.DonHangXuats)
                .WithOptional(e => e.NhanVien)
                .WillCascadeOnDelete();

            HasMany(e => e.TaiKhoans)
                .WithOptional(e => e.NhanVien)
                .WillCascadeOnDelete();
        }
    }
}
