using Microsoft.AspNet.Identity.EntityFramework;
using QuanLyThietBi.Model.Models;
using System.Data.Entity;

namespace QuanLyThietBi.Data
{
    public class QuanLyThietBiDbContext : DbContext
    {
        public QuanLyThietBiDbContext() : base("QuanLyThietBiConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Category> Categories { set; get; }
        public DbSet<Delivery> ProductCategories { set; get; }
        public DbSet<DeliveryDetail> DeliveryDetails { set; get; }
        public DbSet<Department> Departments { set; get; }
        public DbSet<Device> Devices { set; get; }
        public DbSet<Provider> Providers { set; get; }
        public DbSet<Receipt> Receipts { set; get; }
        public DbSet<ReceiptDetail> ReceiptDetails { set; get; }
        public DbSet<Status> Statuses { set; get; }
        public DbSet<Unit> Units { set; get; }
        public DbSet<Role> Roles { set; get; }
        public DbSet<User> Users { set; get; }

        public static QuanLyThietBiDbContext Create()
        {
            return new QuanLyThietBiDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId }).ToTable("ApplicationUserRoles");
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId).ToTable("ApplicationUserLogins");
            builder.Entity<IdentityUserClaim>().HasKey(i => i.UserId).ToTable("ApplicationUserClaims");
        }
    }
}
