using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace 第八章.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult("2222222222222");
        }
        [HttpGet]
        public ContentResult Get1()
        {
            return Content("2222222222");
        }

    }
}
