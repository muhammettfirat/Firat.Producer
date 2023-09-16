using Volo.Abp.Modularity;

namespace Firat.Producer;

[DependsOn(
    typeof(ProducerApplicationModule),
    typeof(ProducerDomainTestModule)
    )]
public class ProducerApplicationTestModule : AbpModule
{

}
