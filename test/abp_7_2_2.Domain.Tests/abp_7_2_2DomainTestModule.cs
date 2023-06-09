using abp_7_2_2.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace abp_7_2_2;

[DependsOn(
    typeof(abp_7_2_2EntityFrameworkCoreTestModule)
    )]
public class abp_7_2_2DomainTestModule : AbpModule
{

}
