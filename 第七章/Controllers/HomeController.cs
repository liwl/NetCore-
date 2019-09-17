using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using 第七章.Filters;
using 第七章.Models;

namespace 第七章.Controllers
{
    [AddHeader("liwl","字节")]
    public class HomeController : Controller
    {
        private readonly AppSetting _appSetting;

        public HomeController(IOptions<AppSetting> settingOptions)
        {
            _appSetting = settingOptions.Value;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = _appSetting.Key1;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
