using System;
using System.Collections.Generic;

#nullable disable

namespace OperationDigger.Models
{
    public partial class BioSample
    {
        public int BsId { get; set; }
        public string Rack { get; set; }
        public string Bag { get; set; }
        public string LocationId { get; set; }
        public string NsLow { get; set; }
        public string NsHigh { get; set; }
        public string Ns { get; set; }
        public string EwLow { get; set; }
        public string EwHigh { get; set; }
        public string Ew { get; set; }
        public string Area { get; set; }
        public int? BurialNum { get; set; }
        public int? Cluster { get; set; }
        public string Date { get; set; }
        public string PrevSamp { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }
        public DateTime CreatedAtDate { get; set; }
        public TimeSpan CreatedAtTime { get; set; }
    }
}
