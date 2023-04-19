using AutoMapper;
using EcoEspresso.DataAccess.IRepositories;
using EcoEspresso.Domain.Entities;
using EcoEspresso.Service.Commons.Exceptions;
using EcoEspresso.Service.DTOs.FoodInformations;
using EcoEspresso.Service.Interfaces;
using System.Collections.Immutable;

namespace EcoEspresso.Service.Services;

public class FoodInformationService : IFoodInformationService
{
    private readonly IRepository<FoodInfotmation> _repository;
    private readonly IMapper _mapper;
    private readonly IMealService _mealService;

    public FoodInformationService(IMapper mapper,
        IRepository<FoodInfotmation> repository,
        IMealService mealService)
    {
        this._mapper = mapper;
        this._repository = repository;
        this._mealService = mealService;
    }

    public async ValueTask<FoodInformationForResultDto> AddAsync(FoodInformationCreatDto dto)
    {
        var meal = await this._mealService.RetrieveByIdAsync(dto.MealId);
        if (meal == null)
            throw new CustomException(404, "Couldn't find meal for this given id");

        var information = await this._repository.GetAsync(mf => mf.MealId == dto.MealId);
        if(information is not null)
            throw new CustomException(404, "Couldn't find meal inforamtion for this given id");

        var mapped = this._mapper.Map<FoodInfotmation>(dto);
        var result = await this._repository.InsertAsync(mapped);

        return this._mapper.Map<FoodInformationForResultDto>(result);
    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        var information = await this._repository.GetAsync(info => info.Id == id);
        if(information is null)
            throw new CustomException(404, "Couldn't find meal inforamtion for this given id");

        await this._repository.DeleteAsync(info => info.Id == id);
        await this._repository.SaveAsync();

        return true;
    }
    public IEnumerable<FoodInformationForResultDto> GetAllAsync()
    {
        var details = this._repository.GetAllAsync();
        if (details is null)
            throw new CustomException(404, "Couldn't find all meal information");

        return this._mapper.Map<IEnumerable<FoodInformationForResultDto>>(details);
    }
    public async ValueTask<FoodInformationForResultDto> ModifyAsync(int id, FoodInformationCreatDto dto)
    {
        var detail = await this._repository.GetAsync(info =>info.Id == id);
        if (detail is null)
            throw new CustomException(404, "Couldn't find meal inforamtion for this given id");

        var mapped = this._mapper.Map(dto,detail);
        mapped.UpdatedAt = DateTime.UtcNow;
        await this._repository.SaveAsync();

        return this._mapper.Map<FoodInformationForResultDto>(mapped);
    }
    public async ValueTask<FoodInformationForResultDto> RetrieveByIdAsync(int id)
    {
        var data = await this._repository.GetAsync(info => info.Id == id);
        if(data is null)
            throw new CustomException(404, "Couldn't find meal inforamtion for this given id");

        return this._mapper.Map<FoodInformationForResultDto>(data);
    }
}
