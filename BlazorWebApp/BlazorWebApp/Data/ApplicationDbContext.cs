using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>()
                 .HasOne(a => a.UserProfile)
                 .WithOne()
                 .HasForeignKey<ApplicationUser>(a => a.UserProfileId);

            builder.Entity<ApplicationUser>()
                .HasOne(a => a.UserAddress)
                .WithOne()
                .HasForeignKey<ApplicationUser>(a => a.UserAddressId);
        }
    }
}
