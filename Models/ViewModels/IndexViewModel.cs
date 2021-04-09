using System;
using System.Collections.Generic;

namespace OperationDigger.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Burial> Burials { get; set; }

        public PageNumbering PageNumbering { get; set; }

        public int? BurialId { get; set; } 
    }
}
