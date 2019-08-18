namespace Ativ5.Infrastructure.Mappings
{
    using Ativ5.Application.Outputs;
    using AutoMapper;
    using Ativ5.Application.UseCases.DeleteBasket;
    using Ativ5.Domain.Baskets;

    public class BasketsProfile : Profile
    {
        public BasketsProfile()
        {
            CreateMap<Basket, BasketOutput>()
                .ForMember(dest => dest.BasketId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.GetTotalPrice().Value))
                .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.Books));

            CreateMap<Basket, OrderOutput>()
                .ForMember(dest => dest.BasketId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FinalPrice, opt => opt.MapFrom(src => src.GetTotalPrice().Value));
	
            CreateMap<Basket, DeleteOutput>()
                .ForMember(dest => dest.BasketId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
