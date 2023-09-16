using Localization.Resources.AbpUi;
using Firat.Producer.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Firat.Producer;

[DependsOn(
    typeof(ProducerApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ProducerHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ProducerHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ProducerResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
