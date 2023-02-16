using AutoMapper;
using Model;
using Model.DTO;

namespace MobileAPI.AutoMapper
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Product, ProductCreate>().ReverseMap();
            CreateMap<Category, CategoryCreate>().ReverseMap();
            CreateMap<Category, CategoryUpdate>().ReverseMap();


        }
    }
}
