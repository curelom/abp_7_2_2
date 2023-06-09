using Volo.Abp.Modularity;

namespace abp_7_2_2;

[DependsOn(
    typeof(abp_7_2_2ApplicationModule),
    typeof(abp_7_2_2DomainTestModule)
    )]
public class abp_7_2_2ApplicationTestModule : AbpModule
{

}
