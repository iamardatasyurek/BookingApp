using Microsoft.AspNetCore.Mvc;

namespace TraversalBooking.ViewComponents.Comment
{
    public class _AddComment : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
