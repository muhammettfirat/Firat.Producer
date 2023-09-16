using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Firat.Producer;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProducerHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ProducerConsoleApiClientModule : AbpModule
{

}
