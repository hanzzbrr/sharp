using Microsoft.AspNetCore.Mvc;

namespace ajaxJquery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
