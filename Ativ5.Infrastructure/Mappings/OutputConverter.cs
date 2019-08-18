namespace Ativ5.Infrastructure.Mappings
{
    using Ativ5.Application;
    using AutoMapper;

    public class OutputConverter : IOutputConverter
    {
        private readonly IMapper mapper;

        public OutputConverter()
        {
            mapper = new MapperConfiguration(cfg => {
                cfg.AddProfile<BasketsProfile>();
                cfg.AddProfile<CustomersProfile>();
                cfg.AddProfile<BooksProfile>();
                cfg.AddProfile<AuthorsProfile>();
                cfg.AddProfile<OrdersProfile>();
            }).CreateMapper();
        }

        public T Map<T>(object source)
        {
            T model = mapper.Map<T>(source);
            return model;
        }
    }
}
