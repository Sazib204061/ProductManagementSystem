using System.ComponentModel.DataAnnotations;

namespace ProductManagementSystem.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }
    }
}
