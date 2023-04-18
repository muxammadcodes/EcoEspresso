using AutoMapper;
using EcoEspresso.Domain.Entities;
using EcoEspresso.Service.DTOs;
using EcoEspresso.Service.DTOs.Chefs;
using EcoEspresso.Service.DTOs.FoodInformations;
using EcoEspresso.Service.DTOs.Meals;

namespace EcoEspresso.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Meal, MealForCreationDto>().ReverseMap();
            CreateMap<Meal,MealForResultDto>().ReverseMap();
            CreateMap<Chef,ChefForCreationDto>().ReverseMap();
            CreateMap<Chef,ChefFotResultDto>().ReverseMap();
            CreateMap<FoodInfotmation,FoodInformationCreatDto>().ReverseMap();
            CreateMap<FoodInfotmation, FoodInformationForResultDto>().ReverseMap();  
        }
    }
}
