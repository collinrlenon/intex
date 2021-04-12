using System;
using System.Collections.Generic;

#nullable disable

namespace OperationDigger.Models
{
    public partial class Cranial
    {
        public int CId { get; set; }
        public int? SampleNumber { get; set; }
        public decimal? MaximumCranialLength { get; set; }
        public decimal? MaxCranialBreadth { get; set; }
        public decimal? BasionBregmaHeight { get; set; }
        public decimal? BasionNasion { get; set; }
        public decimal? BasionProsthionLen { get; set; }
        public decimal? BizygomaticDiameter { get; set; }
        public decimal? NasionProsthion { get; set; }
        public decimal? MaxNasalBreadth { get; set; }
        public decimal? InterorbitalBreadth { get; set; }
        public string LocationId { get; set; }
        public string BurialPosNsNum { get; set; }
        public string Ns { get; set; }
        public string BurialPosNsDirection { get; set; }
        public string BurialPosEwNum { get; set; }
        public string Ew { get; set; }
        public string BurialPosEwDirection { get; set; }
        public int? BurialNum { get; set; }
        public decimal? BurialDepth { get; set; }
        public string BurialSubplotDirection { get; set; }
        public string BurialArtDescription { get; set; }
        public string BuriedWithArtifacts { get; set; }
        public int? GilesGender { get; set; }
        public string BodyGender { get; set; }
        public TimeSpan CreatedAtTime { get; set; }
        public DateTime CreatedAtDate { get; set; }
    }
}
