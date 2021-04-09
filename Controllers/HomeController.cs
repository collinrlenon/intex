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

        public IActionResult Burial(long? burialId, int pageNum = 1) ///welp???
        {


            // Sets the page size to 5
            int pageSize = 20;


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

[HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Burial b)
        {
            //Validate the model
            if (ModelState.IsValid)
            {
                _context.Burials.Add(b);
                _context.SaveChanges();

                return View("Home", _context.Burials);
            }
            //Show validation errors
            else
            {
                return View("Form");
            }
        }

        public static int statId;

        // //Sends data from list to the edit burials view
        // [HttpPost]
        // public IActionResult EditForm(int id)
        // {
        //     statId = id;
        //     return View("EditForm", new FormViewModel
        //     {
        //         Burials = _context.Burials.Single(x => x.BurialId == statId),
        //         Id = statId
        //     });
        // }

        // //Updates the list of burials
        // [HttpPost]
        // public IActionResult UpdateForm(FormViewModel model)
        // {
        //     //Validate the model
        //     if (ModelState.IsValid)
        //     {
        //         var quote = _context.Burials.Single(x => x.BurialId == statId);

        //         _context.Entry(quote).Property(x => x.BurialNs).CurrentValue = model.Burials.BurialNs;
        //         _context.Entry(quote).Property(x => x.EastToHead).CurrentValue = model.Burials.EastToHead;
        //         _context.Entry(quote).Property(x => x.AritifactFound2).CurrentValue = model.Burials.AritifactFound2;
        //         _context.Entry(quote).Property(x => x.LowNs).CurrentValue = model.Burials.LowNs;
        //         _context.Entry(quote).Property(x => x.EastToFeet).CurrentValue = model.Burials.EastToFeet;
        //         //_context.Entry(quote).Property(x => x.Photo).CurrentValue = model.Burials.Photo;
        //         _context.Entry(quote).Property(x => x.HighNs).CurrentValue = model.Burials.HighNs;
        //         _context.Entry(quote).Property(x => x.WestToHead).CurrentValue = model.Burials.WestToHead;
        //         _context.Entry(quote).Property(x => x.BurialEw).CurrentValue = model.Burials.BurialEw;
        //         _context.Entry(quote).Property(x => x.WestToFeet).CurrentValue = model.Burials.WestToFeet;
        //         _context.Entry(quote).Property(x => x.LowEw).CurrentValue = model.Burials.LowEw;
        //         _context.Entry(quote).Property(x => x.Length).CurrentValue = model.Burials.Length;
        //         _context.Entry(quote).Property(x => x.HighEw).CurrentValue = model.Burials.HighEw;
        //         _context.Entry(quote).Property(x => x.BurialDepth).CurrentValue = model.Burials.BurialDepth;
        //         _context.Entry(quote).Property(x => x.BurialSubplot).CurrentValue = model.Burials.BurialSubplot;
        //         _context.Entry(quote).Property(x => x.BurialNum).CurrentValue = model.Burials.BurialNum;

        //         _context.SaveChanges();

        //         return RedirectToAction("Index");
        //     }
        //     //Show validation errors
        //     else
        //     {
        //         return View("EditForm");
        //     }
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
