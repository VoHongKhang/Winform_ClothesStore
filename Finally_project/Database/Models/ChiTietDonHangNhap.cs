namespace Finally_project.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonHangNhap")]
    public partial class ChiTietDonHangNhap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDHN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSP { get; set; }

        public int? Soluong { get; set; }

        public virtual DonHangNhap DonHangNhap { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
