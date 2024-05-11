using AutoMapper;
using CarRental.Data.DTO;
using CarRental.Data.DTO.Entities;
using CarRental.Data.DTO.Requests;
using CarRental.Data.Models.Entities;

namespace CarRental.Data.Configurations
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {

			CreateMap<User, UserDto>().ReverseMap();

			CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Branch, BranchDto>().ReverseMap() ;
            CreateMap<Car, CarDto>().ReverseMap();
			CreateMap<Brand, BrandDto>().ReverseMap();
			CreateMap<Color, ColorDto>().ReverseMap();
			CreateMap<CarImage, CarImageDto>().ReverseMap();

			CreateMap<Car, CarCreateRequest>().ReverseMap();
			CreateMap<Car, CarEditRequest>().ReverseMap();
            CreateMap<Payment, PaymentDto>().ReverseMap();

            CreateMap<Rental, RentalDto>().ReverseMap();


        }
    }
}
