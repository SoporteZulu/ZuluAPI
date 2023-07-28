using Microsoft.AspNetCore.Mvc;
using Zulu.API.Models;

namespace Zulu.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {
        private readonly ILogger<StockController> _logger;

        public StockController(ILogger<StockController> logger)
        {
            _logger = logger;
        }
               

        [HttpPost()]
        public ActionResult Post(List<AjusteStock> AjusteStock)
        {
            try
            {
                new DAL.Stock().Ajustar(AjusteStock);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}