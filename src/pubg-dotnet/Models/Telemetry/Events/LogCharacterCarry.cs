using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events;

public class LogCharacterCarry : PubgTelemetryEvent
{
    [JsonProperty]
    public PubgCharacter Character { get; set; }
    
    [JsonProperty]
    public string CarryState { get; set; }
}