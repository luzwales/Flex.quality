using Lion.AbpPro.LanguageManagement;
using Volo.Abp.BlobStoring.Database;
using Volo.Abp.OpenIddict;

namespace Flex.Quality.EntityFrameworkCore;

/* This is your actual DbContext used on runtime.
 * It includes only your entities.
 * It does not include entities of the used modules, because each module has already
 * its own DbContext class. If you want to share some database tables with the used modules,
 * just create a structure like done for AppUser.
 *
 * Don't use this DbContext for database migrations since it does not contain tables of the
 * used modules (as explained above). See QualityMigrationsDbContext for migrations.
 */
[ConnectionStringName("Default")]
public class QualityDbContext(DbContextOptions<QualityDbContext> options) : AbpDbContext<QualityDbContext>(options),
    IQualityDbContext,
    IBasicManagementDbContext,
    INotificationManagementDbContext,
    IDataDictionaryManagementDbContext,
    ILanguageManagementDbContext
{
    public DbSet<IdentityUser>                    Users                     { get; set; }
    public DbSet<IdentityRole>                    Roles                     { get; set; }
    public DbSet<IdentityClaimType>               ClaimTypes                { get; set; }
    public DbSet<OrganizationUnit>                OrganizationUnits         { get; set; }
    public DbSet<IdentitySecurityLog>             SecurityLogs              { get; set; }
    public DbSet<IdentityLinkUser>                LinkUsers                 { get; set; }
    public DbSet<IdentityUserDelegation>          UserDelegations           { get; set; }
    public DbSet<IdentitySession>                 Sessions                  { get; set; }
    public DbSet<FeatureGroupDefinitionRecord>    FeatureGroups             { get; set; }
    public DbSet<FeatureDefinitionRecord>         Features                  { get; set; }
    public DbSet<FeatureValue>                    FeatureValues             { get; set; }
    public DbSet<PermissionGroupDefinitionRecord> PermissionGroups          { get; set; }
    public DbSet<PermissionDefinitionRecord>      Permissions               { get; set; }
    public DbSet<PermissionGrant>                 PermissionGrants          { get; set; }
    public DbSet<Setting>                         Settings                  { get; set; }
    public DbSet<SettingDefinitionRecord>         SettingDefinitionRecords  { get; set; }
    public DbSet<Tenant>                          Tenants                   { get; set; }
    public DbSet<TenantConnectionString>          TenantConnectionStrings   { get; set; }
    public DbSet<BackgroundJobRecord>             BackgroundJobs            { get; set; }
    public DbSet<AuditLog>                        AuditLogs                 { get; set; }
    public DbSet<DataDictionary>                  DataDictionaries          { get; set; }
    public DbSet<Language>                        Languages                 { get; set; }
    public DbSet<LanguageText>                    LanguageTexts             { get; set; }
    public DbSet<Notification>                    Notifications             { get; set; }
    public DbSet<NotificationSubscription>        NotificationSubscriptions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AbpIdentityDbProperties.DbSchema = "Qa";
        AbpIdentityDbProperties.DbTablePrefix = "Abp_";
        AbpPermissionManagementDbProperties.DbSchema = "Qa";
        AbpPermissionManagementDbProperties.DbTablePrefix = "Abp_";
        AbpTenantManagementDbProperties.DbSchema = "Qa";
        AbpTenantManagementDbProperties.DbTablePrefix = "Abp_";
        AbpBackgroundJobsDbProperties.DbTablePrefix = "Abp_";
        AbpBackgroundJobsDbProperties.DbSchema = "Qa";
        AbpOpenIddictDbProperties.DbTablePrefix = "Abp_";
        AbpOpenIddictDbProperties.DbSchema = "Qa";
        AbpSettingManagementDbProperties.DbTablePrefix = "Abp_";
        AbpSettingManagementDbProperties.DbSchema = "Qa";
        AbpBlobStoringDatabaseDbProperties.DbTablePrefix = "Abp_";
        AbpBlobStoringDatabaseDbProperties.DbSchema = "Qa";
        AbpFeatureManagementDbProperties.DbTablePrefix = "Abp_";
        AbpFeatureManagementDbProperties.DbSchema = "Qa";
        AbpAuditLoggingDbProperties.DbTablePrefix = "Abp_";
        AbpAuditLoggingDbProperties.DbSchema = "Qa";
        DataDictionaryManagementDbProperties.DbTablePrefix = "Abp_";
        DataDictionaryManagementDbProperties.DbSchema = "Qa";
        LanguageManagementDbProperties.DbTablePrefix = "QA.Abp_";
        // LanguageManagementDbProperties.DbSchema = "Qa";
        NotificationManagementDbProperties.DbTablePrefix = "Abp_";
        NotificationManagementDbProperties.DbSchema = "Qa";


        builder.ConfigureQuality();

        // 基础模块
        builder.ConfigureBasicManagement();

        // 消息通知
        builder.ConfigureNotificationManagement();

        //数据字典
        builder.ConfigureDataDictionaryManagement();

        // 多语言
        builder.ConfigureLanguageManagement();
    }
}