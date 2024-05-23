using System.Linq;
using Pubg.Net;
using Pubg.Net.Services.LifetimeStats;
using Pubg.Net.Tests.Util;
using Xunit;

namespace pubg.net.Tests.LifetimeStats;

public class LifetimeStatsTest : TestBase
{
    [Fact]
    public void Can_RetrieveLifetimeStats()
    {
        var samples = Storage.GetPlayer(PubgPlatform.Steam);
        var lifetimeStatsService = new PubgLifetimeStatsService(Storage.ApiKey);

        var stats = lifetimeStatsService.GetLifetimeStats(PubgPlatform.Steam, samples.Id);

        Assert.True(stats.GameModeStats.Values.All(s => s != null));
    }
}