using System.ComponentModel.DataAnnotations;

namespace WineCardAppVersionFour.Entities
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required, MaxLength(100), MinLength(2)]
        public string Username { get; set; }

        [Required]
        public string HashPassword { get; set; }
    }
}
