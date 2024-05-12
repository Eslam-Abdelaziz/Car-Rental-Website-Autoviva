using CarRental.Application.Contracts.Entities;
using CarRental.Application.Extenstions;
using CarRental.Data;
using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using static System.Net.Mime.MediaTypeNames;

namespace CarRental.Application.Repositories.Entities
{
    public class CarImageService : GenericRepository<CarImage>, ICarImageService
    {
        private string SavePath;
        private static Random? Random;
        public CarImageService(ApplicationDbContext dbContext) : base(dbContext)
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var relativePath = @"..\..\..\..\CarInsertData\DbImages";
            SavePath = Path.GetFullPath(Path.Combine(currentDirectory, relativePath));
            Directory.CreateDirectory(SavePath);
            Random = new Random();
        }

        public async Task DeleteImagesAsync(IEnumerable<CarImage> imgs)
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var relativePath = @"..\..\..\..\CarInsertData\DbImages";
            SavePath = Path.GetFullPath(Path.Combine(currentDirectory, relativePath));
            Directory.CreateDirectory(SavePath);

            foreach (var img in imgs)
            {
                var path = Path.Combine(SavePath, img.Path);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                await Delete(img);
            }
        }

        public async Task AddImagesAsync(int carid, IFormFileCollection files)
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var relativePath = @"..\..\..\..\CarInsertData\DbImages";
            SavePath = Path.GetFullPath(Path.Combine(currentDirectory, relativePath));
            Directory.CreateDirectory(SavePath);

            foreach (var file in files)
            {
                if (Random == null)
                {
                    Random = new Random();
                }
                var RandomName = Random.GenerateRandomString(20);
                var carImage = new CarImage()
                {
                    Path = RandomName,
                    CarId = carid
                };
                using (var stream = File.OpenWrite(Path.Combine(SavePath, RandomName)))
                {
                    await file.CopyToAsync(stream);
                }
                await Add(carImage);
            }

        }

        public async Task<IActionResult> ImageToResult(CarImage img)
        {
            string filePath = Path.Combine(SavePath, img.Path);
            if (!File.Exists(filePath))
            {
                return new NotFoundResult();
            }
            return new FileContentResult(await File.ReadAllBytesAsync(filePath), Image.Jpeg);
        }

        public async Task<IActionResult> GetCarImage(Car car, int imageid)
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var relativePath = @"..\..\..\..\CarInsertData\DbImages";
            SavePath = Path.GetFullPath(Path.Combine(currentDirectory, relativePath));
            Directory.CreateDirectory(SavePath);

            if (!car.CarImages.Any(x => x.Id == imageid))
            {
                return new NotFoundResult();
            }
            var img = await Get(imageid);
            if (img == null)
            {
                return new NotFoundResult();
            }

            string filePath = Path.Combine(SavePath, img.Path);
            if (!File.Exists(filePath))
            {
                return new NotFoundResult();
            }
            return new FileContentResult(await File.ReadAllBytesAsync(filePath), Image.Jpeg);

        }
    }
}
