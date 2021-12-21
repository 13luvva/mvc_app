using System.ComponentModel.DataAnnotations;

namespace _21_11_2021.Models
{
    public class Visitors
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please choose kurs")]
        public string Kurs { get; set; }
        [Required(ErrorMessage = "Please choose univercity")]
        public string University { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }

}