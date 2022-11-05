using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Finally_project.Database.Models;

namespace Finally_project.Database.Maps
{
    internal class TaiKhoanMap : EntityTypeConfiguration<TaiKhoan>
    {
        public TaiKhoanMap()
        {
            Property(e => e.TenDN)
                .IsUnicode(false);

            Property(e => e.MatKhau)
                .IsUnicode(false);

            Property(e => e.MaNV)
                .IsUnicode(false);

            Property(e => e.LoaiTK)
                .IsUnicode(false);
        }
    }
}
