using EcoEspresso.Domain.Commons;
using EcoEspresso.Domain.Enum;
using System.Reflection.PortableExecutable;

namespace EcoEspresso.Domain.Entities
{
    public class MelaInfo : Auditable
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public FoodType Type { get; set; }
    }
}
