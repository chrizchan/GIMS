using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GIMS.Entities
{
    public class User
    {
        [Required]        
        public int Id { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Please enter the username")]
        public string Username { get; set; }

        [MaxLength(100)]
        [Display(Name = "Email Address")]
        //[RequiredIf("RequireEmailAddress", true, ErrorMessage = "Please enter either email address or mobile no")]
        public string EmailAddress { get; set; }

    }
}
