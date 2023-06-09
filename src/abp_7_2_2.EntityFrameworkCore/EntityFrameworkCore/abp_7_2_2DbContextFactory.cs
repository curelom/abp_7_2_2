using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace abp_7_2_2.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class abp_7_2_2DbContextFactory : IDesignTimeDbContextFactory<abp_7_2_2DbContext>
{
    public abp_7_2_2DbContext CreateDbContext(string[] args)
    {
        abp_7_2_2EfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<abp_7_2_2DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new abp_7_2_2DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../abp_7_2_2.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
