using AutoMapper;
using Examen.Models;
using Examen.Models.nsOrder;
using Examen.Models.nsOrder.DTO;
using Examen.Models.nsOrderProduct;
using Examen.Models.nsProduct;
using Examen.Models.nsProduct.DTO;
using Examen.Models.nsUser;
using Examen.Models.nsUser.DTO;

namespace Examen.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // CreateMap<Source, Destination>();
            //CreateMap<Dog, DogDto>();
            //CreateMap<DogDto, Dog>();
            CreateMap<User, CreateUserDTO>();
            CreateMap<CreateUserDTO, User>();
            CreateMap<Product, CreateProductDto>();
            CreateMap<CreateProductDto, Product>();
            CreateMap<Order, CreateOrderDto>();
            CreateMap<CreateOrderDto, Order>();
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
            CreateMap<OrderProduct, OrderProductDTO>();
            CreateMap<OrderProductDTO, OrderProduct>();
        }
    }
}
