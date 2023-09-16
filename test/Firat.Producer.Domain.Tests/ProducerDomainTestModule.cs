using Firat.Producer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Firat.Producer;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ProducerEntityFrameworkCoreTestModule)
    )]
public class ProducerDomainTestModule : AbpModule
{

}
