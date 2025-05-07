using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Context
{
    public class MyDbContext:DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=FIRATC\\SQLEXPRESS;database=BookStore;uid=sa;pwd=123");
        //    base.OnConfiguring(optionsBuilder);
        //}

        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().Ignore("ID");
            modelBuilder.Entity<OrderDetail>().HasKey("OrderID","ProductID");
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppUserDetail> UserDetails { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Product> Products { get; set; }

       
    }
}
