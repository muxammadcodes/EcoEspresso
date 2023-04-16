using EcoEspresso.Domain.Commons;
using System.Reflection.PortableExecutable;

namespace EcoEspresso.Domain.Entities
{
    public class MelaType : Auditable
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
