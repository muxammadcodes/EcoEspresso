using EcoEspresso.Service.DTOs;
using EcoEspresso.Service.DTOs.Meals;
using EcoEspresso.Service.Interfaces;

namespace EcoEspresso.Service.Services
{
    public class MealService : IMealService
    {
        public ValueTask<MealForResultDto> AddAsync(MealForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<MealForResultDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> ModifyAsync(int id, MealForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<MealForResultDto> RetrieveByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
