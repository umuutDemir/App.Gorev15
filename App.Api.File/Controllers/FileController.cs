using Microsoft.AspNetCore.Mvc;

namespace App.Api.File.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
