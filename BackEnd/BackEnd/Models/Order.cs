namespace NathansStuff.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Placed { get; set; }
        public DateTime? Fulfilled { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<OrderLine> Lines { get; set; } = new List<OrderLine>();
    }
}
