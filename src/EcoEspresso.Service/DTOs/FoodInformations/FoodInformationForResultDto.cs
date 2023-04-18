using EcoEspresso.Domain.Entities;
using EcoEspresso.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEspresso.Service.DTOs.FoodInformations
{
    public class FoodInformationForResultDto
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public string Country { get; set; } = string.Empty;
        public FoodType Type { get; set; }
    }
}
