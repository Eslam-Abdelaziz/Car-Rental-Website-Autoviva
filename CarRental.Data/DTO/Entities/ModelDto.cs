using CarRental.Data.Models.Entities;

namespace CarRental.Data.DTO.Entities
{
    public class ModelDto : BaseEntity
    {
        public ModelDto(Model model)
        {
            Name = model.Name;
            Id = model.Id;
        }
    }
}
