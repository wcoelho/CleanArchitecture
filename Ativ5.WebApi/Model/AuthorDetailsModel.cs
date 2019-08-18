namespace Ativ5.WebApi.Model
{
    using System;

    public class AuthorDetailsModel
    {
        public Guid AuthorId { get; }
        public string Name { get; }

        public AuthorDetailsModel(Guid authorId, string name)
        {
            AuthorId = authorId;
            Name = name;
        }
    }
}
