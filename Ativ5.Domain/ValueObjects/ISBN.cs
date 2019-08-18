namespace Ativ5.Domain.ValueObjects
{
    public class ISBN
    {
        public string Text { get; private set; }

        public ISBN(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ISBNShouldNotBeEmptyException("The 'ISBN' field is required");

            this.Text = text;
        }

        public override string ToString()
        {
            return Text.ToString();
        }

        public static implicit operator ISBN(string text)
        {
            return new ISBN(text);
        }
    }
}
