using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiczbyPierwsze.Main;
using System.ComponentModel.DataAnnotations;

namespace LiczbyPierwsze.WebCoreApp1.Models
{
    public class PrimaryModel
    {
        [Required(ErrorMessage = "Podaj dolną granicę")]
        [Range(minimum:2,maximum:10000)]
        [Display(Name = "Podaj dolną granicę")]
        public int DLimit { get; set; }

        [Required(ErrorMessage = "Podaj górną granicę")]
        [Range(minimum: 2, maximum: 10000)]
        [Display(Name = "Podaj górną granicę")]
        public int ULimit { get; set; }

        public List<int> Numbers { get; set; }
    }
}
