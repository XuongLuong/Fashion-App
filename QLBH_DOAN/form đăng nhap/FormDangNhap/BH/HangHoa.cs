namespace FormDangNhap.BH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangHoa")]
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            ChiTietHDBans = new HashSet<ChiTietHDBan>();
        }

        [Key]
        [StringLength(50)]
        public string MaHang { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHang { get; set; }

        [Required]
        [StringLength(50)]
        public string MaChatLieu { get; set; }

        public double GiaBan { get; set; }

        public virtual ChatLieu ChatLieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDBan> ChiTietHDBans { get; set; }
    }
}
