using System;
using System.Collections.Generic;

namespace OperationDigger.Models.ViewModels
{
    public class BurialListViewModel
    {
        public IEnumerable<Burial> Burials { get; set; }

        public IEnumerable<BioSample> BioSamples { get; set; }

        public IEnumerable<Cranial> Cranials { get; set; }

        public IEnumerable<CarbonDating> CarbonDatings { get; set; }

        public PageNumbering PageNumbering { get; set; }

        public FilterViewModel Filters { get; set; }

        public int? BurialId { get; set; } 
    }
}
