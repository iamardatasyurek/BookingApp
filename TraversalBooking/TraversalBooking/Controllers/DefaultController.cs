using Microsoft.AspNetCore.Mvc;

namespace TraversalBooking.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
