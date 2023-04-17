using EcoEspresso.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace EcoEspresso.Service.DTOs
{
    public class MealForCreationDto
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Count is required")]

        public int Count { get; set; }
        [Required(ErrorMessage = "Price is required")]

        public decimal Price { get; set; }
        public int ChefId { get; set; }
    }
}
