using EcoEspresso.Domain.Commons;

namespace EcoEspresso.Domain.Entities;

public class Meal : Auditable
{
    public string Name { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }

}
