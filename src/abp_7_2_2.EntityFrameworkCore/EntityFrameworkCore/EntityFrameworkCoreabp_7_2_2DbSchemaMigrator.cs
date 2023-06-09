using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using abp_7_2_2.Data;
using Volo.Abp.DependencyInjection;

namespace abp_7_2_2.EntityFrameworkCore;

public class EntityFrameworkCoreabp_7_2_2DbSchemaMigrator
    : Iabp_7_2_2DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreabp_7_2_2DbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the abp_7_2_2DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<abp_7_2_2DbContext>()
            .Database
            .MigrateAsync();
    }
}
