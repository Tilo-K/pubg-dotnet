using System.Collections.Generic;
using JsonApiSerializer;
using Newtonsoft.Json;
using Pubg.Net.Infrastructure;
using Pubg.Net.Values;

namespace Pubg.Net.Services.LifetimeStats;

public class PubgLifetimeStatsService : PubgService
{
    public PubgLifetimeStatsService() : base()
    {
    }

    public PubgLifetimeStatsService(string apiKey) : base(apiKey)
    {
    }

    public virtual Models.LifetimeStats.LifetimeStats GetLifetimeStats(PubgPlatform platform, string accountId,
        string apiKey = null)
    {
        var url = Api.LifetimeStats.LifetimeStatsEndpoint(platform, accountId);
        apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

        var statsJson = HttpRequestor.GetString(url, apiKey);

        return JsonConvert.DeserializeObject<Models.LifetimeStats.LifetimeStats>(statsJson,
            new JsonApiSerializerSettings());
    }

    public virtual IEnumerable<Models.LifetimeStats.LifetimeStats> GetLifetimeStats(PubgPlatform platform,
        PubgGameMode gameMode,
        IEnumerable<string> playerIds, string apiKey = null)
    {
        var url = Api.LifetimeStats.LifetimeStatsEndpoint(platform, gameMode, playerIds);
        apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

        var statsJson = HttpRequestor.GetString(url, apiKey);

        return JsonConvert.DeserializeObject<IEnumerable<Models.LifetimeStats.LifetimeStats>>(statsJson,
            new JsonApiSerializerSettings());
    }
}