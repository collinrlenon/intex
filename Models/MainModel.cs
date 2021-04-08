using System;
using System.ComponentModel.DataAnnotations;

//main model with burial records

namespace OperationDigger.Models
{
    public class MainModel
    {

        //dummy data for the burial record
        [Key]
        [Required]
        public int BurialId { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public DateTime DateofDeath { get; set; }

    }

}
