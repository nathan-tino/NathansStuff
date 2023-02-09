using System.ComponentModel.DataAnnotations;

namespace NathansStuff.Models
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string Name { get; set; } = null!;

        [MaxLength(50)]
        public string Password { get; set; } = null!;

        [MaxLength(40)]
        public string FirstName { get; set; } = null!;

        [MaxLength(40)]
        public string LastName { get; set; } = null!;

        [MaxLength(60)]
        public string Email { get; set; } = null!;
        
    }
}
