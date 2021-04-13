using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OperationDigger.Models;

namespace OperationDigger.Components
{
    public class FilterViewComponent : ViewComponent
    {
        private ebdbContext _context;

        public FilterViewComponent(ebdbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Gender = _context.Burials.Where(x => x.Gender != null).Select(x => x.Gender).Distinct().ToList();
            ViewBag.HairColor = _context.Burials.Where(x => x.HairColor != null).Select(x => x.HairColor).Distinct().ToList();
            ViewBag.YearExc = _context.Burials.Where(x => x.YearExc != null).Select(x => x.YearExc).Distinct().ToList();
            ViewBag.MonthExc = _context.Burials.Where(x => x.MonthExc != null).Select(x => x.MonthExc).Distinct().ToList();
            ViewBag.HeadDir = _context.Burials.Where(x => x.HeadDirection != null).Select(x => x.HeadDirection).Distinct().ToList();
            ViewBag.FieldBook = _context.Burials.Where(x => x.FieldBook != null).Select(x => x.FieldBook).Distinct().ToList();
            ViewBag.ByuSample = _context.Burials.Where(x => x.ByuSample != null).Select(x => x.ByuSample).Distinct().ToList();
            ViewBag.SkullMag = _context.Burials.Where(x => x.SkullMag != null).Select(x => x.SkullMag).Distinct().ToList();
            ViewBag.SexSkull = _context.Burials.Where(x => x.SexSkull != null).Select(x => x.SexSkull).Distinct().ToList();
            ViewBag.AgeSkull = _context.Burials.Where(x => x.AgeSkull != null).Select(x => x.AgeSkull).Distinct().ToList();
            ViewBag.WtHead = _context.Burials.Where(x => x.WestToHead != null).Select(x => x.WestToHead).Distinct().ToList();
            ViewBag.WtFeet = _context.Burials.Where(x => x.WestToFeet != null).Select(x => x.WestToFeet).Distinct().ToList();
            ViewBag.BurialPres = _context.Burials.Where(x => x.BurialPreservation != null).Select(x => x.BurialPreservation).Distinct().ToList();
            ViewBag.BurialWrap = _context.Burials.Where(x => x.BurialWrapping != null).Select(x => x.BurialWrapping).Distinct().ToList();
            ViewBag.GendMeth = _context.Burials.Where(x => x.BurialGendMeth != null).Select(x => x.BurialGendMeth).Distinct().ToList();
            ViewBag.AgeCode = _context.Burials.Where(x => x.AgeCode != null).Select(x => x.AgeCode).Distinct().ToList();
            ViewBag.FaceBundle = _context.Burials.Where(x => x.FaceBundle != null).Select(x => x.FaceBundle).Distinct().ToList();
            ViewBag.BurDepth = _context.Burials.Where(x => x.BurialDepth != null).Select(x => x.BurialDepth).Distinct().ToList();
            ViewBag.StHead = _context.Burials.Where(x => x.SouthToHead != null).Select(x => x.SouthToHead).Distinct().ToList();
            ViewBag.StFeet = _context.Burials.Where(x => x.SouthToFeet != null).Select(x => x.SouthToFeet).Distinct().ToList();
            ViewBag.Length = _context.Burials.Where(x => x.Length != null).Select(x => x.Length).Distinct().ToList();
            ViewBag.GenGe = _context.Burials.Where(x => x.GenderGe != null).Select(x => x.GenderGe).Distinct().ToList();

            return View(_context.Burials
                .Distinct()
                .ToList());
        }
    }
}
