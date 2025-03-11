using System.ComponentModel.DataAnnotations;

namespace ProductManagementSystem.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100, ErrorMessage ="Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required, Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "StockQuantity Should be a non-negative integer number.")]
        public int StockQuantity { get; set; }
    }
}
