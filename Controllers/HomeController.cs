using System.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OperationDigger.Models;
using Microsoft.Extensions.Logging;
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
            return View();
        }

        public IActionResult AddNotes()
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

        // GET method for Burial List view
        public IActionResult BurialList(long? burialId, int pageNum = 1)
        {
            // Sets the page size to 50
            int pageSize = 50;

            return View(new BurialListViewModel
            {
                Burials = _context.Burials
                    .Where(x => x.BurialId == burialId || burialId == null)
                    .OrderByDescending(x => x.BurialId)
                    .Skip((pageNum - 1) * pageSize)
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

        // GET method for Burial Detail view
        public IActionResult BurialDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = _context.Burials.Find(id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // GET method for Create Burial view
        [HttpGet]
        public IActionResult CreateBurial()
        {
            return View();
        }

        // POST method for Create Burial view
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBurial(Burial burial)
        {
            if (ModelState.IsValid)
            {

                int currentID = burial.BurialId;

                _context.Add(burial);
                _context.SaveChanges();
                return RedirectToAction("BurialList");
            }
            return View(burial);
        }

        // GET method for Edit Burial view
        [HttpGet]
        public IActionResult EditBurial(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = _context.Burials.Find(id);
            if (burial == null)
            {
                return NotFound();
            }
            return View(burial);
        }

        // POST method for Edit Burial view
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditBurial(int id, Burial burial)
        {
            if (id != burial.BurialId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(burial);
                _context.SaveChanges();

                return RedirectToAction("BurialList");
            }
            return View(burial);
        }

        // GET method for Delete Burial view
        public IActionResult DeleteBurial(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = _context.Burials.Find(id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // POST method for Delete Burial view
        [HttpPost, ActionName("DeleteBurial")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBurialConfirmed(int id)
        {
            var burial = _context.Burials.Find(id);
            _context.Burials.Remove(burial);
            _context.SaveChanges();

            return RedirectToAction("BurialList");
        }

        private bool BurialExists(int id)
        {
            return _context.Burials.Any(e => e.BurialId == id);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
