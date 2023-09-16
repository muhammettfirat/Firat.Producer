using System.Threading.Tasks;
using Xunit;

namespace Firat.Producer.Samples;

public class SampleManager_Tests : ProducerDomainTestBase
{
    //private readonly SampleManager _sampleManager;

    public SampleManager_Tests()
    {
        //_sampleManager = GetRequiredService<SampleManager>();
    }

    [Fact]
    public Task Method1Async()
    {
        return Task.CompletedTask;
    }
}
