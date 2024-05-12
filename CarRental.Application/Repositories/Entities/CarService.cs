using CarRental.Application.Contracts.Entities;
using CarRental.Data;
using CarRental.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Application.Repositories.Entities
{
	public class CarService : GenericRepository<Car>, ICarService
    {
        private readonly ApplicationDbContext dbContext;
        private const double DecayFactor = 0.8; // Adjust the decay factor as per your requirements

        public CarService(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

		public IQueryable<Car> GetAllCars()
		{
			return  dbContext.Cars.AsNoTracking();
		}

		public async Task<Car?> GetCar(int id)
		{
			return await dbContext.Cars.Include(x => x.CarImages)
				.Include(x=>x.Branch)
				.Include(x=>x.Color).FirstOrDefaultAsync(x=>x.Id == id);
		}

		//string? name ,int? modelYear,string? branch,string? brand
		public async Task<IList<Car>> GetCars(string? name, int? modelyear, int? brandid, int? branchid, int? colorid, int? size, int? seats, double? price, bool? isElectric, bool? IsAutomatic)
        {
			var q = dbContext.Cars.Include(x => x.Branch).Include(x => x.Brand)
				.Include(x=>x.Brand.Models)
                .Include(x => x.CarImages)
                .Include(x => x.Branch.Address).Include(x => x.Color)
				.Include(x=>x.Model).AsQueryable();
            
            
            if (name != null) 
            {
               q =  q.Where(x => x.Name.Contains(name));
            }

			if (modelyear != null)
			{
				q = q.Where(x => x.ModelYear == modelyear);
			}

            if(brandid != null) 
            {
				q = q.Where(x => x.Brand.Id == brandid);
            }

			if (branchid != null)
			{
				q = q.Where(x => x.Branch.Id == branchid);

			}
			if (colorid != null)
			{
				q = q.Where(x => x.Color.Id == colorid);
			}
			if (size != null)
			{
				q = q.Where(x => (int)x.Size == size);
			}
			if (seats != null)
			{
				q = q.Where(x => x.Seats == seats);
			}
			if (price != null)
			{
				decimal priceval = (decimal)price;
				q = q.Where(x => x.DailyPrice >= priceval);
			}
			if (isElectric != null)
			{
				q = q.Where(x => x.IsElectric == isElectric);
			}
            if (IsAutomatic != null)
            {
                q = q.Where(x => x.IsAutomatic == IsAutomatic);
            }
            return await q.Take(100).ToListAsync();
        }

		public async Task<int> TotalCars(int? branchid)
		{
			var query = dbContext.Cars.AsQueryable();
			if(branchid != null) 
			{
				query = query.Where(car => car.BranchId == branchid);
			}
			return await query.CountAsync();
		}
		public async Task AddFindexScore(Car car,double actionScore) 
		{
			AddFindexScoreInternal(car, actionScore);
            await dbContext.SaveChangesAsync();
        }
        public async Task AddFindexScore(IQueryable<Car> cars, double actionScore)
        {
			var listCars = await cars.ToListAsync();
            listCars.ForEach(c =>  AddFindexScoreInternal(c, actionScore));
			await dbContext.SaveChangesAsync();
        }
        private double CalculateWeightedScore(double currentScore, double actionScore, DateTime lastScoreDateTime)
        {
            // Calculate the time difference between the last score update and the current time
            TimeSpan timeDifference = DateTime.UtcNow - lastScoreDateTime;

            double weightedScore = actionScore;

            // Apply time-based decay
            weightedScore *= Math.Pow(DecayFactor, timeDifference.TotalDays);

            // Add the weighted score to the current score
            double newScore = currentScore + weightedScore;

            return newScore;
        }
        private void AddFindexScoreInternal(Car car, double actionScore)
        {
            car.FindexScore = CalculateWeightedScore(car.FindexScore, actionScore, car.LastFindexScore);
            car.LastFindexScore = DateTime.UtcNow;
            dbContext.Entry(car).State = EntityState.Modified;
        }


    }
}
