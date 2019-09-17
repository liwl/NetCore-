using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using 第八章.Models;

namespace 第八章.Controllers
{
    [FormatFilter]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET api/values
        [Route("api/[controller]/[action]/{id}.{format?}")]
        public Product GetById(int Id)
        {
            return new Product()
            {
                No = "00001",
                Name = "测试产品"
            };
        }


    }
}
