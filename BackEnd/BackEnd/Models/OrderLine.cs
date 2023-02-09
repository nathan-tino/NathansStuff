using System.ComponentModel.DataAnnotations.Schema;

namespace NathansStuff.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal PricePaid { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
