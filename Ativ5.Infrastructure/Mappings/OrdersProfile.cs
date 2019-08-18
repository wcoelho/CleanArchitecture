namespace Ativ5.Infrastructure.Mappings
{
    using Ativ5.Application.Outputs;
    using Ativ5.Domain.Orders;
    using AutoMapper;

    public class OrdersProfile : Profile
    {
        public OrdersProfile()
        {
            CreateMap<Order, OrderOutput>()
                    .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                    .ForMember(dest => dest.BasketId, opt => opt.MapFrom(src => src.BasketId))
                    .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => src.OrderDate))
                    .ForMember(dest => dest.FinalPrice, opt => opt.MapFrom(src => src.FinalPrice.Value));
        }
    }
}
