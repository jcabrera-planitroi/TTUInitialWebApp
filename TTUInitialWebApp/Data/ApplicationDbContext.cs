using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TTUInitialWebApp.Entities;

namespace TTUInitialWebApp.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<UserInformation> UserInformationData { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<UserInformation>()
            .Property(s => s.Id)
            .UseIdentityColumn()
            .IsRequired();
        
        builder.Entity<UserInformation>()
            .HasOne<ApplicationUser>(s => s.User)
            .WithMany(ad => ad.UserInformationCollection)
            .HasForeignKey(ad => ad.UserId);
        
        base.OnModelCreating(builder);
    }
}