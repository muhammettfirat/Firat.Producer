using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Firat.Producer;

[DependsOn(
    typeof(ProducerApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ProducerHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ProducerApplicationContractsModule).Assembly,
            ProducerRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ProducerHttpApiClientModule>();
        });

    }
}
