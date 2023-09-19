using AutoMapper;
using SharedLibrary.DTO;
using SharedLibrary.Domain;

namespace EmployeeAPI.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {

            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();


        }
    }
}
