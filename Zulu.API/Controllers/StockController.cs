using Microsoft.AspNetCore.Mvc;
using Zulu.API.Models;

namespace Zulu.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {
        private readonly ILogger<StockController> _logger;
        private readonly IConfiguration _config;

        public StockController(ILogger<StockController> logger,
                               IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
               

        [HttpPost()]
        public ActionResult Post(List<AjusteStock> AjusteStock)
        {
            try
            {
                string key = "5a2b2e4c-e683-482f-9abf-e0de126ebc79";


                if (AjusteStock == null)
                    return BadRequest();    

                /* valido las keys*/
                foreach (var item in AjusteStock)
                {
                    if (item.Key != key)
                        return BadRequest();
                }


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