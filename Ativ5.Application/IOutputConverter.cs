namespace Ativ5.Application
{
    public interface IOutputConverter
    {
        T Map<T>(object source);
    }
}
