using System;
using System.Collections.Generic;

namespace OperationDigger.Models.ViewModels
{
    public class BurialListViewModel
    {
        public IEnumerable<Burial> Burials { get; set; }

        public PageNumbering PageNumbering { get; set; }

        public int? BurialId { get; set; } 
    }
}
