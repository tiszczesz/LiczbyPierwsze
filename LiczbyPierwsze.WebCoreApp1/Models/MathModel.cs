using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LiczbyPierwsze.WebCoreApp1.Models
{
    public class MathModel
    {
        [Required(ErrorMessage = "Podaj A")]
        [Display(Name = "Podaj liczbę")]
        public double A { get; set; }

        [Required(ErrorMessage = "Podaj B")]
        [Display(Name = "Podaj liczbę")]
        public double B { get; set; }

        public double Result { get; set; }
    }
}
