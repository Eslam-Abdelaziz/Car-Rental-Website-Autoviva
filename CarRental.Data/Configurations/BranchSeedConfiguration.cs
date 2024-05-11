using CarRental.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Data.Configurations
{
    public class BranchSeedConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            var Branches = new List<Branch>();
            Branches.Add(new(1, "Cairo International Airport"));
            Branches.Add(new(2, "Borg El Arab International Airport"));
            Branches.Add(new(3, "Mall of Arabia"));
            builder.HasData(Branches);
        }
    }
}
