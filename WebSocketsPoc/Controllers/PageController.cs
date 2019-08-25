using Microsoft.AspNetCore.Mvc;

namespace WebSocketsPoc.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
