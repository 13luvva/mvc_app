using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrainingApp.Models
{
    public class StudentResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please choose your university")]
        public string University { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public string Training { get; set; }
    }
}

