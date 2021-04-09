using System;
using System.Collections.Generic;

namespace OperationDigger.Models.ViewModels
{
    public class FilterViewModel
    {
        public IEnumerable<BioSample> bioSample { get; set; }

        public IEnumerable<Burial> burial { get; set; }

        public IEnumerable<CarbonDating> carbonDating { get; set; }

        public IEnumerable<Cranial> cranial { get; set; }
    }
}
