using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Firat.Producer;

[DependsOn(
    typeof(ProducerDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ProducerApplicationContractsModule : AbpModule
{

}
