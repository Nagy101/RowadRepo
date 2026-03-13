using System.Diagnostics;
using AssiMVCDay01.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssiMVCDay01.Controllers
{
    public class HomeController : Controller
    {
        public string ShowMsg01() { 
            return "Hello Rowad";
        }

        public ContentResult ShowMsg02()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hello Rowad";
            return result;
        }

        public ViewResult ShowView()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "View01";
            return result;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
