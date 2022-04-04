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
            CalculatorModel result = new CalculatorModel();
            string request = numberinp;
            string value = new DataTable().Compute(request, null).ToString();
            result.ResultCalculator = value;
            return Content(result.ResultCalculator, "text/html", Encoding.UTF8);
        }  
        public IActionResult Index()
        {
            return View();
        }

    }
}
