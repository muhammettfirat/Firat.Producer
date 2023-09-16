using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Firat.Producer.EntityFrameworkCore;

[ConnectionStringName(ProducerDbProperties.ConnectionStringName)]
public class ProducerDbContext : AbpDbContext<ProducerDbContext>, IProducerDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ProducerDbContext(DbContextOptions<ProducerDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureProducer();
    }
}
