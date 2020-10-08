using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc1.Models;

namespace mvc1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public DateTime FetchData()
        {
            return DateTime.Now;
        }

        public IActionResult RedirectionToGoogle()
        {
            return Redirect("https://google.com");
        }

        public IActionResult GetJSON()
        {
            return Json(new { Name = "Jakub", Surname = "Swierczek" });
        }

        private readonly ITestRepository _repository;

        public TestController(ITestRepository repository) { _repository = repository; }

        public IActionResult TestModel()
        {
            var model = _repository.GetItems();
            return View(model);
        }
    }
}
