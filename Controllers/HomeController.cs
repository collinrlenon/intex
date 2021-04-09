using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OperationDigger.Models;
using OperationDigger.Models.ViewModels;

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

        public IActionResult Burial(long? burialId, int pageNum = 2) ///welp???
        {


            // Sets the page size to 5
            int pageSize = 5;
          

            //Uses the Burial view model 
            return View(new IndexViewModel
            {
                Burials = _context.Burials
                    .Where(x => x.BurialId == burialId || burialId == null)
                    .OrderBy(x => x.BurialId)
                    .Skip((pageNum - 1) * pageSize) //throws an error if I put the page to -1 need to revisit
                    .Take(pageSize)
                    .ToList(),
                PageNumbering = new PageNumbering
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,
                    TotalItems = burialId == null ? _context.Burials.Count() :
                        _context.Burials.Where(x => x.BurialId == burialId).Count()


                },

                BurialId = (int?)burialId
            });
            
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
