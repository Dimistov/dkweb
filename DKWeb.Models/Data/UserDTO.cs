using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DKWeb.Models
{
    public class UserDTO
    {
        [Key]
        //[NotNull]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username must be at least 3 characters long.")]
        public string Username { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 5, ErrorMessage = "Password must be at least 5 characters long.")]
        public string Password { get; set; }


        public string Role { get; set; } = "None"; // Value set so that required field is not null initially
    }
}
