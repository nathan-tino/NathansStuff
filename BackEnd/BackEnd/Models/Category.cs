using System.ComponentModel.DataAnnotations;

namespace NathansStuff.Models
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}