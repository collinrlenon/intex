using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        // GET: CRUD
        public IActionResult BurialList(long? burialId, int pageNum = 1)
        {
            // Sets the page size to 50
            int pageSize = 50;

            return View(new BurialListViewModel
            {
                Burials = _context.Burials
                    .Where(x => x.BurialId == burialId || burialId == null)
                    .OrderBy(x => x.BurialId)
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

        // GET: CRUD/BurialBurialDetails/5
        public async Task<IActionResult> BurialDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.Burials.FindAsync(id);
            //.FirstOrDefaultAsync(m => m.BurialId == id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // GET: CRUD/CreateBurial
        public IActionResult CreateBurial()
        {
            return View();
        }

        // POST: CRUD/CreateBurial
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBurial([Bind("BurialId,LocationId,BurialNs,LowNs,HighNs,BurialEw,LowEw,HighEw,BurialSubplot,BurialNum,Gender,HairColor,YearExc,MonthExc,DayExc,HeadDirection,PostcraniaTrauma,YrSkull,MtSkull,DSkull,FieldBook,FieldBookPgnum,DexInitials,DecInitials,ByuSample,BodyAnalysis,SkullMag,PostcraniaMag,SexSkull,AgeSkull,RackShelf,SkullTrauma,CribraOrbitala,PoroticHyperostosis,PoroticHyperostosisLoc,MetopicSuture,ButtonOsteoma,OsteologyUnknownComment,TemporalMandibularJointOsteoarthritis,LinearHypoplasiaEnamel,HillBurialsA,Tomb,WestToHead,WestToFeet,BurialPreservation,BurialWrapping,BurialAc,BurialGendMeth,AgeCode,BurialAgeDeath,BurialAgeMeth,BurialHc,BurialSt,LenM,LenCm,Cluster,FaceBundle,OsteologyNotes,BurialDepth,SouthToHead,SouthToFeet,Length,AritifactFound,AritifactFoundDesc,AritifactFound2,BurialSituation,SampleNumber,GenderGe,GeFunction,BasliarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,BoneLength,MedialClavicle,IliacCrest,FemurDiameter,Humerus,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,PreservationBurialList,DescriptionOfTaken,EstimateAge,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies,EpiphysealUnion,HairTaken,SoftTissueTaken,BoneTaken,ToothTaken,TextileTaken,Notes")] Burial burial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(burial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(BurialList));
            }
            return View(burial);
        }

        // GET: CRUD/EditBurial/5
        public async Task<IActionResult> EditBurial(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.Burials.FindAsync(id);
            if (burial == null)
            {
                return NotFound();
            }
            return View(burial);
        }

        // POST: CRUD/EditBurial/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBurial(int id, [Bind("BurialId,LocationId,BurialNs,LowNs,HighNs,BurialEw,LowEw,HighEw,BurialSubplot,BurialNum,Gender,HairColor,YearExc,MonthExc,DayExc,HeadDirection,PostcraniaTrauma,YrSkull,MtSkull,DSkull,FieldBook,FieldBookPgnum,DexInitials,DecInitials,ByuSample,BodyAnalysis,SkullMag,PostcraniaMag,SexSkull,AgeSkull,RackShelf,SkullTrauma,CribraOrbitala,PoroticHyperostosis,PoroticHyperostosisLoc,MetopicSuture,ButtonOsteoma,OsteologyUnknownComment,TemporalMandibularJointOsteoarthritis,LinearHypoplasiaEnamel,HillBurialsA,Tomb,WestToHead,WestToFeet,BurialPreservation,BurialWrapping,BurialAc,BurialGendMeth,AgeCode,BurialAgeDeath,BurialAgeMeth,BurialHc,BurialSt,LenM,LenCm,Cluster,FaceBundle,OsteologyNotes,BurialDepth,SouthToHead,SouthToFeet,Length,AritifactFound,AritifactFoundDesc,AritifactFound2,BurialSituation,SampleNumber,GenderGe,GeFunction,BasliarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,BoneLength,MedialClavicle,IliacCrest,FemurDiameter,Humerus,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,PreservationBurialList,DescriptionOfTaken,EstimateAge,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies,EpiphysealUnion,HairTaken,SoftTissueTaken,BoneTaken,ToothTaken,TextileTaken,Notes")] Burial burial)
        {
            if (id != burial.BurialId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(burial);
                    await _context.SaveChangesAsync();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException)
                {
                    if (!BurialExists(burial.BurialId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(BurialList));
            }
            return View(burial);
        }

        // GET: CRUD/DeleteBurial/5
        public async Task<IActionResult> DeleteBurial(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.Burials.FindAsync(id);
                //.FirstOrDefaultAsync(m => m.BurialId == id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // POST: CRUD/DeleteBurial/5
        [HttpPost, ActionName("DeleteBurial")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBurialConfirmed(int id)
        {
            var burial = await _context.Burials.FindAsync(id);
            _context.Burials.Remove(burial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BurialList));
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
