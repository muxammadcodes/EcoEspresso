using AutoMapper;
using EcoEspresso.DataAccess.IRepositories;
using EcoEspresso.Domain.Entities;
using EcoEspresso.Service.Commons.Exceptions;
using EcoEspresso.Service.DTOs.Chefs;
using EcoEspresso.Service.Interfaces;
using System.Security.AccessControl;

namespace EcoEspresso.Service.Services
{
    public class ChefService : IChefService
    {
        private readonly IRepository<Chef> repository;
        private readonly IMapper mapper;

        public ChefService(IRepository<Chef> repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async ValueTask<ChefFotResultDto> AddAsync(ChefForCreationDto dto)
        {
            var chef = await this.repository
                .GetAsync((chef) => chef.FirstName.ToLower() == dto.FirstName.ToLower() 
                 && chef.LastName.ToLower() == dto.LastName.ToLower());
            if (chef == null)
                throw new CustomException(404, "Chef not found");

            var mapped = this.mapper.Map<Chef>(dto);
            mapped.CreatedAt = DateTime.UtcNow;
            var result = await this.repository.InsertAsync(mapped);
            await this.repository.SaveAsync();

            return this.mapper.Map<ChefFotResultDto>(result);
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var chef = await this.repository.GetAsync(chef => chef.Id == id);
            if (chef == null)
                throw new CustomException(404, "Couldn't found chef for this given id");

            var result = await this.repository.DeleteAsync(chef => chef.Id == id);
            await this.repository.SaveAsync();

            return result;
        }
        public async ValueTask<ChefFotResultDto> ModifyAsync(int id, ChefForCreationDto dto)
        {
            var chef = await this.repository.GetAsync(chef => chef.Id == id);
            if(chef == null)
                throw new CustomException(404, "Couldn't found chef for this given id");

            var mapped = this.mapper.Map(dto, chef);
            mapped.UpdatedAt = DateTime.UtcNow;
            await this.repository.SaveAsync();

            return this.mapper.Map<ChefFotResultDto>(mapped);
        }
        public IEnumerable<ChefFotResultDto> RetrieveAll()
        {
            var chefs = this.repository.GetAllAsync();
            if (chefs == null)
                throw new CustomException(404, "Chefs are not found");

            return this.mapper.Map<IEnumerable<ChefFotResultDto>>(chefs);
        }
        public async ValueTask<ChefFotResultDto> RetrieveByIdAsync(int id)
        {
            var chef = await this.repository.GetAsync(chef => chef.Id == id);
            if (chef == null)
                throw new CustomException(404, "Couldn't found chef for this given id");

            return this.mapper.Map<ChefFotResultDto>(chef);
        }
    }
}
