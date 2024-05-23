using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events;

public class LogObjectInteraction : PubgTelemetryEvent
{
    [JsonProperty] public PubgCharacter Character { get; set; }

    [JsonProperty] public string ObjectType { get; set; }

    [JsonProperty] public string ObjectTypeStatus { get; set; }

}