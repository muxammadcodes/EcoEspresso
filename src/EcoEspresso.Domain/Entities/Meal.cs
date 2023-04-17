using EcoEspresso.Domain.Commons;
using System.Diagnostics;

namespace EcoEspresso.Domain.Entities;

public class Meal : Auditable
{
    public string Name { get; set; } = string.Empty;
    public int Count { get; set; }
    public decimal Price { get; set; }

    public int ChefId { get; set; }
    public Chef Chef { get; set; } = default!;

    public FoodInfotmation FoodInfotmation { get; set;} = default!;
}
