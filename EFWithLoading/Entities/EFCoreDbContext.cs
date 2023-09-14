using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFWithLoading.Entities
{
    //public class EFCoreDbContext : DbContext
    //{
    //    //Constructor calling the Base DbContext Class Constructor
    //    public EFCoreDbContext() : base()
    //    {
    //    }

    //    //OnConfiguring() method is used to select and configure the data source
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        //To Display the Generated the Database Script
    //        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

    //        //Configuring the Connection String
    //        optionsBuilder.UseSqlServer(@"Server=NIT-LPT-R339;Database=EFCoreDB1;Trusted_Connection=True;TrustServerCertificate=True;");
    //    }

    //    //OnModelCreating() method is used to configure the model using ModelBuilder Fluent API
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        //Use this to configure the model using Fluent API
    //    }

    //    //Adding Domain Classes as DbSet Properties
    //    public virtual DbSet<Course> Courses { get; set; }

    //    public virtual DbSet<Standard> Standards { get; set; }

    //    public virtual DbSet<Student> Students { get; set; }

    //    public virtual DbSet<StudentAddress> StudentAddresses { get; set; }

    //    public virtual DbSet<Teacher> Teachers { get; set; }
    //}


    public class EFCoreDbContext : DbContext
    {
        //Constructor calling the Base DbContext Class Constructor
        public EFCoreDbContext() : base()
        {
            //Disabling Lazy Loading
            this.ChangeTracker.LazyLoadingEnabled = false;
        }
        //OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //To Display the Generated the Database Script
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            //Configuring the Connection String
            optionsBuilder.UseSqlServer(@"Server=NIT-LPT-R339;Database=EFCoreDB1;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        //OnModelCreating() method is used to configure the model using ModelBuilder Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Use this to configure the model using Fluent API
        }
        //Adding Domain Classes as DbSet Properties
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAddress> StudentAddresses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}
