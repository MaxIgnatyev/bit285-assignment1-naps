using System;
using System.ComponentModel.DataAnnotations;

namespace bit285assignment1naps.Models
{
    public class User
    {
        [Required(ErrorMessage = "Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Program { get; set; }
        public string BirthYear { get; set; }
        public string FavoriteColor { get; set; }
    }
}
