using CarRental.Data;
using CarRental.Data.Abstracts;
using CarRental.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
namespace CarInsertData
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var constr = "Data Source=.;Initial Catalog=CarRentalAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            var option = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(constr);
            var DbContext = new ApplicationDbContext(option.Options);

            List<CarRental.Data.Models.Entities.Color> colors = DbContext.Colors.ToList();
            List<Branch> branches = DbContext.Branches.ToList();
            var random = new Random();

            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var relativePath = @"..\..\..\Cars To Be Inserted";
            var path = Path.Combine(currentDirectory, relativePath);

            var relativeSavePath = @"..\..\..\DbImages";
            var SavePath = Path.Combine(currentDirectory, relativeSavePath);
            Directory.CreateDirectory(SavePath);
            
            if (Directory.Exists(path))
            {
                foreach (var modelsPath in Directory.GetDirectories(path))
                {
                    foreach (var carsPath in Directory.GetDirectories(modelsPath))
                    {
                        foreach (var sPath in Directory.GetDirectories(carsPath))
                        {
                            var Car = new Car();
                            var imagesFiles = Directory.GetFiles(sPath, "*.jpg");
                            var infoFile = Directory.GetFiles(sPath, "*.txt")[0];
                            var sp = File.ReadAllText(infoFile).Split(',');

                            Car.FuelUsage = double.Parse(sp[10]);
                            Car.IsAutomatic = sp[9] == "true";
                            Car.IsElectric = sp[8] == "true";
                            Car.Seats = int.Parse(sp[7]);
                            Car.ModelYear = int.Parse(sp[6]);
                            Car.DailyPrice = int.Parse(sp[5]);
                            Car.Size = (CarSize)int.Parse(sp[4]);

                            var color = colors.FirstOrDefault(c => c.Name.ToLower() == sp[3].ToLower());
                            if (color == null)
                            {
                                color = new CarRental.Data.Models.Entities.Color()
                                {
                                    Name = sp[3].ToLower()
                                };
                                DbContext.Colors.Add(color);
                                DbContext.SaveChanges();
                            }
                            Car.ColorId = color.Id;

                            var brand = DbContext.Brands.Include(x => x.Models).FirstOrDefault(c => c.Name.ToLower() == sp[1].ToLower());
                            if (brand == null)
                            {
                                brand = new Brand()
                                {
                                    Name = sp[1]
                                };
                                DbContext.Brands.Add(brand);
                                DbContext.SaveChanges();
                            }

                            var model = brand.Models?.Where(x => x.Name.ToLower() == sp[2].ToLower()).FirstOrDefault();
                            if (model == null)
                            {
                                model = new Model()
                                {
                                    BrandId = brand.Id,
                                    Name = sp[2]
                                };
                                DbContext.Models.Add(model);
                                DbContext.SaveChanges();
                            }
                            Car.BrandId = brand.Id;
                            Car.BranchId = branches[random.Next(0, branches.Count - 1)].Id;

                            Car.ModelId = model.Id;
                            Car.Name = sp[0];
                            DbContext.Cars.Add(Car);
                            DbContext.SaveChanges();

                            foreach (var file in imagesFiles)
                            {
                                if (random == null)
                                {
                                    random = new Random();
                                }
                                var RandomName = random.GenerateRandomString(20);
                                var carImage = new CarImage()
                                {
                                    Path = RandomName,
                                    CarId = Car.Id
                                };
                                File.Copy(file, Path.Combine(SavePath, RandomName));

                                DbContext.CarImages.Add(carImage);
                            }
                            DbContext.SaveChanges();
                        }

                    }
                }
                var users = DbContext.Users.ToList();
            }
            else
            {
                Console.WriteLine("Directory 'Cars To Be Inserted' does not exist.");
            }
        }

        public static string GenerateRandomString(this Random str, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[str.Next(s.Length)]).ToArray());
        }
    }
}