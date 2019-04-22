using AutoMapper;
using ElearningWebsite.API.Dtos;
using ElearningWebsite.API.Models;

namespace ElearningWebsite.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Course, CourseForListDto>();
            CreateMap<Course, CourseForDetailDP>();
            CreateMap<Course, CourseForDetailedDto>();       
            CreateMap<TeacherForUpdateDto, Teacher>();    
            CreateMap<TeacherDetailedDto, Teacher>();
            CreateMap<CourseForAddDto, Course>();
        }
    }
}