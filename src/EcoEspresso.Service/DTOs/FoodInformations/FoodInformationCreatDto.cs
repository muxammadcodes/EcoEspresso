using EcoEspresso.Domain.Entities;
using EcoEspresso.Domain.Enum;

namespace EcoEspresso.Service.DTOs.FoodInformations
{
    public class FoodInformationCreatDto
    {
        public int MealId { get; set; }
        public string Country { get; set; } = string.Empty;
        public FoodType Type { get; set; }
    }
}
