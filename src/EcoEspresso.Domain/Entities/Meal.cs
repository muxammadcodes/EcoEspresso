using EcoEspresso.Domain.Commons;

namespace EcoEspresso.Domain.Entities;

public class Meal : Auditable
{
    public string Name { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }
    
    public int FoodInformationId { get; set; }
    public FoodInfotmation FoodInfotmation { get; set;}

    public int ChefId { get; set; }
    public Chef Chef { get; set; }

    
}
