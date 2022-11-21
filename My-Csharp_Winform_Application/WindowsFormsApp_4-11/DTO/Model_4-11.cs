using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp_4_11.DTO
{
    public partial class Model_4_11 : DbContext
    {
        public Model_4_11()
            : base("name=Model_4_11")
        {
        }

        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NSX> NSXes { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>()
                .Property(e => e.TongTien)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Gia)
                .IsFixedLength();
        }
    }
}
