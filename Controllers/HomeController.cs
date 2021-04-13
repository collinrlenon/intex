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
        public IActionResult BurialList(long? burialId, string gender, string hairColor, int? yearExc, string monthExc, string headDir, string fieldBook, string byuSamp, string skullMag, string sexSkull, string ageSkull, decimal? wtHead, decimal? wtFeet, string burialPres, string burialWrap, string gendMeth, string ageCode, string faceBundle, decimal? burDepth, decimal? stHead, decimal? stFeet, int? Length, string genGe, string searchBox, int pageNum = 1)
        {
            // Sets the page size to 50
            int pageSize = 50;

            var BurialListView = new BurialListViewModel
            {
                Burials = _context.Burials
                    .Where(x => x.BurialId == burialId || burialId == null)
                    .Where(x => x.Gender == gender || gender == null)
                    .Where(x => x.HairColor == hairColor || hairColor == null)
                    .Where(x => x.YearExc == yearExc || yearExc == null)
                    .Where(x => x.MonthExc == monthExc || monthExc == null)
                    .Where(x => x.HeadDirection == headDir || headDir == null)
                    .Where(x => x.FieldBook == fieldBook || fieldBook == null)
                    .Where(x => x.ByuSample == byuSamp || byuSamp == null)
                    .Where(x => x.SkullMag == skullMag || skullMag == null)
                    .Where(x => x.SexSkull == sexSkull || sexSkull == null)
                    .Where(x => x.AgeSkull == ageSkull || ageSkull == null)
                    .Where(x => x.WestToHead == wtHead || wtHead == null)
                    .Where(x => x.WestToFeet == wtFeet || wtFeet == null)
                    .Where(x => x.BurialPreservation == burialPres || burialPres == null)
                    .Where(x => x.BurialWrapping == burialWrap || burialWrap == null)
                    .Where(x => x.BurialGendMeth == gendMeth || gendMeth == null)
                    .Where(x => x.AgeCode == ageCode || ageCode == null)
                    .Where(x => x.FaceBundle == faceBundle || faceBundle == null)
                    .Where(x => x.BurialDepth == burDepth || burDepth == null)
                    .Where(x => x.SouthToHead == stHead || stHead == null)
                    .Where(x => x.SouthToFeet == stFeet || stFeet == null)
                    .Where(x => x.Length == Length || Length == null)
                    .Where(x => x.GenderGe == genGe || genGe == null)
                    .Where(x => x.Notes.Contains(searchBox) || x.OsteologyNotes.Contains(searchBox) || x.BurialSituation.Contains(searchBox) || searchBox == null)
                    .OrderByDescending(x => x.BurialId)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .ToList(),
                BioSamples = _context.BioSamples
                    .Where(x => x.LocationId == _context.Burials.Select(x => x.LocationId).ToString())
                    .Where(x => x.Notes.Contains(searchBox) || searchBox == null),
                Cranials = _context.Cranials
                    .Where(x => x.LocationId == _context.Burials.Select(x => x.LocationId).ToString())
                    .Where(x => x.BurialArtDescription.Contains(searchBox) || searchBox == null),
                CarbonDatings = _context.CarbonDatings
                    .Where(x => x.LocationId == _context.Burials.Select(x => x.LocationId).ToString())
                    .Where(x => x.Notes.Contains(searchBox) || searchBox == null),
                PageNumbering = new PageNumbering
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,
                    TotalItems = _context.Burials
                    .Where(x => x.BurialId == burialId || burialId == null)
                    .Where(x => x.Gender == gender || gender == null)
                    .Where(x => x.HairColor == hairColor || hairColor == null)
                    .Where(x => x.YearExc == yearExc || yearExc == null)
                    .Where(x => x.MonthExc == monthExc || monthExc == null)
                    .Where(x => x.HeadDirection == headDir || headDir == null)
                    .Where(x => x.FieldBook == fieldBook || fieldBook == null)
                    .Where(x => x.ByuSample == byuSamp || byuSamp == null)
                    .Where(x => x.SkullMag == skullMag || skullMag == null)
                    .Where(x => x.SexSkull == sexSkull || sexSkull == null)
                    .Where(x => x.AgeSkull == ageSkull || ageSkull == null)
                    .Where(x => x.WestToHead == wtHead || wtHead == null)
                    .Where(x => x.WestToFeet == wtFeet || wtFeet == null)
                    .Where(x => x.BurialPreservation == burialPres || burialPres == null)
                    .Where(x => x.BurialWrapping == burialWrap || burialWrap == null)
                    .Where(x => x.BurialGendMeth == gendMeth || gendMeth == null)
                    .Where(x => x.AgeCode == ageCode || ageCode == null)
                    .Where(x => x.FaceBundle == faceBundle || faceBundle == null)
                    .Where(x => x.BurialDepth == burDepth || burDepth == null)
                    .Where(x => x.SouthToHead == stHead || stHead == null)
                    .Where(x => x.SouthToFeet == stFeet || stFeet == null)
                    .Where(x => x.Length == Length || Length == null)
                    .Where(x => x.GenderGe == genGe || genGe == null)
                    .Where(x => x.Notes.Contains(searchBox) || x.OsteologyNotes.Contains(searchBox) || x.BurialSituation.Contains(searchBox) || searchBox == null).Count()
                },
                Filters = new FilterViewModel
                {
                    gender = gender,
                    hairColor = hairColor,
                    yearExc = yearExc,
                    monthExc = monthExc,
                    headDir = headDir,
                    fieldBook = fieldBook,
                    byuSamp = byuSamp,
                    skullMag = skullMag,
                    sexSkull = sexSkull,
                    ageSkull = ageSkull,
                    wtHead = wtHead,
                    wtFeet = wtFeet,
                    burialPres = burialPres,
                    burialWrap = burialWrap,
                    gendMeth = gendMeth,
                    ageCode = ageCode,
                    faceBundle = faceBundle,
                    burDepth = burDepth,
                    stHead = stHead,
                    stFeet = stFeet,
                    Length = Length,
                    genGe = genGe
                },
                BurialId = (int?)burialId
            };

            return View(BurialListView);
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
