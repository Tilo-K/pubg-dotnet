using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events;

public class LogPlayerUseThrowable : PubgTelemetryEvent
{
    [JsonProperty]
    public int AttackId { get; set; }
    
    [JsonProperty]
    public int FireWeaponStackCount { get; set; }
    
    [JsonProperty]
    public PubgCharacter Attacker { get; set; }
    
    [JsonProperty]
    public string AttackType { get; set; }
    
    [JsonProperty]
    public PubgItem Weapon { get; set; }
}