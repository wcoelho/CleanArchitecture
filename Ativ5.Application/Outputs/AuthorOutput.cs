namespace Ativ5.Application.Outputs
{
    using System;

    public class AuthorOutput
    {
        public Guid AuthorId { get; private set; }
        public string Name { get; private set; }

        public AuthorOutput()
        {

        }

        public AuthorOutput(Guid authorId, string name)
        {
            AuthorId = authorId;
            Name = name;
        }
    }
}
