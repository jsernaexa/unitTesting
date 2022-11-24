using DemoUnitTest.ApiServices;
using DemoUnitTest.ServiceModel;
using DemoUnitTest.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoUnitTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly ICatService _catService;

        public CatsController(ICatService catService)
        {
            this._catService = catService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int maxLength)
        {
            var catFact =  await _catService.GetCatFact(maxLength);
            if (catFact == null) return NotFound("No facts with this length!");
            return Ok(catFact);
        }
    }
}
