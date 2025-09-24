using Microsoft.AspNetCore.Mvc;
using RedLightGreenLight.Models;

namespace RedLightGreenLight.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student",
                DateOfBirth = new DateTime(1984,1,6)
            };
            return View(data);
        }
    }
}