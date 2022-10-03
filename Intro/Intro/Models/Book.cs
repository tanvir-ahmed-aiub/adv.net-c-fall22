using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Intro.Models
{
    public class Book
    {
        [Required]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please provide name")]
        [StringLength(25,MinimumLength =3,ErrorMessage = "Name should contain 3 t0 25 characters")]
        public string Author { get; set; }
        public string Category { get; set; }
        [Required]
        [Range(1,20)]
        public int Copy { get; set; }
        [Required]
        [StringLength(50,MinimumLength =8)]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfPassword { get; set; }
    }
}