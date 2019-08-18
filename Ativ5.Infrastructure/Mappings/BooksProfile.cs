namespace Ativ5.Infrastructure.Mappings
{
    using Ativ5.Application.Outputs;
    using AutoMapper;
    using Ativ5.Domain.Baskets;

    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            CreateMap<Book, BookOutput>()
                .ForMember(dest => dest.BookId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ISBN, opt => opt.MapFrom(src => src.ISBN.Text))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title.Text))
                .ForMember(dest => dest.Authors, opt => opt.MapFrom(src => src.Authors));

        }
    }
}
