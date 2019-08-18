namespace Ativ5.Application.UseCases.Register
{
    public class RegisterInput
    {
        public string PIN { get; private set; }
        public string Name { get; private set; }

        public RegisterInput(string pin, string name)
        {
            this.PIN = pin;
            this.Name = name;
        }
    }
}
