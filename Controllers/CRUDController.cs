using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OperationDigger.Models;

namespace OperationDigger.Controllers
{
    public class CRUDController : Controller
    {
        private readonly ebdbContext _context;

        public CRUDController(ebdbContext context)
        {
            _context = context;
        }

        // GET: CRUD
        public async Task<IActionResult> Index()
        {
            return View(await _context.Burials.ToListAsync());
        }

        // GET: CRUD/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.Burials
                .FirstOrDefaultAsync(m => m.BurialId == id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // GET: CRUD/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CRUD/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BurialId,LocationId,BurialNs,LowNs,HighNs,BurialEw,LowEw,HighEw,BurialSubplot,BurialNum,Gender,HairColor,YearExc,MonthExc,DayExc,HeadDirection,PostcraniaTrauma,YrSkull,MtSkull,DSkull,FieldBook,FieldBookPgnum,DexInitials,DecInitials,ByuSample,BodyAnalysis,SkullMag,PostcraniaMag,SexSkull,AgeSkull,RackShelf,SkullTrauma,CribraOrbitala,PoroticHyperostosis,PoroticHyperostosisLoc,MetopicSuture,ButtonOsteoma,OsteologyUnknownComment,TemporalMandibularJointOsteoarthritis,LinearHypoplasiaEnamel,HillBurialsA,Tomb,WestToHead,WestToFeet,BurialPreservation,BurialWrapping,BurialAc,BurialGendMeth,AgeCode,BurialAgeDeath,BurialAgeMeth,BurialHc,BurialSt,LenM,LenCm,Cluster,FaceBundle,OsteologyNotes,BurialDepth,SouthToHead,SouthToFeet,Length,AritifactFound,AritifactFoundDesc,AritifactFound2,BurialSituation,SampleNumber,GenderGe,GeFunction,BasliarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,BoneLength,MedialClavicle,IliacCrest,FemurDiameter,Humerus,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,PreservationIndex,DescriptionOfTaken,EstimateAge,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies,EpiphysealUnion,HairTaken,SoftTissueTaken,BoneTaken,ToothTaken,TextileTaken,Notes")] Burial burial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(burial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(burial);
        }

        // GET: CRUD/Edit/5
        public async Task<IActionResult> Edit(int? id)
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

        // POST: CRUD/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BurialId,LocationId,BurialNs,LowNs,HighNs,BurialEw,LowEw,HighEw,BurialSubplot,BurialNum,Gender,HairColor,YearExc,MonthExc,DayExc,HeadDirection,PostcraniaTrauma,YrSkull,MtSkull,DSkull,FieldBook,FieldBookPgnum,DexInitials,DecInitials,ByuSample,BodyAnalysis,SkullMag,PostcraniaMag,SexSkull,AgeSkull,RackShelf,SkullTrauma,CribraOrbitala,PoroticHyperostosis,PoroticHyperostosisLoc,MetopicSuture,ButtonOsteoma,OsteologyUnknownComment,TemporalMandibularJointOsteoarthritis,LinearHypoplasiaEnamel,HillBurialsA,Tomb,WestToHead,WestToFeet,BurialPreservation,BurialWrapping,BurialAc,BurialGendMeth,AgeCode,BurialAgeDeath,BurialAgeMeth,BurialHc,BurialSt,LenM,LenCm,Cluster,FaceBundle,OsteologyNotes,BurialDepth,SouthToHead,SouthToFeet,Length,AritifactFound,AritifactFoundDesc,AritifactFound2,BurialSituation,SampleNumber,GenderGe,GeFunction,BasliarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,BoneLength,MedialClavicle,IliacCrest,FemurDiameter,Humerus,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,PreservationIndex,DescriptionOfTaken,EstimateAge,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies,EpiphysealUnion,HairTaken,SoftTissueTaken,BoneTaken,ToothTaken,TextileTaken,Notes")] Burial burial)
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
                catch (DbUpdateConcurrencyException)
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
                return RedirectToAction(nameof(Index));
            }
            return View(burial);
        }

        // GET: CRUD/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.Burials
                .FirstOrDefaultAsync(m => m.BurialId == id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // POST: CRUD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var burial = await _context.Burials.FindAsync(id);
            _context.Burials.Remove(burial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BurialExists(int id)
        {
            return _context.Burials.Any(e => e.BurialId == id);
        }
    }
}
