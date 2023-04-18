using EcoEspresso.Service.DTOs.FoodInformations;

namespace EcoEspresso.Service.Interfaces
{
    public interface IFoodInformationService
    {
        public ValueTask<FoodInformationForResultDto> AddAsync(FoodInformationCreatDto dto);
        public ValueTask<FoodInformationForResultDto> RetrieveByIdAsync(int id);
        public ValueTask<IEnumerable<FoodInformationForResultDto>> GetAllAsync();
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<bool> ModifyAsync(int id,FoodInformationCreatDto dto);

    }
}
