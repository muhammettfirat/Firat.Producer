using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Firat.Producer.EntityFrameworkCore;

[ConnectionStringName(ProducerDbProperties.ConnectionStringName)]
public interface IProducerDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
