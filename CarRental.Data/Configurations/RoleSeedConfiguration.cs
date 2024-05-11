using CarRental.Data.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Data.Configurations
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                    Name = Roles.Customer,
                    NormalizedName = Roles.Customer.ToUpper()
                },
				new IdentityRole
				{
					Id = "cac43a7e-f7cb-4148-baaf-1ab4435eacbf",
					Name = Roles.Branch,
					NormalizedName = Roles.Branch.ToUpper()
				}
			);
        }
    }
}
