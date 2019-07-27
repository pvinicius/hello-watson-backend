using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VisualRecognition.Domain.DTO;

namespace VisualRecognition.Domain.Entities
{
    public class Image
    {
        public Image()
        {

        }
        public Image(string file)
        {
            ImagePath = file;
            ImageName = string.Format("{0}", DateTime.Now);
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
    }
}
