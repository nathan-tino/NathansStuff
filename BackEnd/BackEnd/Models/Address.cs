using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NathansStuff.Models
{
    public class Address
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string Street{ get; set; } = null!;

        [MaxLength(40)]
        public string City { get; set; } = null!;

        [MaxLength(40)]
        public string State { get; set; } = null!;

        [Column(TypeName = "char(2)")]
        public string Country { get; set; } = null!;
        public int Phone { get; set; }
        public int ZipCode { get; set; }

        [MaxLength(40)]
        public string Name { get; set; } = null!;
        public bool IsPrimary { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
