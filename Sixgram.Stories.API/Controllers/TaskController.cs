using Microsoft.AspNetCore.Mvc;

namespace Sixgram.Stories.API.Controllers
{
    public class TaskController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}