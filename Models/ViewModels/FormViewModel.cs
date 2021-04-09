using System;
using System.Collections.Generic;

namespace OperationDigger.Models.ViewModels
{
    public class FormViewModel
    {
        public BioSample BioSamples { get; set; }

        public Burial Burials { get; set; }

        public CarbonDating CarbonDatings { get; set; }

        public Cranial Cranials { get; set; }
    }
}
