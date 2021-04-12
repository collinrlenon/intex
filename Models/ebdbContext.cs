using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OperationDigger.Models
{
    public partial class ebdbContext : DbContext
    {
        public ebdbContext()
        {
        }

        public ebdbContext(DbContextOptions<ebdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BioSample> BioSamples { get; set; }
        public virtual DbSet<Burial> Burials { get; set; }
        public virtual DbSet<CarbonDating> CarbonDatings { get; set; }
        public virtual DbSet<Cranial> Cranials { get; set; }
        public virtual DbSet<ProjectRole> ProjectRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=aa1n46hd33zfihr.cuj8pfytwaes.us-east-1.rds.amazonaws.com;Username=postgres;Password=catchmeifyoucan22;Database=ebdb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<BioSample>(entity =>
            {
                entity.HasKey(e => e.BsId)
                    .HasName("bio_samples_pkey");

                entity.ToTable("bio_samples");

                entity.Property(e => e.BsId)
                    .ValueGeneratedNever()
                    .HasColumnName("bs_id");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Bag).HasColumnName("bag");

                entity.Property(e => e.BurialNum).HasColumnName("burial_num");

                entity.Property(e => e.Cluster).HasColumnName("cluster");

                entity.Property(e => e.CreatedAtDate)
                    .HasColumnType("date")
                    .HasColumnName("created_at_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedAtTime)
                    .HasColumnType("time without time zone")
                    .HasColumnName("created_at_time")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Ew).HasColumnName("ew");

                entity.Property(e => e.EwHigh).HasColumnName("ew_high");

                entity.Property(e => e.EwLow).HasColumnName("ew_low");

                entity.Property(e => e.Initials).HasColumnName("initials");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Ns).HasColumnName("ns");

                entity.Property(e => e.NsHigh).HasColumnName("ns_high");

                entity.Property(e => e.NsLow).HasColumnName("ns_low");

                entity.Property(e => e.PrevSamp).HasColumnName("prev_samp");

                entity.Property(e => e.Rack).HasColumnName("rack");
            });

            modelBuilder.Entity<Burial>(entity =>
            {
                entity.ToTable("burials");

                entity.Property(e => e.BurialId)
                    .HasColumnName("burial_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.AgeCode).HasColumnName("age_code");

                entity.Property(e => e.AgeSkull).HasColumnName("age_skull");

                entity.Property(e => e.AritifactFound).HasColumnName("aritifact_found");

                entity.Property(e => e.AritifactFound2).HasColumnName("aritifact_found2");

                entity.Property(e => e.AritifactFoundDesc).HasColumnName("aritifact_found_desc");

                entity.Property(e => e.BasionBregmaHeight)
                    .HasPrecision(5, 2)
                    .HasColumnName("basion_bregma_height");

                entity.Property(e => e.BasionNasion)
                    .HasPrecision(5, 2)
                    .HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength)
                    .HasPrecision(4, 2)
                    .HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BasliarSuture).HasColumnName("basliar_suture");

                entity.Property(e => e.BizygomaticDiameter)
                    .HasPrecision(5, 2)
                    .HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.BodyAnalysis).HasColumnName("body_analysis");

                entity.Property(e => e.BoneLength).HasColumnName("bone_length");

                entity.Property(e => e.BoneTaken).HasColumnName("bone_taken");

                entity.Property(e => e.BurialAc).HasColumnName("burial_ac");

                entity.Property(e => e.BurialAgeDeath).HasColumnName("burial_age_death");

                entity.Property(e => e.BurialAgeMeth).HasColumnName("burial_age_meth");

                entity.Property(e => e.BurialDepth)
                    .HasPrecision(5, 2)
                    .HasColumnName("burial_depth");

                entity.Property(e => e.BurialEw).HasColumnName("burial_ew");

                entity.Property(e => e.BurialGendMeth).HasColumnName("burial_gend_meth");

                entity.Property(e => e.BurialHc).HasColumnName("burial_hc");

                entity.Property(e => e.BurialNs).HasColumnName("burial_ns");

                entity.Property(e => e.BurialNum).HasColumnName("burial_num");

                entity.Property(e => e.BurialPreservation).HasColumnName("burial_preservation");

                entity.Property(e => e.BurialSituation).HasColumnName("burial_situation");

                entity.Property(e => e.BurialSt).HasColumnName("burial_st");

                entity.Property(e => e.BurialSubplot).HasColumnName("burial_subplot");

                entity.Property(e => e.BurialWrapping).HasColumnName("burial_wrapping");

                entity.Property(e => e.ButtonOsteoma).HasColumnName("button_osteoma");

                entity.Property(e => e.ByuSample).HasColumnName("byu_sample");

                entity.Property(e => e.Cluster).HasColumnName("cluster");

                entity.Property(e => e.CranialSuture).HasColumnName("cranial_suture");

                entity.Property(e => e.CreatedAtDate)
                    .HasColumnType("date")
                    .HasColumnName("created_at_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedAtTime)
                    .HasColumnType("time without time zone")
                    .HasColumnName("created_at_time")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CribraOrbitala).HasColumnName("cribra_orbitala");

                entity.Property(e => e.DSkull).HasColumnName("d_skull");

                entity.Property(e => e.DayExc).HasColumnName("day_exc");

                entity.Property(e => e.DecInitials).HasColumnName("dec_initials");

                entity.Property(e => e.DescriptionOfTaken).HasColumnName("description_of_taken");

                entity.Property(e => e.DexInitials).HasColumnName("dex_initials");

                entity.Property(e => e.DorsalPitting).HasColumnName("dorsal_pitting");

                entity.Property(e => e.EpiphysealUnion).HasColumnName("epiphyseal_union");

                entity.Property(e => e.EstimateAge)
                    .HasPrecision(3, 1)
                    .HasColumnName("estimate_age");

                entity.Property(e => e.EstimateLivingStature)
                    .HasPrecision(5, 2)
                    .HasColumnName("estimate_living_stature");

                entity.Property(e => e.FaceBundle).HasColumnName("face_bundle");

                entity.Property(e => e.FemurDiameter).HasColumnName("femur_diameter");

                entity.Property(e => e.FemurHead)
                    .HasPrecision(5, 2)
                    .HasColumnName("femur_head");

                entity.Property(e => e.FemurLength)
                    .HasPrecision(3, 1)
                    .HasColumnName("femur_length");

                entity.Property(e => e.FieldBook).HasColumnName("field_book");

                entity.Property(e => e.FieldBookPgnum).HasColumnName("field_book_pgnum");

                entity.Property(e => e.ForemanMagnum).HasColumnName("foreman_magnum");

                entity.Property(e => e.GeFunction)
                    .HasPrecision(5, 2)
                    .HasColumnName("ge_function");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.GenderGe).HasColumnName("gender_ge");

                entity.Property(e => e.Gonian).HasColumnName("gonian");

                entity.Property(e => e.HairColor).HasColumnName("hair_color");

                entity.Property(e => e.HairTaken).HasColumnName("hair_taken");

                entity.Property(e => e.HeadDirection).HasColumnName("head_direction");

                entity.Property(e => e.HighEw).HasColumnName("high_ew");

                entity.Property(e => e.HighNs).HasColumnName("high_ns");

                entity.Property(e => e.HillBurialsA).HasColumnName("hill_burials_a");

                entity.Property(e => e.Humerus).HasColumnName("humerus");

                entity.Property(e => e.HumerusHead)
                    .HasPrecision(5, 2)
                    .HasColumnName("humerus_head");

                entity.Property(e => e.HumerusLength)
                    .HasPrecision(3, 1)
                    .HasColumnName("humerus_length");

                entity.Property(e => e.IliacCrest).HasColumnName("iliac_crest");

                entity.Property(e => e.InterorbitalBreadth)
                    .HasPrecision(4, 2)
                    .HasColumnName("interorbital_breadth");

                entity.Property(e => e.LenCm).HasColumnName("len_cm");

                entity.Property(e => e.LenM).HasColumnName("len_m");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.LinearHypoplasiaEnamel).HasColumnName("linear_hypoplasia_enamel");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.LowEw).HasColumnName("low_ew");

                entity.Property(e => e.LowNs).HasColumnName("low_ns");

                entity.Property(e => e.MaximumCranialBreadth)
                    .HasPrecision(5, 2)
                    .HasColumnName("maximum_cranial_breadth");

                entity.Property(e => e.MaximumCranialLength)
                    .HasPrecision(5, 2)
                    .HasColumnName("maximum_cranial_length");

                entity.Property(e => e.MaximumNasalBreadth)
                    .HasPrecision(4, 2)
                    .HasColumnName("maximum_nasal_breadth");

                entity.Property(e => e.MedialClavicle).HasColumnName("medial_clavicle");

                entity.Property(e => e.MedialIpRamus).HasColumnName("medial_ip_ramus");

                entity.Property(e => e.MetopicSuture).HasColumnName("metopic_suture");

                entity.Property(e => e.MonthExc).HasColumnName("month_exc");

                entity.Property(e => e.MtSkull).HasColumnName("mt_skull");

                entity.Property(e => e.NasionProsthion)
                    .HasPrecision(4, 2)
                    .HasColumnName("nasion_prosthion");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.NuchalCrest).HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge).HasColumnName("orbit_edge");

                entity.Property(e => e.OsteologyNotes).HasColumnName("osteology_notes");

                entity.Property(e => e.OsteologyUnknownComment).HasColumnName("osteology_unknown_comment");

                entity.Property(e => e.Osteophytosis).HasColumnName("osteophytosis");

                entity.Property(e => e.ParietalBossing).HasColumnName("parietal_bossing");

                entity.Property(e => e.PathologyAnomalies).HasColumnName("pathology_anomalies");

                entity.Property(e => e.PoroticHyperostosis).HasColumnName("porotic_hyperostosis");

                entity.Property(e => e.PoroticHyperostosisLoc).HasColumnName("porotic_hyperostosis_loc");

                entity.Property(e => e.PostcraniaMag).HasColumnName("postcrania_mag");

                entity.Property(e => e.PostcraniaTrauma).HasColumnName("postcrania_trauma");

                entity.Property(e => e.PreaurSulcus).HasColumnName("preaur_sulcus");

                entity.Property(e => e.PreservationIndex).HasColumnName("preservation_index");

                entity.Property(e => e.PubicBone).HasColumnName("pubic_bone");

                entity.Property(e => e.PubicSymphysis).HasColumnName("pubic_symphysis");

                entity.Property(e => e.RackShelf).HasColumnName("rack_shelf");

                entity.Property(e => e.Robust).HasColumnName("robust");

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");

                entity.Property(e => e.SciaticNotch).HasColumnName("sciatic_notch");

                entity.Property(e => e.SexSkull).HasColumnName("sex_skull");

                entity.Property(e => e.SkullMag).HasColumnName("skull_mag");

                entity.Property(e => e.SkullTrauma).HasColumnName("skull_trauma");

                entity.Property(e => e.SoftTissueTaken).HasColumnName("soft_tissue_taken");

                entity.Property(e => e.SouthToFeet)
                    .HasPrecision(5, 2)
                    .HasColumnName("south_to_feet");

                entity.Property(e => e.SouthToHead)
                    .HasPrecision(5, 2)
                    .HasColumnName("south_to_head");

                entity.Property(e => e.SubpubicAngle).HasColumnName("subpubic_angle");

                entity.Property(e => e.SupraorbitalRidges).HasColumnName("supraorbital_ridges");

                entity.Property(e => e.TemporalMandibularJointOsteoarthritis).HasColumnName("temporal_mandibular_joint_osteoarthritis");

                entity.Property(e => e.TextileTaken).HasColumnName("textile_taken");

                entity.Property(e => e.TibiaLength)
                    .HasPrecision(3, 1)
                    .HasColumnName("tibia_length");

                entity.Property(e => e.Tomb).HasColumnName("tomb");

                entity.Property(e => e.ToothAttrition).HasColumnName("tooth_attrition");

                entity.Property(e => e.ToothEruption).HasColumnName("tooth_eruption");

                entity.Property(e => e.ToothTaken).HasColumnName("tooth_taken");

                entity.Property(e => e.VentralArc).HasColumnName("ventral_arc");

                entity.Property(e => e.WestToFeet)
                    .HasPrecision(5, 2)
                    .HasColumnName("west_to_feet");

                entity.Property(e => e.WestToHead)
                    .HasPrecision(5, 2)
                    .HasColumnName("west_to_head");

                entity.Property(e => e.YearExc).HasColumnName("year_exc");

                entity.Property(e => e.YrSkull).HasColumnName("yr_skull");

                entity.Property(e => e.ZygomaticCrest).HasColumnName("zygomatic_crest");
            });

            modelBuilder.Entity<CarbonDating>(entity =>
            {
                entity.HasKey(e => e.CarbonId)
                    .HasName("carbon_dating_pkey");

                entity.ToTable("carbon_dating");

                entity.Property(e => e.CarbonId)
                    .ValueGeneratedNever()
                    .HasColumnName("carbon_id");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.BurialNum).HasColumnName("burial_num");

                entity.Property(e => e.C14Sample2017).HasColumnName("c14_sample_2017");

                entity.Property(e => e.Calibr95CalDateAvg).HasColumnName("calibr_95_cal_date_avg");

                entity.Property(e => e.Calibr95CalDateMax).HasColumnName("calibr_95_cal_date_max");

                entity.Property(e => e.Calibr95CalDateMin).HasColumnName("calibr_95_cal_date_min");

                entity.Property(e => e.Calibr95CalDateSpan).HasColumnName("calibr_95_cal_date_span");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Conventional14cAgeBp).HasColumnName("conventional_14c_age_bp");

                entity.Property(e => e.CreatedAtDate)
                    .HasColumnType("date")
                    .HasColumnName("created_at_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedAtTime)
                    .HasColumnType("time without time zone")
                    .HasColumnName("created_at_time")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Ew).HasColumnName("ew");

                entity.Property(e => e.EwLow).HasColumnName("ew_low");

                entity.Property(e => e.Foci).HasColumnName("foci");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Ns).HasColumnName("ns");

                entity.Property(e => e.NsLow).HasColumnName("ns_low");

                entity.Property(e => e.Questions).HasColumnName("questions");

                entity.Property(e => e.Rack).HasColumnName("rack");

                entity.Property(e => e.Rack1).HasColumnName("rack_1");

                entity.Property(e => e.SizeMl).HasColumnName("size_ml");

                entity.Property(e => e.Square).HasColumnName("square");

                entity.Property(e => e.TubeNum).HasColumnName("tube_num");

                entity.Property(e => e._14cCalenderDate).HasColumnName("14c_calender_date");
            });

            modelBuilder.Entity<Cranial>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("cranial_pkey");

                entity.ToTable("cranial");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("c_id");

                entity.Property(e => e.BasionBregmaHeight)
                    .HasPrecision(5, 2)
                    .HasColumnName("basion_bregma_height");

                entity.Property(e => e.BasionNasion)
                    .HasPrecision(5, 2)
                    .HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLen)
                    .HasPrecision(5, 2)
                    .HasColumnName("basion_prosthion_len");

                entity.Property(e => e.BizygomaticDiameter)
                    .HasPrecision(5, 2)
                    .HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.BodyGender).HasColumnName("body_gender");

                entity.Property(e => e.BurialArtDescription).HasColumnName("burial_art_description");

                entity.Property(e => e.BurialDepth)
                    .HasPrecision(4, 2)
                    .HasColumnName("burial_depth");

                entity.Property(e => e.BurialNum).HasColumnName("burial_num");

                entity.Property(e => e.BurialPosEwDirection).HasColumnName("burial_pos_ew_direction");

                entity.Property(e => e.BurialPosEwNum).HasColumnName("burial_pos_ew_num");

                entity.Property(e => e.BurialPosNsDirection).HasColumnName("burial_pos_ns_direction");

                entity.Property(e => e.BurialPosNsNum).HasColumnName("burial_pos_ns_num");

                entity.Property(e => e.BurialSubplotDirection).HasColumnName("burial_subplot_direction");

                entity.Property(e => e.BuriedWithArtifacts).HasColumnName("buried_with_artifacts");

                entity.Property(e => e.CreatedAtDate)
                    .HasColumnType("date")
                    .HasColumnName("created_at_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedAtTime)
                    .HasColumnType("time without time zone")
                    .HasColumnName("created_at_time")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Ew).HasColumnName("ew");

                entity.Property(e => e.GilesGender).HasColumnName("giles_gender");

                entity.Property(e => e.InterorbitalBreadth)
                    .HasPrecision(4, 2)
                    .HasColumnName("interorbital_breadth");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.MaxCranialBreadth)
                    .HasPrecision(5, 2)
                    .HasColumnName("max_cranial_breadth");

                entity.Property(e => e.MaxNasalBreadth)
                    .HasPrecision(4, 2)
                    .HasColumnName("max_nasal_breadth");

                entity.Property(e => e.MaximumCranialLength)
                    .HasPrecision(5, 2)
                    .HasColumnName("Maximum_Cranial_Length");

                entity.Property(e => e.NasionProsthion)
                    .HasPrecision(5, 2)
                    .HasColumnName("nasion_prosthion");

                entity.Property(e => e.Ns).HasColumnName("ns");

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");
            });

            modelBuilder.Entity<ProjectRole>(entity =>
            {
                entity.ToTable("ProjectRole");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
