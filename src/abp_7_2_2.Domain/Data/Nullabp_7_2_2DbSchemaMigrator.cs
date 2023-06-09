using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abp_7_2_2.Data;

/* This is used if database provider does't define
 * Iabp_7_2_2DbSchemaMigrator implementation.
 */
public class Nullabp_7_2_2DbSchemaMigrator : Iabp_7_2_2DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
