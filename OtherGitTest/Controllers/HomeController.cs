using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OtherGitTest.Models;

namespace OtherGitTest.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
