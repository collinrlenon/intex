using System;
using System.Collections.Generic;

namespace OperationDigger.Models.ViewModels
{
    public class FilterViewModel
    {
        public IEnumerable<BioSample> BioSamples { get; set; }

        public IEnumerable<Burial> Burials { get; set; }

        public IEnumerable<CarbonDating> CarbonDatings { get; set; }

        public IEnumerable<Cranial> Cranials { get; set; }
    }
}
