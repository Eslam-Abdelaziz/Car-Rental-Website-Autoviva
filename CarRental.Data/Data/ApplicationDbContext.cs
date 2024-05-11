using CarRental.Data.Configurations;
using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {


             builder.Entity<Branch>()
            .HasOne(e => e.Address)
            .WithOne(e => e.Branch)
            .HasForeignKey<Address>("BranchId")
            .IsRequired(false);
			builder.Entity<User>()
            .HasOne(e => e.Address)
            .WithOne(e => e.User)
            .HasForeignKey<Address>("UserId")
            .IsRequired(false);



            builder.Entity<Rental>()
            .HasOne(e => e.Payment)
            .WithOne(e => e.Rental)
            .HasForeignKey<Payment>(e=>e.RentalId)
            .IsRequired();


            builder.Entity<Branch>()
	        .HasMany(e => e.Cars)
	        .WithOne(e => e.Branch)
	        .HasForeignKey(e => e.BranchId)
	        .IsRequired();

            builder.Entity<Color>()
		    .HasMany(e => e.Cars)
		    .WithOne(e => e.Color)
		    .HasForeignKey(e => e.ColorId)
		    .IsRequired();

			builder.Entity<Brand>()
	        .HasMany(e => e.Cars)
	        .WithOne(e => e.Brand)
	        .HasForeignKey(e => e.BrandId)
	        .IsRequired();



            builder.Entity<Branch>()
            .HasMany(e => e.Users)
            .WithOne(e => e.Branch)
            .HasForeignKey(e => e.BranchId)
            .IsRequired(false);

            builder.Entity<User>()
            .HasMany(e => e.Rentals)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId)
            .IsRequired(true)
            .OnDelete(DeleteBehavior.Restrict);
           


			builder.Entity<Branch>()
			.HasMany(e => e.Rentals)
			.WithOne(e => e.ReturnBranch)
			.HasForeignKey(e => e.BranchId)
			.IsRequired(true)
            .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Rental>(r=> r.Property(x=>x.Id).ValueGeneratedOnAdd()
            .UseIdentityColumn(55005874,1));


            builder.Entity<Favourite>()
			   .HasKey(f => new { f.CarId, f.UserId });

			builder.Entity<Favourite>()
				.HasOne(f => f.Car)
				.WithMany()
				.HasForeignKey(f => f.CarId);

			builder.Entity<Favourite>()
				.HasOne(f => f.User)
				.WithMany(u => u.Favourites)
				.HasForeignKey(f => f.UserId);

	      builder.Entity<Brand>()
	      .HasMany(e => e.Models)
	      .WithOne(e => e.Brand)
	      .HasForeignKey(e => e.BrandId)
	      .IsRequired(false);

		builder.Entity<Car>()
	    .Property(c => c.DailyPrice)
	    .HasPrecision(18, 2); // Adjust the precision and scale as per your requirements
		    
			base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new ColorSeedConfiguration());
            builder.ApplyConfiguration(new BrandSeedConfiguration());
            builder.ApplyConfiguration(new BranchSeedConfiguration());
            builder.ApplyConfiguration(new AddressesSeedConfiguration());
        }
        public DbSet<Color> Colors { get; set; } 
        public DbSet<Branch> Branches { get; set; } 
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Car> Cars { get; set; }
		public DbSet<CarImage> CarImages { get; set; }

        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Model> Models { get; set; }

        public DbSet<Payment> Payments { get; set; }

    }
}