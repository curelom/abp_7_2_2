using abp_7_2_2.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace abp_7_2_2.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(abp_7_2_2EntityFrameworkCoreModule),
    typeof(abp_7_2_2ApplicationContractsModule)
)]
public class abp_7_2_2DbMigratorModule : AbpModule
{

}
