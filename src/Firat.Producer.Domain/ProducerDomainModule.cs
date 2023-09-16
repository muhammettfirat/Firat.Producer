using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Firat.Producer;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ProducerDomainSharedModule)
)]
public class ProducerDomainModule : AbpModule
{

}
