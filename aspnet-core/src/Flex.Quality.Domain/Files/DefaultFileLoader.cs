using Microsoft.Extensions.FileProviders;
using Volo.Abp.VirtualFileSystem;

namespace Flex.Quality.Files;

public class DefaultFileLoader(IVirtualFileProvider virtualFileProvider) : QualityDomainService, IFileLoader
{
    public async Task<string> LoadAsync(string path)
    {
        return await virtualFileProvider.GetFileInfo(path).ReadAsStringAsync();
    }
}