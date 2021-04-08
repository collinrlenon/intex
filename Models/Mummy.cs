using System;
using System.ComponentModel.DataAnnotations;

namespace OperationDigger.Models
{
    public class Mummy
    {
        //dummy data for the mummy
            [Key]
            public int MummyId { get; set; }
           
            public int Age { get; set; }
           
            public string Year{ get; set; }
          
            public string DOD { get; set; } //date of death?
            
    }
}
