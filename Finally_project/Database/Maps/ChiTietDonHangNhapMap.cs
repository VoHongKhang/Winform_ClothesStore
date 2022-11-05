using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Finally_project.Database.Models;

namespace Finally_project.Database.Maps
{
    internal class ChiTietDonHangNhapMap  : EntityTypeConfiguration<ChiTietDonHangNhap>
    {
        public ChiTietDonHangNhapMap()
        {
            Property(e => e.MaDHN)
                .IsUnicode(false);
          
             Property(e => e.MaSP)
                .IsUnicode(false);
        }
    }
}
