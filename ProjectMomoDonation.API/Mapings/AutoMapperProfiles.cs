using AutoMapper;
using MobileShop.API.DTO;
using MobileShop.Core.Models;

namespace MobileShop.API.Mapings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}