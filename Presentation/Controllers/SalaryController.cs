using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
namespace Presentation.Controller
{

    public class SalaryController : CoreControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(200);
        }

    }
}
