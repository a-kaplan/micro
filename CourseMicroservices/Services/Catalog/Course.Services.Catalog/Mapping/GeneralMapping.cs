using AutoMapper;
using Course.Services.Catalog.Dtos;

namespace Course.Services.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Model.Course, CourseDto>().ReverseMap();
            CreateMap<Model.Category, CategoryDto>().ReverseMap();
            CreateMap<Model.Feature, FeatureDto>().ReverseMap();

            CreateMap<Model.Course, CourseCreateDto>().ReverseMap();
            CreateMap<Model.Course, CourseUpdateDto>().ReverseMap();

        }
    }
}
