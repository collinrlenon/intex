using Microsoft.EntityFrameworkCore.Migrations;

namespace OperationDigger.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bio_samples",
                columns: table => new
                {
                    bs_id = table.Column<int>(type: "integer", nullable: true),
                    rack = table.Column<string>(type: "text", nullable: true),
                    bag = table.Column<string>(type: "text", nullable: true),
                    location_id = table.Column<string>(type: "text", nullable: true),
                    ns_low = table.Column<string>(type: "text", nullable: true),
                    ns_high = table.Column<string>(type: "text", nullable: true),
                    ns = table.Column<string>(type: "text", nullable: true),
                    ew_low = table.Column<string>(type: "text", nullable: true),
                    ew_high = table.Column<string>(type: "text", nullable: true),
                    ew = table.Column<string>(type: "text", nullable: true),
                    area = table.Column<string>(type: "text", nullable: true),
                    burial_num = table.Column<int>(type: "integer", nullable: true),
                    cluster = table.Column<int>(type: "integer", nullable: true),
                    date = table.Column<string>(type: "text", nullable: true),
                    prev_samp = table.Column<bool>(type: "boolean", nullable: true),
                    notes = table.Column<string>(type: "text", nullable: true),
                    initials = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "burials",
                columns: table => new
                {
                    burial_id = table.Column<int>(type: "integer", nullable: true),
                    location_id = table.Column<string>(type: "text", nullable: true),
                    burial_ns = table.Column<string>(type: "text", nullable: true),
                    burial_ew = table.Column<string>(type: "text", nullable: true),
                    high_ns = table.Column<int>(type: "integer", nullable: true),
                    low_ew = table.Column<int>(type: "integer", nullable: true),
                    high_ew = table.Column<int>(type: "integer", nullable: true),
                    burial_subplot = table.Column<string>(type: "text", nullable: true),
                    gender = table.Column<string>(type: "text", nullable: true),
                    hair_color = table.Column<string>(type: "text", nullable: true),
                    year_exc = table.Column<int>(type: "integer", nullable: true),
                    month_exc = table.Column<string>(type: "text", nullable: true),
                    day_exc = table.Column<int>(type: "integer", nullable: true),
                    head_direction = table.Column<string>(type: "text", nullable: true),
                    postcrania_trauma = table.Column<bool>(type: "boolean", nullable: true),
                    yr_skull = table.Column<string>(type: "text", nullable: true),
                    mt_skull = table.Column<string>(type: "text", nullable: true),
                    d_skull = table.Column<int>(type: "integer", nullable: true),
                    field_book = table.Column<string>(type: "text", nullable: true),
                    field_book_pgnum = table.Column<string>(type: "text", nullable: true),
                    dex_initials = table.Column<string>(type: "text", nullable: true),
                    dec_initials = table.Column<string>(type: "text", nullable: true),
                    byu_sample = table.Column<bool>(type: "boolean", nullable: true),
                    body_analysis = table.Column<int>(type: "integer", nullable: true),
                    skull_mag = table.Column<bool>(type: "boolean", nullable: true),
                    postcrania_mag = table.Column<bool>(type: "boolean", nullable: true),
                    sex_skull = table.Column<string>(type: "text", nullable: true),
                    age_skull = table.Column<string>(type: "text", nullable: true),
                    rack_shelf = table.Column<string>(type: "text", nullable: true),
                    skull_trauma = table.Column<bool>(type: "boolean", nullable: true),
                    cribra_orbitala = table.Column<bool>(type: "boolean", nullable: true),
                    porotic_hyperostosis = table.Column<bool>(type: "boolean", nullable: true),
                    porotic_hyperostosis_loc = table.Column<string>(type: "text", nullable: true),
                    metopic_suture = table.Column<string>(type: "text", nullable: true),
                    button_osteoma = table.Column<bool>(type: "boolean", nullable: true),
                    osteology_unknown_comment = table.Column<string>(type: "text", nullable: true),
                    temporal_mandibular_joint_osteoarthritis = table.Column<bool>(type: "boolean", nullable: true),
                    linear_hypoplasia_enamel = table.Column<string>(type: "text", nullable: true),
                    hill_burials_a = table.Column<int>(type: "integer", nullable: true),
                    tomb = table.Column<int>(type: "integer", nullable: true),
                    west_to_head = table.Column<string>(type: "text", nullable: true),
                    west_to_feet = table.Column<string>(type: "text", nullable: true),
                    burial_preservation = table.Column<string>(type: "text", nullable: true),
                    burial_wrapping = table.Column<string>(type: "text", nullable: true),
                    burial_ac = table.Column<string>(type: "text", nullable: true),
                    burial_gend_meth = table.Column<string>(type: "text", nullable: true),
                    age_code = table.Column<string>(type: "text", nullable: true),
                    burial_age_death = table.Column<string>(type: "text", nullable: true),
                    burial_age_meth = table.Column<string>(type: "text", nullable: true),
                    burial_hc = table.Column<string>(type: "text", nullable: true),
                    burial_st = table.Column<string>(type: "text", nullable: true),
                    len_m = table.Column<string>(type: "text", nullable: true),
                    len_cm = table.Column<string>(type: "text", nullable: true),
                    cluster = table.Column<string>(type: "text", nullable: true),
                    face_bundle = table.Column<string>(type: "text", nullable: true),
                    osteology_notes = table.Column<string>(type: "text", nullable: true),
                    low_ns = table.Column<int>(type: "integer", nullable: true),
                    burial_depth = table.Column<decimal>(type: "numeric(4,1)", precision: 4, scale: 1, nullable: true),
                    burial_s_h = table.Column<int>(type: "integer", nullable: true),
                    burial_s_f = table.Column<int>(type: "integer", nullable: true),
                    length = table.Column<int>(type: "integer", nullable: true),
                    burial_num = table.Column<string>(type: "text", nullable: true),
                    aritifact_found = table.Column<bool>(type: "boolean", nullable: true),
                    aritifact_found_desc = table.Column<string>(type: "text", nullable: true),
                    aritifact_found2 = table.Column<string>(type: "text", nullable: true),
                    east_to_head = table.Column<int>(type: "integer", nullable: true),
                    east_to_feet = table.Column<int>(type: "integer", nullable: true),
                    burial_situation = table.Column<string>(type: "text", nullable: true),
                    sample_number = table.Column<int>(type: "integer", nullable: true),
                    gender_ge = table.Column<string>(type: "text", nullable: true),
                    ge_function = table.Column<decimal>(type: "numeric(7,4)", precision: 7, scale: 4, nullable: true),
                    basliar_suture = table.Column<string>(type: "text", nullable: true),
                    ventral_arc = table.Column<int>(type: "integer", nullable: true),
                    subpubic_angle = table.Column<int>(type: "integer", nullable: true),
                    sciatic_notch = table.Column<int>(type: "integer", nullable: true),
                    pubic_bone = table.Column<int>(type: "integer", nullable: true),
                    preaur_sulcus = table.Column<int>(type: "integer", nullable: true),
                    medial_ip_ramus = table.Column<int>(type: "integer", nullable: true),
                    dorsal_pitting = table.Column<int>(type: "integer", nullable: true),
                    foreman_magnum = table.Column<int>(type: "integer", nullable: true),
                    femur_head = table.Column<decimal>(type: "numeric(4,2)", precision: 4, scale: 2, nullable: true),
                    humerus_head = table.Column<decimal>(type: "numeric(4,2)", precision: 4, scale: 2, nullable: true),
                    osteophytosis = table.Column<string>(type: "text", nullable: true),
                    pubic_symphysis = table.Column<string>(type: "text", nullable: true),
                    bone_length = table.Column<int>(type: "integer", nullable: true),
                    medial_clavicle = table.Column<int>(type: "integer", nullable: true),
                    iliac_crest = table.Column<int>(type: "integer", nullable: true),
                    femur_diameter = table.Column<int>(type: "integer", nullable: true),
                    humerus = table.Column<int>(type: "integer", nullable: true),
                    femur_length = table.Column<decimal>(type: "numeric(3,1)", precision: 3, scale: 1, nullable: true),
                    humerus_length = table.Column<decimal>(type: "numeric(3,1)", precision: 3, scale: 1, nullable: true),
                    tibia_length = table.Column<decimal>(type: "numeric(3,1)", precision: 3, scale: 1, nullable: true),
                    robust = table.Column<int>(type: "integer", nullable: true),
                    supraorbital_ridges = table.Column<int>(type: "integer", nullable: true),
                    orbit_edge = table.Column<int>(type: "integer", nullable: true),
                    parietal_bossing = table.Column<int>(type: "integer", nullable: true),
                    gonian = table.Column<int>(type: "integer", nullable: true),
                    nuchal_crest = table.Column<int>(type: "integer", nullable: true),
                    zygomatic_crest = table.Column<int>(type: "integer", nullable: true),
                    cranial_suture = table.Column<string>(type: "text", nullable: true),
                    maximum_cranial_length = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    maximum_cranial_breadth = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    basion_bregma_height = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    basion_nasion = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    basion_prosthion_length = table.Column<decimal>(type: "numeric(4,2)", precision: 4, scale: 2, nullable: true),
                    bizygomatic_diameter = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    nasion_prosthion = table.Column<decimal>(type: "numeric(4,2)", precision: 4, scale: 2, nullable: true),
                    maximum_nasal_breadth = table.Column<decimal>(type: "numeric(4,2)", precision: 4, scale: 2, nullable: true),
                    interorbital_breadth = table.Column<decimal>(type: "numeric(4,2)", precision: 4, scale: 2, nullable: true),
                    preservation_index = table.Column<string>(type: "text", nullable: true),
                    description_of_taken = table.Column<string>(type: "text", nullable: true),
                    estimate_age = table.Column<decimal>(type: "numeric(3,1)", precision: 3, scale: 1, nullable: true),
                    estimate_living_stature = table.Column<decimal>(type: "numeric(6,3)", precision: 6, scale: 3, nullable: true),
                    tooth_attrition = table.Column<string>(type: "text", nullable: true),
                    tooth_eruption = table.Column<string>(type: "text", nullable: true),
                    pathology_anomalies = table.Column<string>(type: "text", nullable: true),
                    epiphyseal_union = table.Column<string>(type: "text", nullable: true),
                    hair_taken = table.Column<bool>(type: "boolean", nullable: true),
                    soft_tissue_taken = table.Column<bool>(type: "boolean", nullable: true),
                    bone_taken = table.Column<bool>(type: "boolean", nullable: true),
                    tooth_taken = table.Column<bool>(type: "boolean", nullable: true),
                    textile_taken = table.Column<bool>(type: "boolean", nullable: true),
                    notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "carbon_dating",
                columns: table => new
                {
                    carbon_id = table.Column<int>(type: "integer", nullable: true),
                    rack = table.Column<int>(type: "integer", nullable: true),
                    location_id = table.Column<string>(type: "text", nullable: true),
                    ns_low = table.Column<int>(type: "integer", nullable: true),
                    ns = table.Column<string>(type: "text", nullable: true),
                    ew_low = table.Column<int>(type: "integer", nullable: true),
                    ew = table.Column<string>(type: "text", nullable: true),
                    square = table.Column<string>(type: "text", nullable: true),
                    area = table.Column<int>(type: "integer", nullable: true),
                    burial_num = table.Column<int>(type: "integer", nullable: true),
                    rack_1 = table.Column<int>(type: "integer", nullable: true),
                    tube_num = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    size_ml = table.Column<int>(type: "integer", nullable: true),
                    foci = table.Column<int>(type: "integer", nullable: true),
                    c14_sample_2017 = table.Column<int>(type: "integer", nullable: true),
                    location = table.Column<string>(type: "text", nullable: true),
                    questions = table.Column<string>(type: "text", nullable: true),
                    conventional_14c_age_bp = table.Column<int>(type: "integer", nullable: true),
                    _14c_calender_date = table.Column<int>(name: "14c_calender_date", type: "integer", nullable: true),
                    calibr_95_cal_date_max = table.Column<int>(type: "integer", nullable: true),
                    calibr_95_cal_date_min = table.Column<int>(type: "integer", nullable: true),
                    calibr_95_cal_date_span = table.Column<int>(type: "integer", nullable: true),
                    calibr_95_cal_date_avg = table.Column<string>(type: "text", nullable: true),
                    category = table.Column<string>(type: "text", nullable: true),
                    notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "cranial",
                columns: table => new
                {
                    c_id = table.Column<int>(type: "integer", nullable: true),
                    sample_number = table.Column<int>(type: "integer", nullable: true),
                    maximum_cranial_length = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    max_cranial_breadth = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    basion_bregma_height = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    basion_nasion = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    basion_prosthion_len = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    bizygomatic_diameter = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    nasion_prosthion = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    max_nasal_breadth = table.Column<decimal>(type: "numeric(4,2)", precision: 4, scale: 2, nullable: true),
                    interorbital_breadth = table.Column<decimal>(type: "numeric(4,2)", precision: 4, scale: 2, nullable: true),
                    location_id = table.Column<string>(type: "text", nullable: true),
                    burial_pos_ns_num = table.Column<string>(type: "text", nullable: true),
                    ns = table.Column<string>(type: "text", nullable: true),
                    burial_pos_ns_direction = table.Column<string>(type: "text", nullable: true),
                    burial_pos_ew_num = table.Column<string>(type: "text", nullable: true),
                    ew = table.Column<string>(type: "text", nullable: true),
                    burial_pos_ew_direction = table.Column<string>(type: "text", nullable: true),
                    burial_num = table.Column<int>(type: "integer", nullable: true),
                    burial_depth = table.Column<decimal>(type: "numeric(4,2)", precision: 4, scale: 2, nullable: true),
                    burial_subplot_direction = table.Column<string>(type: "text", nullable: true),
                    burial_art_description = table.Column<string>(type: "text", nullable: true),
                    buried_with_artifacts = table.Column<bool>(type: "boolean", nullable: true),
                    giles_gender = table.Column<int>(type: "integer", nullable: true),
                    body_gender = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bio_samples");

            migrationBuilder.DropTable(
                name: "burials");

            migrationBuilder.DropTable(
                name: "carbon_dating");

            migrationBuilder.DropTable(
                name: "cranial");
        }
    }
}
