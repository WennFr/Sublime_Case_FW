using APIServiceLibrary.DTO.ProgramDTOs;
using AutoMapper;
using ProgramMVC.Models;

namespace ProgramMVC.Infrastructure.Profiles
{
    public class ProgramProfile : Profile
    {
        public ProgramProfile()
        {
            CreateMap<ProgramDTO, ProgramModel>()
                .ForMember(dest => dest.ProgramCategory, opt => opt.MapFrom(src => new ProgramCategoryModel
                {
                    Id = src.ProgramCategory.Id,
                    Name = src.ProgramCategory.Name
                }))
                .ForMember(dest => dest.Channel, opt => opt.MapFrom(src => new ChannelModel
                {
                    Id = src.Channel.Id,
                    Name = src.Channel.Name
                }));
        }

    }
}
