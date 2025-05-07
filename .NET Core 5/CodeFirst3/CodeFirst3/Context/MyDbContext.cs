using CodeFirst3.Configurations;
using CodeFirst3.Initializer;
using CodeFirst3.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst3.Context
{
    public class MyDbContext:DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options):base(options) {
            

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
           
          
            modelBuilder.ApplyConfiguration(new OperationConfiguration());

            modelBuilder.ApplyConfiguration(new AuthorConfiguration());


            modelBuilder.ApplyConfiguration(new StudentConfiguration());

            modelBuilder.ApplyConfiguration(new BookConfiguration());



            DataInitializer.Seed(modelBuilder);
            

        }



        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<BookType> BookTypes { get; set; }

        public DbSet<Operation> Operations { get; set; }

        public DbSet<AppUser> Users { get; set; }
    }
}
