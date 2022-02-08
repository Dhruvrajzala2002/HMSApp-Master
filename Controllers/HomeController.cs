using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HMSApp.Models;
using Microsoft.Extensions.Logging;
using HMSApp.DataAccessLayer;

namespace HMSApp.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Charges()
        {
            return View();
        }
       
        public IActionResult Visitor()
        {
            return View();
        }

        public IActionResult MessInfo()
        {
            return View();
        }

        public IActionResult Student()
        {
            return View();
        }
        public IActionResult RoomInfo()
        {
            return View();
        }

        public IActionResult AddNewStudent(StudentModel student)
        {
            var sdl = new StudentDataLayer();
            var result = sdl.StudentOperation(student, "INSERT");
            return View(student);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
