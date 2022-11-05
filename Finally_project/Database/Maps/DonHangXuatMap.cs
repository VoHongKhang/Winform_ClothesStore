using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Finally_project.Database.Models;

namespace Finally_project.Database.Maps
{
    internal class DonHangXuatMap : EntityTypeConfiguration<DonHangXuat>
    {
        public DonHangXuatMap()
        {
            Property(e => e.MaDHX)
                .IsUnicode(false);

            Property(e => e.MaKH)
                .IsUnicode(false);

            Property(e => e.MaNV)
                .IsUnicode(false);

            Property(e => e.NgayLap)
                .IsUnicode(false);

        }
    }
}
