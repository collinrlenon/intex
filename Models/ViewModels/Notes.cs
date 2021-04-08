using System;
using System.ComponentModel.DataAnnotations;

namespace OperationDigger.Models
{
    public class Notes
    {
        [Key]
        public int NotesId { get; set; }

        public int MainNotes { get; set; }

        public DateTime Date { get; set; }
    }
}
