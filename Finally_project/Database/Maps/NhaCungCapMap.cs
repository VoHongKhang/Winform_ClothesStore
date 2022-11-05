using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Finally_project.Database.Models;

namespace Finally_project.Database.Maps
{
    internal class NhaCungCapMap :EntityTypeConfiguration<NhaCungCap>
    {
        public NhaCungCapMap()
        {
            Property(e => e.MaNCC)
                .IsUnicode(false);

            Property(e => e.TenNCC)
                .IsUnicode(false);

            Property(e => e.DiaChi)
                .IsUnicode(false);

            Property(e => e.DienThoai)
                .IsUnicode(false);

            HasMany(e => e.DonHangNhaps)
                .WithOptional(e => e.NhaCungCap)
                .WillCascadeOnDelete();
        }
    }
}
