using AutoMapper;
using VY.G.Data.Contracts.Entities;
using VY.G.Dtos.V1;

namespace VY.G.Business.Impl.MappingProfiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonDto, PersonEntity>()
                .ForMember(e => e.Id, conf => conf.MapFrom(d => d.Id))
                .ForMember(e => e.Name, conf => conf.MapFrom(d => d.Name))
                .ForMember(e => e.LastName, conf => conf.MapFrom(d => d.LastName))
                .ForMember(e => e.Email, conf => conf.MapFrom(d => d.Email))
                .ForMember(e => e.Age, conf => conf.MapFrom(d => d.Age))
                .ReverseMap();
        }
    }
}
