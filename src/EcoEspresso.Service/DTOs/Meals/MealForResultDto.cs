using EcoEspresso.Domain.Entities;

namespace EcoEspresso.Service.DTOs.Meals
{
    public class MealForResultDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Count { get; set; }
        public decimal Price { get; set; }
        public int ChefId { get; set; }
    }
}
