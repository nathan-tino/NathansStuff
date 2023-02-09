using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NathansStuff.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
    }
}
