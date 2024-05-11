using CarRental.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Data.Configurations
{
    public class ColorSeedConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            var Colors = new Color[] 
            {
                new() {Name = "White",Id = 1},
                new() {Name = "Black", Id = 2},
                new() {Name = "Gray", Id = 3},
                new() {Name = "Silver", Id = 4},
                new() {Name = "Blue", Id = 5},
                new() {Name = "Brown", Id = 6},
                new() {Name = "Green", Id = 7},
                new() {Name = "Orange", Id = 8},
                new() {Name = "Beige", Id = 9},
            };
            builder.HasData(Colors);
        }
    }
}
