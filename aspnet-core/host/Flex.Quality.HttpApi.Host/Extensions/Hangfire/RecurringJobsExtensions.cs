using Flex.Quality.Jobs;

namespace Flex.Quality.Extensions.Hangfire;

public static class RecurringJobsExtensions
{
    public static void CreateRecurringJob(this ApplicationInitializationContext context)
    {
        RecurringJob.AddOrUpdate<TestJob>("测试Job", e => e.ExecuteAsync(), CronType.Minute(),
            new RecurringJobOptions
            {
                TimeZone = TimeZoneInfo.Local
            });
    }
}