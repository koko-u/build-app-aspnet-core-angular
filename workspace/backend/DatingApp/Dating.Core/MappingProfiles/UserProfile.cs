using AutoMapper;
using Dating.Db.Entities;
using Dating.UI.Responses;

namespace Dating.Core.MappingProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<AppUser, User>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.UserName));
    }
}
