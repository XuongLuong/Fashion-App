namespace FormDangNhap.BH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonBan")]
    public partial class HoaDonBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDonBan()
        {
            ChiTietHDBans = new HashSet<ChiTietHDBan>();
        }

        [Key]
        [StringLength(50)]
        public string MaHoaDonBan { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNhanVien { get; set; }

        public DateTime NgayBan { get; set; }

        [Required]
        [StringLength(50)]
        public string MaKhach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDBan> ChiTietHDBans { get; set; }
    }
}
