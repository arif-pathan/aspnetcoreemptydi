using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCEmptyDI.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
