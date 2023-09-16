using Firat.Producer.Localization;
using Volo.Abp.Application.Services;

namespace Firat.Producer;

public abstract class ProducerAppService : ApplicationService
{
    protected ProducerAppService()
    {
        LocalizationResource = typeof(ProducerResource);
        ObjectMapperContext = typeof(ProducerApplicationModule);
    }
}
