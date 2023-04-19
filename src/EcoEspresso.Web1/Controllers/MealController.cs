using EcoEspresso.Service.DTOs;
using EcoEspresso.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EcoEspresso.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MealController
    {
        private readonly IMealService mealService;

        public MealController(IMealService mealService)
        {
            this.mealService = mealService;
        }

        public async Task PostAsync(MealForCreationDto dto) =>
            await mealService.AddAsync(dto);
    } 
}
