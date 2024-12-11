using Microsoft.AspNetCore.Mvc;

namespace PizzaShop.Api.Controllers
{
    public class OrderDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
