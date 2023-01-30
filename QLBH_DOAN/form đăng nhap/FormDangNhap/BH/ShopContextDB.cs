using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FormDangNhap.BH
{
    public partial class ShopContextDB : DbContext
    {
        public ShopContextDB()
            : base("name=ShopContextDB")
        {
        }

        public virtual DbSet<ChatLieu> ChatLieus { get; set; }
        public virtual DbSet<ChiTietHDBan> ChiTietHDBans { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HoaDonBan> HoaDonBans { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatLieu>()
                .HasMany(e => e.HangHoas)
                .WithRequired(e => e.ChatLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.ChiTietHDBans)
                .WithRequired(e => e.HangHoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDonBan>()
                .HasMany(e => e.ChiTietHDBans)
                .WithRequired(e => e.HoaDonBan)
                .WillCascadeOnDelete(false);
        }
    }
}
