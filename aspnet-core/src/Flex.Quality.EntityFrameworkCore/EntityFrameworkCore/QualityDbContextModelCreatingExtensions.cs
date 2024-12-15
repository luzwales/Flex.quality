namespace Flex.Quality.EntityFrameworkCore;

public static class QualityDbContextModelCreatingExtensions
{
    public static void ConfigureQuality(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(QualityConsts.DbTablePrefix + "YourEntities", QualityConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
    }
}