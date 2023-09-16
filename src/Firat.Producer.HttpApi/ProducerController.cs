using Firat.Producer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Firat.Producer;

public abstract class ProducerController : AbpControllerBase
{
    protected ProducerController()
    {
        LocalizationResource = typeof(ProducerResource);
    }
}
