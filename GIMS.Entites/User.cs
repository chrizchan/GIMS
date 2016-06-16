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

        [MaxLength(60)]
        [Required(ErrorMessage = "Please enter the username")]
        public string Username { get; set; }

        [MaxLength(100)]
        public string Password { get; set; }

        [MaxLength(100)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [MaxLength(100)]
        [Display(Name = "Firstname")]
        public string FirstName { get; set; }

        [MaxLength(100)]
        [Display(Name = "Lastname")]
        public string LastName { get; set; }
        public bool Deleted { get; set; }
        public bool IsActive { get; set; }
        public bool IsSLS { get; set; }

        public int CreatedById { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedById { get; set; }



    }
}
