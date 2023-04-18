using EcoEspresso.Service.DTOs.Chefs;

namespace EcoEspresso.Service.Interfaces
{
    public interface IChefService
    {
        public ValueTask<ChefFotResultDto> AddAsync(ChefForCreationDto dto);
        public ValueTask<ChefFotResultDto> RetrieveByIdAsync(int id);
        public ValueTask<IEnumerable<ChefFotResultDto>> RetrieveAllAsync();
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<bool> ModifyAsync(int id, ChefForCreationDto dto);
    }
}
