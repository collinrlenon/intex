using System;
using System.Collections.Generic;

#nullable disable

namespace OperationDigger.Models
{
    public partial class CarbonDating
    {
        public int CarbonId { get; set; }
        public int? Rack { get; set; }
        public string LocationId { get; set; }
        public int? NsLow { get; set; }
        public string Ns { get; set; }
        public int? EwLow { get; set; }
        public string Ew { get; set; }
        public string Square { get; set; }
        public int? Area { get; set; }
        public int? BurialNum { get; set; }
        public int? Rack1 { get; set; }
        public int? TubeNum { get; set; }
        public string Description { get; set; }
        public int? SizeMl { get; set; }
        public int? Foci { get; set; }
        public int? C14Sample2017 { get; set; }
        public string Location { get; set; }
        public string Questions { get; set; }
        public int? Conventional14cAgeBp { get; set; }
        public int? _14cCalenderDate { get; set; }
        public int? Calibr95CalDateMax { get; set; }
        public int? Calibr95CalDateMin { get; set; }
        public int? Calibr95CalDateSpan { get; set; }
        public string Calibr95CalDateAvg { get; set; }
        public string Category { get; set; }
        public string Notes { get; set; }
    }
}
