namespace Ativ5.Domain.Baskets
{
    using ValueObjects;
    public class Author : Entity
    {
        public Name Name { get; private set; }

        public Author(Name name)
        {
            if (name==null)
                throw new AuthorShouldNotBeEmptyException("The 'Author' field is required");

            this.Name = name;
        }

        public override string ToString()
        {
            return Name.ToString();
        }

        public static implicit operator Author(Name name)
        {
            return new Author(name);
        }
    }
}
