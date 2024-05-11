using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Data.Configurations
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();
            builder.HasData(
                 new User
                 {
                     Id = "408aa945-3d84-4421-8342-7269ec64d949",
                     Email = "admin@localhost.com",
                     NormalizedEmail = "ADMIN@LOCALHOST.COM",
                     NormalizedUserName = "ADMIN@LOCALHOST.COM",
                     UserName = "admin@localhost.com",
                     Firstname = "System",
                     Lastname = "Admin",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
				 new User
				 {
					 Id = "408aa945-3d84-4421-8541-7269ec64d938",
					 Email = "carioairport@localhost.com",
					 NormalizedEmail = "CARIOAIRPORT@LOCALHOST.COM",
					 NormalizedUserName = "CARIOAIRPORT@LOCALHOST.COM",
					 UserName = "carioairport@localhost.com",
					 Firstname = "Cairo Airport",
					 Lastname = "Branch",
					 PasswordHash = hasher.HashPassword(null, "P@ssword1"),
					 EmailConfirmed = true,
                     BranchId = 1,
				 },
                 new User
                 {
                     Id = "508aa945-3d84-4421-8541-7269ec64d938",
                     Email = "borgelarabairport@localhost.com",
                     NormalizedEmail = "BORGELARABAIRPORT@LOCALHOST.COM",
                     NormalizedUserName = "BORGELARABAIRPORT@LOCALHOST.COM",
                     UserName = "borgelarabairport@localhost.com",
                     Firstname = "Borg El Arab Airport",
                     Lastname = "Branch",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true,
                     BranchId = 2,
                 },
                 new User
                 {
                     Id = "608aa945-3d84-4421-8541-7269ec64d938",
                     Email = "mallofarabia@localhost.com",
                     NormalizedEmail = "MALLOFARABIA@LOCALHOST.COM",
                     NormalizedUserName = "MALLOFARABIA@LOCALHOST.COM",
                     UserName = "mallofarabia@localhost.com",
                     Firstname = "Mall of Arabia",
                     Lastname = "Branch",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true,
                     BranchId = 3
                 });
        }
    }
}

//Branch = 