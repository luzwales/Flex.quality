namespace Flex.Quality.Files;

public interface IFileLoader
{
    Task<string> LoadAsync(string sqlPath);
}