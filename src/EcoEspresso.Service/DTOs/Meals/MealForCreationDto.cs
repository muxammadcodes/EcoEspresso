using EcoEspresso.Domain.Entities;

namespace EcoEspresso.Service.DTOs
{
    public class MealForCreationDto
    {
        public string Name { get; set; } = string.Empty;
        public int Count { get; set; }
        public decimal Price { get; set; }
        public int ChefId { get; set; }
    }
}
