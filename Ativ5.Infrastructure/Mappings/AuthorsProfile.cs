namespace Ativ5.Infrastructure.Mappings
{
    using Ativ5.Application.Outputs;
    using AutoMapper;
    using Ativ5.Domain.Baskets;

    public class AuthorsProfile : Profile
    {
        public AuthorsProfile()
        {
            CreateMap<Author, AuthorOutput>()
                .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Text));
        }
    }
}
