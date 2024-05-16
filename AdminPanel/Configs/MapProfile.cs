using AdminPanel.Models;
using AdminPanel.Models.Requests;
using AutoMapper;

namespace AdminPanel.Configs
{
	public class MapProfile : Profile
	{
		public MapProfile()
		{


			CreateMap<Car, CarCreateRequest>()
				.ForMember(dst => dst.ColorId, ops => ops.MapFrom(x => x.Color.Id))
				.ForMember(dst => dst.BranchId, ops => ops.MapFrom(x => x.Branch.Id))
				.ForMember(dst => dst.BrandId, ops => ops.MapFrom(x => x.Brand.Id))
                .ForMember(dst => dst.ModelId, ops => ops.MapFrom(x => x.Model.Id));

			CreateMap<Car, CarEditRequest>() 
				.ForMember(dst => dst.ColorId, ops => ops.MapFrom(x => x.Color.Id))
				.ForMember(dst => dst.BranchId, ops => ops.MapFrom(x => x.Branch.Id))
				.ForMember(dst => dst.BrandId, ops => ops.MapFrom(x => x.Brand.Id))
                .ForMember(dst => dst.ModelId, ops => ops.MapFrom(x => x.Model.Id));
		}
	}

}
