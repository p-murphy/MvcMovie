using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class User
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime birthdate { get; set; }

    }
}
