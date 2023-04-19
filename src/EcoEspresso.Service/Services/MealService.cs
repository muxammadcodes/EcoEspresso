using AutoMapper;
using EcoEspresso.DataAccess.IRepositories;
using EcoEspresso.Domain.Entities;
using EcoEspresso.Service.Commons.Exceptions;
using EcoEspresso.Service.DTOs;
using EcoEspresso.Service.DTOs.Meals;
using EcoEspresso.Service.Interfaces;

namespace EcoEspresso.Service.Services
{
    public class MealService : IMealService
    {
        private readonly IRepository<Meal> reposioty;
        private readonly IMapper mapper;

        public MealService(IRepository<Meal> repository,IMapper mapper)
        {
            this.mapper = mapper;
            this.reposioty = repository;
        }
        public async ValueTask<MealForResultDto> AddAsync(MealForCreationDto dto)
        {
           var meal = await this.reposioty.GetAsync(m => m.Name.ToLower() == dto.Name.ToLower());
            if (meal is not null)
                await this.ModifyAsync(meal.Id, dto);

            var mapped = this.mapper.Map<Meal> (dto);
            mapped.CreatedAt = DateTime.UtcNow;
            var result = await this.reposioty.InsertAsync(mapped);
            await this.reposioty.SaveAsync();

            return this.mapper.Map<MealForResultDto>(result);           
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var meal = await this.reposioty.GetAsync(m => m.Id == id);
            if (meal == null)
                throw new CustomException(404, "Couldn't found meal for given id");

            var res = await this.reposioty.DeleteAsync(m => m.Id == id);
            await this.reposioty.SaveAsync();

            return res;
        }

        public async ValueTask<IEnumerable<MealForResultDto>> GetAllAsync()
        {
            var meals = this.reposioty.GetAllAsync();
            if (meals == null)
                throw new CustomException(404, "Meals are not Found");

             return this.mapper.Map<IEnumerable<MealForResultDto>>(meals);
        }

        public async ValueTask<MealForResultDto> ModifyAsync(int id, MealForCreationDto dto)
        {
            var meal = await this.reposioty.GetAsync(m => m.Id == id);
            if(meal == null)
                throw new CustomException(404, "Couldn't found meal for given id");

            var mapped = this.mapper.Map(dto, meal);
            mapped.UpdatedAt = DateTime.UtcNow;
            
            await this.reposioty.SaveAsync();

            return this.mapper.Map<MealForResultDto>(mapped);
        }

        public async ValueTask<MealForResultDto> RetrieveByIdAsync(int id)
        {
            var meal = await this.reposioty.GetAsync(m => m.Id == id);
            if (meal == null)
                throw new CustomException(404, "Couldn't found meal for given id");

            return this.mapper.Map<MealForResultDto>(meal);
        }
    }
}
