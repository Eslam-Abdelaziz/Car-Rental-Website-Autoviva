using CarRental.Application.Contracts.Entities;
using CarRental.Data.Constants;
using CarRental.Data.DTO;
using CarRental.Data.DTO.Requests;
using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = Roles.AdminRoles, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ModelController : ControllerBase
    {
        private readonly IModelService _modelService;

        private readonly IBrandService _brandService;
        public ModelController(IModelService modelService, IBrandService brandService)
        {
            _modelService = modelService;
            _brandService = brandService;
        }


        [HttpGet]
        public async Task<IActionResult> GetModelsAsync(int id)
        {
            if (ModelState.IsValid) 
            {
                return Ok(await _modelService.AsQueryable().Where(x => x.BrandId == id).ToArrayAsync());
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddModelReq req) 
        {
            if (ModelState.IsValid) 
            {
                var brand = await _brandService.Get(req.Id);
                if(brand == null) 
                {
                    return NotFound();
                }
                var model = new Model()
                {
                    BrandId = req.Id,
                    Name = req.Name,
                };
                await _modelService.Add(model);
                return Ok();
            }
            return NotFound();
        }
        [HttpPut]
        public async Task<IActionResult> EditModel(EditModelReq req)
        {
            if (ModelState.IsValid)
            {
                var brand = await _brandService.Get(req.BrandId);
                if (brand == null) 
                {
                    return NotFound();
                }
                var model = await _modelService.Get(req.Id);
                if (model == null) 
                {
                    return NotFound();
                }
                model.Name = req.Name;
                await _modelService.Update(model);
                return Ok();
            }
            return NotFound();
        }
    }
}
