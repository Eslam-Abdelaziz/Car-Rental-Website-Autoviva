using CarRental.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Data.Configurations
{
    public class AddressesSeedConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            var addresses = new Address[]
            {
                new(1, "Oruba Rd", "El Nozha", "Cairo Governorate", 11776, "01020304050")
                {
                    UserId = "408aa945-3d84-4421-8541-7269ec64d938",
                    BranchId = 1
                },
                new(2, "Airport Road", "Borg El Arab", "Alexandria Governorate", 21934, "01020304050")
                {
                    UserId = "508aa945-3d84-4421-8541-7269ec64d938",
                    BranchId = 2,
                },
                new(3, "Wahat Road", "6 Octobar", "Giza Governorate", 12566, "01020304050")
                {
                    UserId = "608aa945-3d84-4421-8541-7269ec64d938",
                    BranchId = 3,
                }
            };


            builder.HasData(addresses);

        }
    }
}
