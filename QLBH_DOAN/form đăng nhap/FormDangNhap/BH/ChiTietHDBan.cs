namespace FormDangNhap.BH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHDBan")]
    public partial class ChiTietHDBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCT { get; set; }

        [Required]
        [StringLength(50)]
        public string MaHoaDonBan { get; set; }

        [Required]
        [StringLength(50)]
        public string MaHang { get; set; }

        public double SoLuong { get; set; }

        public double ThanhTien { get; set; }

        public virtual HangHoa HangHoa { get; set; }

        public virtual HoaDonBan HoaDonBan { get; set; }
    }
}
