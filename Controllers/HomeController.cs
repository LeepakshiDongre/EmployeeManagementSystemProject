using System.Diagnostics;
using EmployeeManagementSystemProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystemProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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


        // GET: /Home/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Home/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                HttpContext.Session.SetString("IsAdmin", "true");
                return RedirectToAction("Index", "Employees");
            }

            ViewBag.Error = "Invalid login.";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // Ends session
            return RedirectToAction("Login"); // Redirects back to Login page
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
