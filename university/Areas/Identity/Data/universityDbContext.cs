using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using university.Areas.Identity.Data;
using university.Models;

namespace university.Areas.Identity.Data;

public class universityDbContext : IdentityDbContext<universityUser>
{
    public universityDbContext(DbContextOptions<universityDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new universityUserEntityConfiguration());
    }


    // Define DbSet properties for your models here
    public DbSet<Admin> Admins { get; set; }

    public DbSet<Subject> Subject { get; set; }
    public DbSet<Student> Students { get; set; }

    public DbSet<Room> Rooms { get; set; }
    public DbSet<Class> Classes { get; set; }

    public DbSet<User> Users { get; set; }

  /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Username = "admin", Password = "admin", Role = "Admin" },
            new User { Id = 2, Username = "student", Password = "student", Role = "Student" }
        );
    }
  */
}

internal class universityUserEntityConfiguration : IEntityTypeConfiguration<universityUser>
{
    public void Configure(EntityTypeBuilder<universityUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}


