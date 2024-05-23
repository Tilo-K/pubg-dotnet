using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events;

public class LogPhaseChange : PubgTelemetryEvent
{
    [JsonProperty]
    public int Phase { get; set; }
    
    [JsonProperty]
    public double ElapsedTime { get; set; }
}