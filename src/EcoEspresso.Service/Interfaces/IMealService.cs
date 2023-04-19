using EcoEspresso.Service.DTOs;
using EcoEspresso.Service.DTOs.Meals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEspresso.Service.Interfaces
{
    public interface IMealService
    {
        public ValueTask<MealForResultDto> AddAsync(MealForCreationDto dto);
        public ValueTask<MealForResultDto> RetrieveByIdAsync(int id);
        public ValueTask<IEnumerable<MealForResultDto>> GetAllAsync();
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<MealForResultDto> ModifyAsync(int id, MealForCreationDto dto);
    }
}
