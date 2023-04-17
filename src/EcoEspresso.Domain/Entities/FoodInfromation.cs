using EcoEspresso.Domain.Commons;
using EcoEspresso.Domain.Enum;
using System.Reflection.PortableExecutable;

namespace EcoEspresso.Domain.Entities
{
    public class FoodInfotmation : Auditable
    {
        public int MealId { get; set; }
        public Meal Meal { get; set; } = default!;
        public string Country { get; set; } = string.Empty;
        public FoodType Type { get; set; }
    }
}
