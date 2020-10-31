using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<GameResponse> Get()
        {
            var game = new GameResponse
            {
                Name = "Dark Souls",
                Platform = "Multiplataforma",
                Price = 150
            };
            return new List<GameResponse>{game};
        }
    }
}
