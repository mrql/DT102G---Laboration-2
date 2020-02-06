using System;
using System.ComponentModel.DataAnnotations;

namespace DT102G___Laboration_2.Models
{
    public class Form
    {
        // - Personal info -
        [Display(Name = "Ålder")]
        [Range(1,100, ErrorMessage = "Ange en ålder mellan 1 och 100.")]
        [Required(ErrorMessage = "Ange en ålder.")]
        public ushort? Age { get; set; }

        [Display(Name = "Kön")]
        [Required(ErrorMessage = "Ange ett kön.")]
        public string Gender { get; set; }

        // - Form answers -
        [Display(Name = "Fråga 1")]
        [Required(ErrorMessage = "Markera ett av alternativen.")]
        public string Question1 { get; set; }

        [Display(Name = "Fråga 2")]
        [Required(ErrorMessage = "Markera ett av alternativen.")]
        public string Question2 { get; set; }

        [Display(Name = "Fråga 3")]
        [Required(ErrorMessage = "Markera ett av alternativen.")]
        public string Question3 { get; set; }

        [Display(Name = "Övrigt")]
        public string Message { get; set; }
    }
}
