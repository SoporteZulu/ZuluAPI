using Microsoft.AspNetCore.Mvc;
using Zulu.API.Models;

namespace Zulu.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {

        private readonly ILogger<AuthController> _logger;

        /*incorporar logeo EN TOIDAS LAS CLASES!!!!!!*/

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }
               

        [HttpGet()]
        public ActionResult GetToken(string user, string pwd)
        {
            try
            {
                _logger.LogInformation("GetToken");

                var t = new DAL.Stock().GetItem("2234");

                return Ok(t);

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}