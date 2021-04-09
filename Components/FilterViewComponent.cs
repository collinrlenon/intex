using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OperationDigger.Models;

namespace OperationDigger.Components
{
    public class FilterViewComponent : ViewComponent
    {
        private ebdbContext _context;

        public FilterViewComponent (ebdbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(_context.Burials
                .Distinct()
                .ToList());
        }
    }
}
