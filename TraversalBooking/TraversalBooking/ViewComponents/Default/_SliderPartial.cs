using Microsoft.AspNetCore.Mvc;
namespace TraversalBooking.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
