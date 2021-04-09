using System;
using System.Collections.Generic;

namespace OperationDigger.Models.ViewModels
{
    public class FilterViewModel
    {
        public List<BioSample> BioSamples { get; set; }

        public List<Burial> Burials { get; set; }

        public List<CarbonDating> CarbonDatings { get; set; }

        public List<Cranial> Cranials { get; set; }
    }
}
