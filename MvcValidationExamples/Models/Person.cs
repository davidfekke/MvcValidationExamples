using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcValidationExamples.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Firstname is required")]
        [StringLength(50, ErrorMessage = "Field too long")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        [StringLength(50, ErrorMessage = " Field too long ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(256, ErrorMessage = " Field too long by 256 chars")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "email not valid")]
        public string Email { get; set; }

    }
}