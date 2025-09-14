using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Presentation.Controller;

namespace Presentation.Controllers
{
    public class TestController : CoreControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Test()
        {
            return Ok(200);
        }
    }
}
