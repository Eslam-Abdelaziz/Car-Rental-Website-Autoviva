using CarRental.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.DTO.Entities
{
    public class BrandDtoEx
    {
        public string Name { get; set; }

        public List<ModelDto> Models { get; set; }

        public BrandDtoEx(Brand brand)
        {
            Name = brand.Name;
            Models = new List<ModelDto>();
            foreach (var model in brand.Models)
            {
                Models.Add(new ModelDto(model));
            }
        }
    }
}
