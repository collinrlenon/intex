using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace OperationDigger.Models
{
    public partial class Burial
    {
        [Key]
        public int BurialId { get; set; }
        public string LocationId { get; set; }
        public string BurialNs { get; set; }
        public int? LowNs { get; set; }
        public int? HighNs { get; set; }
        public string BurialEw { get; set; }
        public int? LowEw { get; set; }
        public int? HighEw { get; set; }
        public string BurialSubplot { get; set; }
        public string BurialNum { get; set; }
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public int? YearExc { get; set; }
        public string MonthExc { get; set; }
        public int? DayExc { get; set; }
        public string HeadDirection { get; set; }
        public bool? PostcraniaTrauma { get; set; }
        public string YrSkull { get; set; }
        public string MtSkull { get; set; }
        public int? DSkull { get; set; }
        public string FieldBook { get; set; }
        public string FieldBookPgnum { get; set; }
        public string DexInitials { get; set; }
        public string DecInitials { get; set; }
        public string ByuSample { get; set; }
        public int? BodyAnalysis { get; set; }
        public string SkullMag { get; set; }
        public bool? PostcraniaMag { get; set; }
        public string SexSkull { get; set; }
        public string AgeSkull { get; set; }
        public string RackShelf { get; set; }
        public bool? SkullTrauma { get; set; }
        public bool? CribraOrbitala { get; set; }
        public string PoroticHyperostosis { get; set; }
        public string PoroticHyperostosisLoc { get; set; }
        public string MetopicSuture { get; set; }
        public bool? ButtonOsteoma { get; set; }
        public string OsteologyUnknownComment { get; set; }
        public bool? TemporalMandibularJointOsteoarthritis { get; set; }
        public string LinearHypoplasiaEnamel { get; set; }
        public int? HillBurialsA { get; set; }
        public int? Tomb { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal? WestToHead { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal? WestToFeet { get; set; }
        public string BurialPreservation { get; set; }
        public string BurialWrapping { get; set; }
        public string BurialAc { get; set; }
        public string BurialGendMeth { get; set; }
        public string AgeCode { get; set; }
        public string BurialAgeDeath { get; set; }
        public string BurialAgeMeth { get; set; }
        public string BurialHc { get; set; }
        public string BurialSt { get; set; }
        public string LenM { get; set; }
        public string LenCm { get; set; }
        public string Cluster { get; set; }
        public string FaceBundle { get; set; }
        public string OsteologyNotes { get; set; }
        public decimal? BurialDepth { get; set; }
        public decimal? SouthToHead { get; set; }
        public decimal? SouthToFeet { get; set; }
        public int? Length { get; set; }
        public bool? AritifactFound { get; set; }
        public string AritifactFoundDesc { get; set; }
        public string AritifactFound2 { get; set; }
        public string BurialSituation { get; set; }
        public int? SampleNumber { get; set; }
        public string GenderGe { get; set; }
        public decimal? GeFunction { get; set; }
        public string BasliarSuture { get; set; }
        public int? VentralArc { get; set; }
        public int? SubpubicAngle { get; set; }
        public int? SciaticNotch { get; set; }
        public int? PubicBone { get; set; }
        public int? PreaurSulcus { get; set; }
        public int? MedialIpRamus { get; set; }
        public int? DorsalPitting { get; set; }
        public int? ForemanMagnum { get; set; }
        public decimal? FemurHead { get; set; }
        public decimal? HumerusHead { get; set; }
        public string Osteophytosis { get; set; }
        public string PubicSymphysis { get; set; }
        public int? BoneLength { get; set; }
        public int? MedialClavicle { get; set; }
        public int? IliacCrest { get; set; }
        public int? FemurDiameter { get; set; }
        public int? Humerus { get; set; }
        public decimal? FemurLength { get; set; }
        public decimal? HumerusLength { get; set; }
        public decimal? TibiaLength { get; set; }
        public int? Robust { get; set; }
        public int? SupraorbitalRidges { get; set; }
        public int? OrbitEdge { get; set; }
        public int? ParietalBossing { get; set; }
        public int? Gonian { get; set; }
        public int? NuchalCrest { get; set; }
        public int? ZygomaticCrest { get; set; }
        public string CranialSuture { get; set; }
        public decimal? MaximumCranialLength { get; set; }
        public decimal? MaximumCranialBreadth { get; set; }
        public decimal? BasionBregmaHeight { get; set; }
        public decimal? BasionNasion { get; set; }
        public decimal? BasionProsthionLength { get; set; }
        public decimal? BizygomaticDiameter { get; set; }
        public decimal? NasionProsthion { get; set; }
        public decimal? MaximumNasalBreadth { get; set; }
        public decimal? InterorbitalBreadth { get; set; }
        public string PreservationIndex { get; set; }
        public string DescriptionOfTaken { get; set; }
        public decimal? EstimateAge { get; set; }
        public decimal? EstimateLivingStature { get; set; }
        public string ToothAttrition { get; set; }
        public string ToothEruption { get; set; }
        public string PathologyAnomalies { get; set; }
        public string EpiphysealUnion { get; set; }
        public bool? HairTaken { get; set; }
        public bool? SoftTissueTaken { get; set; }
        public bool? BoneTaken { get; set; }
        public bool? ToothTaken { get; set; }
        public bool? TextileTaken { get; set; }
        public string Notes { get; set; }
    }
}
