using EcoEspresso.Service.DTOs.Chefs;

namespace EcoEspresso.Service.Interfaces
{
    public interface IChefService
    {
        public ValueTask<ChefFotResultDto> AddAsync(ChefForCreationDto dto);
        public ValueTask<ChefFotResultDto> RetrieveByIdAsync(int id);
        public IEnumerable<ChefFotResultDto> RetrieveAll();
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<ChefFotResultDto> ModifyAsync(int id, ChefForCreationDto dto);
    }
}
