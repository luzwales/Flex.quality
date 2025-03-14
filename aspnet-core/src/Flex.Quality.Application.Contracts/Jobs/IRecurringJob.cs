namespace Flex.Quality.Jobs;

public interface IRecurringJob : ITransientDependency
{
    /// <summary>
    ///     执行任务
    /// </summary>
    /// <returns></returns>
    Task ExecuteAsync();
}