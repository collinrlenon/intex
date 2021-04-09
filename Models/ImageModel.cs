using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace OperationDigger.Models
{
    public class ImageModel
    {
        [Key]
        public int ImageId { get; set; }

        [Column(TypeName="nvarchar(50)")]
        public string ImageName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageTitle { get; set; }

        [NotMapped]
        [DisplayName("Upload Your Image")]
        public IFormFile ImageFile { get; set; }
    }
}
