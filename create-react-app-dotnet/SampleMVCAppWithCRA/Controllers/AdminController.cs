using Microsoft.AspNetCore.Mvc;

namespace SampleMVCAppWithCRA.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
