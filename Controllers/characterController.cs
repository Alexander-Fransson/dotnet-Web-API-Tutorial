using Microsoft.AspNetCore.Mvc;
using dotnet_Web_API_Tutorial.Models;

namespace dotnet_Web_API_Tutorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class characterController: ControllerBase
    {
        private static Character typographer = new Character();

        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(typographer);
        }
    }
}