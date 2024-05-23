using System.Linq;
using Pubg.Net;
using Pubg.Net.Services.LifetimeStats;
using Pubg.Net.Services.Masteries;
using Pubg.Net.Tests.Util;
using Xunit;

namespace pubg.net.Tests.Masteries;

public class MasteriesTest : TestBase
{
    [Fact]
    public void Can_RetrieveWeaponMastery()
    {
        var samples = Storage.GetPlayer(PubgPlatform.Steam);
        var masteriesService = new PubgMasteriesService(Storage.ApiKey);

        var stats = masteriesService.GetWeaponMastery(PubgPlatform.Steam, samples.Id);

        Assert.True(stats.WeaponSummaries.Values.All(s => s != null));
    }
    
    [Fact]
    public void Can_RetrieveSurvivalMastery()
    {
        var samples = Storage.GetPlayer(PubgPlatform.Steam);
        var masteriesService = new PubgMasteriesService(Storage.ApiKey);

        var stats = masteriesService.GetSurvivalMastery(PubgPlatform.Steam, samples.Id);

        Assert.True(stats.Stats.All(s => s.Value != null));
    }
}