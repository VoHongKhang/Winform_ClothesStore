namespace Finally_project.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonHangXuat")]
    public partial class ChiTietDonHangXuat
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDHX { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSP { get; set; }

        public int? SoLuong { get; set; }

        public virtual DonHangXuat DonHangXuat { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
