using AutoMapper;
using ProjectMomoDonation.API.DTO;
using ProjectMomoDonation.Core.Models;

namespace ProjectMomoDonation.API.Mapings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<OrganizationFundraise, OrganazationFundraiseDTO>().ReverseMap();
            CreateMap<DonateHistory, DonateHistoryDTO>().ReverseMap();
            CreateMap<ProgramDonation, ProgramDonateDTO>().ReverseMap();
            CreateMap<Core.Models.MomoUser, UserDTO>().ReverseMap();
        }
    }
}