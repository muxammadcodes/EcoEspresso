using EcoEspresso.Domain.Commons;
using EcoEspresso.Domain.Enum;
using System.Reflection.PortableExecutable;

namespace EcoEspresso.Domain.Entities
{
    public class MealInfo : Auditable
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public FoodType Type { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}
