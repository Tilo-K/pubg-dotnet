using System.Linq;
using FluentAssertions;
using Pubg.Net;
using Pubg.Net.Services.Leaderboard;
using Pubg.Net.Tests.Util;
using Xunit;

namespace pubg.net.Tests.Leaderboard
{
    public class LeaderboardServiceTests : TestBase
    {
        [Theory]
        [InlineData(PubgGameMode.Duo)]
        [InlineData(PubgGameMode.DuoFpp)]
        [InlineData(PubgGameMode.Solo)]
        [InlineData(PubgGameMode.SoloFpp)]
        [InlineData(PubgGameMode.Squad)]
        [InlineData(PubgGameMode.SquadFpp)]
        public void Can_Get_Leaderboard(PubgGameMode gameMode)
        {
            var service = new PubgLeaderboardService(Storage.ApiKey);
            var seasonService = new PubgSeasonService(Storage.ApiKey);

            var seasons = seasonService.GetSeasonsPC().Where(s => s.Id.Contains("pc"));
            var leaderboard = service.GetGameModeLeaderboard(PubgRegion.PCEurope, seasons.First().Id, gameMode);

            leaderboard.Id.Should().NotBeNullOrEmpty();
            leaderboard.ShardId.Should().NotBeNullOrEmpty();
            Assert.All(leaderboard.Players, player => player.Id.Should().NotBeNullOrEmpty());
            Assert.All(leaderboard.Players, player => player.Name.Should().NotBeNullOrEmpty());
        }
    }
}