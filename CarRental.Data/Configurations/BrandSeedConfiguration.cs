using CarRental.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Data.Configurations
{
    internal class BrandSeedConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            var Brands = new Brand[]
            {
                new (1,"Hyundai"),
                new (2,"Chevrolet"),
                new (3,"Toyota"),
                new (4,"Nissan"),
                new (5,"Kia"),
                new (6,"Mitsubishi"),
                new (7,"BMW"),
                new (8,"Mercedes-Benz"),
                new (9,"Renault"),
                new (10,"Chery"),
                new (11,"Geely"),
                new (12,"Peugeot"),
                new (13,"Fiat"),
                new (14,"Skoda"),
                new (15,"Suzuki"),
            };
            builder.HasData(Brands);
        }
    }
}
