using Microsoft.AspNetCore.Mvc;

namespace PizzaShop.Api.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
