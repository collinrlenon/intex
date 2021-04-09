using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OperationDigger.Models;

namespace OperationDigger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ebdbContext _context;

        public HomeController(ILogger<HomeController> logger, ebdbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.CarbonDatings);
        }

        public IActionResult AddMummy()
        {
            return View();
        }

        public IActionResult AddNotes()
        {
            return View();
        }

        public IActionResult Burial()
        {
            return View();
        }

        public IActionResult BurialList()
        {
            return View();
        }

        public IActionResult BurialRecord()
        {
            return View();
        }

        public IActionResult ManageUsers()
        {
            return View();
        }

        public IActionResult UploadBooks()
        {
            return View();
        }

        public IActionResult UploadNotes()
        {
            return View();
        }

        public IActionResult UploadPhotos()
        {
            return View();
        }

        public IActionResult DeleteRecords()
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
