using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CAR.Entities
{
   public class Car
    {
       [HiddenInput]
        public int CarId { get; set; }
        [Required(ErrorMessage = "Enter the name")]
        [Display(Name = "Car name")]
        public string CarName { get; set; }
        [Required(ErrorMessage = "Enter the description")]
        [Display(Name = "Car description")]
        public string Description { get; set; }
        [Required]
        [Range(minimum: 100, maximum: 100000)]
        public int Price { get; set; }
        [Required]
        [Display(Name = "Car year")]
        [Range(minimum: 1970, maximum: 2050)]
        public int CarYear { get; set; }
        [ScaffoldColumn(false)]
        public byte[] Image { get; set; }
        [ScaffoldColumn(false)]
        public string MimeType { get; set; }

    }
}
