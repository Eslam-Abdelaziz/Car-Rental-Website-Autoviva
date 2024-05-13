using CarRental.Application.Contracts.Entities;
using CarRental.Data.Constants;
using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = Roles.AdminRoles, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet(), Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IList<Brand>> GetAsync() 
        {
			return await _brandService.GetBrands();
        }

        [HttpPut]
        public async Task<IActionResult> Edit(int id,string name) 
        {
            var brand = await _brandService.Get(id);
            if(brand == null) 
            {
                return NotFound();
            }
            brand.Name = name;
            await _brandService.Update(brand);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add(string name)
        {
            bool Exsit = await  _brandService.Exists(name);
            if (Exsit) 
            {
                return NotFound();
            }
            var b = new Brand()
            {
                Name = name
            };
            await _brandService.Add(b);
            return Ok();
        }
    }
}
