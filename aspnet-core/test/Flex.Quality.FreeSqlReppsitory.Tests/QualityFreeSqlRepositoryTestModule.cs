using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Flex.Quality.FreeSqlReppsitory.Tests;

[DependsOn(
        typeof(QualityTestBaseModule),
        typeof(QualityFreeSqlModule)
    )]

public class QualityFreeSqlRepositoryTestModule: AbpModule
{
   
    //public override void ConfigureServices(ServiceConfigurationContext context)
    //{
        
           
       
    //    var configuration = context.Services.GetConfiguration();
    //    var connectionString = configuration.GetConnectionString("Default");
    //    var freeSql = new FreeSql.FreeSqlBuilder()
    //        .UseConnectionString(FreeSql.DataType.Sqlite, @"Data Source=|DataDirectory|\document.db;Pooling=true;Max Pool Size=10")
    //        .UseAutoSyncStructure(true)
    //        .Build();

    //    context.Services.AddSingleton<IFreeSql>(freeSql);
    //}

}