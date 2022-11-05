using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Finally_project.Database.Models;

namespace Finally_project.Database.Maps
{
    internal class DonHangNhapMap : EntityTypeConfiguration<DonHangNhap>
    {
        public DonHangNhapMap()
        {
            Property(e => e.MaDHN)
                 .IsUnicode(false);

            Property(e => e.MaNCC)
                .IsUnicode(false);

            Property(e => e.MaNV)
                .IsUnicode(false);

            Property(e => e.NgayLap)
                .IsUnicode(false);

        }
    }
}
