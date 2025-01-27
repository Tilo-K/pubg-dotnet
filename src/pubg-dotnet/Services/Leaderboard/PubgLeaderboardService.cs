﻿using JsonApiSerializer;
using Newtonsoft.Json;
using Pubg.Net.Infrastructure;
using Pubg.Net.Values;
using System.Threading;
using System.Threading.Tasks;

namespace Pubg.Net.Services.Leaderboard
{
    public class PubgLeaderboardService : PubgService
    {
        public PubgLeaderboardService() : base() { }
        public PubgLeaderboardService(string apiKey) : base(apiKey) { }

        public virtual PubgLeaderboard GetGameModeLeaderboard(PubgRegion region, string seasonId,PubgGameMode gameMode, string apiKey = null)
        {
            var url = Api.Leaderboard.LeaderboardEndpoint(region, seasonId, gameMode);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var leaderboardJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<PubgLeaderboard>(leaderboardJson, new JsonApiSerializerSettings());
        }

        public virtual async Task<PubgLeaderboard> GetGameModeLeaderboardAsync(PubgRegion region, string seasonId, PubgGameMode gameMode, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Leaderboard.LeaderboardEndpoint(region,seasonId, gameMode);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var leaderboardJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<PubgLeaderboard>(leaderboardJson, new JsonApiSerializerSettings());
        }
    }
}
