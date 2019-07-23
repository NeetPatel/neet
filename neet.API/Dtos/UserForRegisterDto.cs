using System.ComponentModel.DataAnnotations;

namespace neet.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You have specify password between 4 and 8 characters")]
        public string Password { get; set; }
    }
}