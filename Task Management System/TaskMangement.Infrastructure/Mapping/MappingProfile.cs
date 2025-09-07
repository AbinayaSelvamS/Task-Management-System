using AutoMapper;
using TaskManagement.Common.DTOs.RequestDTO;
using TaskManagement.Common.DTOs.ResponseDTO;
using TaskManagement.Data.Entities;


namespace TaskMangement.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Project, AddProjectResponseDTO>();
            CreateMap<AddProjectRequestDto, Project>();
        }   
    }
}
