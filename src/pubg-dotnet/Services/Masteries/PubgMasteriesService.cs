using JsonApiSerializer;
using Newtonsoft.Json;
using Pubg.Net.Infrastructure;
using Pubg.Net.Models.Masteries;
using Pubg.Net.Values;

namespace Pubg.Net.Services.Masteries;

public class PubgMasteriesService : PubgService
{
    public PubgMasteriesService() : base()
    {
    }

    public PubgMasteriesService(string apiKey) : base(apiKey)
    {
    }
    public virtual WeaponMastery GetWeaponMastery(PubgPlatform platform, string accountId,
        string apiKey = null)
    {
        var url = Api.Masteries.WeaponMasteryEndpoint(platform, accountId);
        apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

        var statsJson = HttpRequestor.GetString(url, apiKey);

        return JsonConvert.DeserializeObject<WeaponMastery>(statsJson,
            new JsonApiSerializerSettings());
    }
    
    public virtual SurvivalMastery GetSurvivalMastery(PubgPlatform platform, string accountId,
        string apiKey = null)
    {
        var url = Api.Masteries.SurvivalMasteryEndpoint(platform, accountId);
        apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

        var statsJson = HttpRequestor.GetString(url, apiKey);

        return JsonConvert.DeserializeObject<SurvivalMastery>(statsJson,
            new JsonApiSerializerSettings());
    }
}