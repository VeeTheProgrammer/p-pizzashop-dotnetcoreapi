using Microsoft.AspNetCore.Mvc;

namespace PizzaShop.Api.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
