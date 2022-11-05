using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Finally_project.Database.Models;

namespace Finally_project.Database.Maps
{
    internal class SanPhamMap : EntityTypeConfiguration<SanPham>
    {
        public SanPhamMap()
        {
            Property(e => e.MaSP)
                .IsUnicode(false);

            Property(e => e.TenSP)
                .IsUnicode(false);

            Property(e => e.TenLoaiSP)
                .IsUnicode(false);
            
        }
    }
}
