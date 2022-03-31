using Calculator_62010634.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Calculator_62010634.Controllers
{
    public class HomeController : Controller
    
    {
        [Produces("text/html")]
        public IActionResult Caculator(string numberinp)
        {
            string request = numberinp;
            string value = new DataTable().Compute(request, null).ToString();
            string msg = value;
            return Content(msg, "text/html", Encoding.UTF8);
        }  
        public IActionResult Index()
        {
            return View();
        }

    }
}
