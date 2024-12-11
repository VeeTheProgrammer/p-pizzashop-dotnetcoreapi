using Microsoft.AspNetCore.Mvc;

namespace PizzaShop.Api.Controllers
{
    public class PingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
