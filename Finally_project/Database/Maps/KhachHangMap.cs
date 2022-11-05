using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Finally_project.Database.Models;

namespace Finally_project.Database.Maps
{
    internal class KhachHangMap : EntityTypeConfiguration<KhachHang>
    {
        public KhachHangMap()
        {

            Property(e => e.MaKH)
                .IsUnicode(false);

            Property(e => e.TenKH)
                .IsUnicode(false);

            Property(e => e.DiaChi)
                .IsUnicode(false);

            Property(e => e.DienThoai)
                .IsUnicode(false);

            HasMany(e => e.DonHangXuats)
                .WithOptional(e => e.KhachHang)
                .WillCascadeOnDelete();

        }
    }
}
