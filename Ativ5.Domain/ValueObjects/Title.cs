namespace Ativ5.Domain.ValueObjects
{
    public class Title
    {
        public string Text { get; private set; }

        public Title(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new TitleShouldNotBeEmptyException("The 'Title' field is required");

            this.Text = text;
        }

        public override string ToString()
        {
            return Text.ToString();
        }

        public static implicit operator Title(string text)
        {
            return new Title(text);
        }
    }
}
