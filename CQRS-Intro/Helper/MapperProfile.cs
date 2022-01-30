using AutoMapper;
using CQRS_Intro.CQRS.Commands.Request;
using CQRS_Intro.CQRS.Queries.Response;
using CQRS_Intro.DbContext;
using CQRS_Intro.Models;

namespace CQRS_Intro.Helper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, GetProductByIdQueryResponse>();           
            CreateMap<Product, GetAllProductsQueryResponse>();
            CreateMap<CreateProductCommandRequest, Product>()
                .ForMember(dest => dest.Id, op => op.MapFrom(src => Context.Products.Last().Id + 1))
                .ForMember(dest => dest.CreateDate, op => op.MapFrom(src => DateTime.Now));
        }
    }
}
