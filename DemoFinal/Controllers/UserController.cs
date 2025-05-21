using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {      
        private readonly UserService _userService;
        //Inyeccion para poder usar aca el service
        public UserController(UserService userService)
            //Constructor MIN 29 explica para que la iny
        {
            _userService = userService;
        }

        [HttpGet("{name}")]
        public IActionResult GetByName( string name )
        {
            return Ok(_userService.Get(name));
        } //MIrar otra vez el Action result

    }
}
