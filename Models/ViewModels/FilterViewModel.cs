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

        public string gender { get; set; }
        public string hairColor { get; set; }
        public int? yearExc { get; set; }
        public string monthExc { get; set; }
        public string headDir { get; set; }
        public string fieldBook { get; set; }
        public string byuSamp { get; set; }
        public string skullMag { get; set; }
        public string sexSkull { get; set; }
        public string ageSkull { get; set; }
        public decimal? wtHead { get; set; }
        public decimal? wtFeet { get; set; }
        public string burialPres { get; set; }
        public string burialWrap { get; set; }
        public string gendMeth { get; set; }
        public string ageCode { get; set; }
        public string faceBundle { get; set; }
        public decimal? burDepth { get; set; }
        public decimal? stHead { get; set; }
        public decimal? stFeet { get; set; }
        public int? Length { get; set; }
        public string genGe { get; set; }
    }
}
