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
    [Authorize(Roles = Roles.Administrator, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class ColorsController : ControllerBase
    {
        public IColorService _ColorService { get; set; }

        public ColorsController(IColorService colorService)
        {
            _ColorService = colorService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IList<Color>> Get()
        {
            return await _ColorService.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var c = await _ColorService.Get(id);
			if (c == null) 
            {
                return NotFound();
            }
            return  Ok(c);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task PostAsync(string name)
        {
            await _ColorService.Add(new Color() { Name = name });
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, string name)
        {
            var color = await _ColorService.Get(id);
            if(color == null) 
            {
                return NotFound();
            }
            color.Name = name;
            await _ColorService.Update(color);
            return Ok();
        }
    }
}
