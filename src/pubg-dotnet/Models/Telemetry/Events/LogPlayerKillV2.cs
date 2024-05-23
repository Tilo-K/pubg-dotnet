using System.Collections.Generic;
using Newtonsoft.Json;
using Pubg.Net.Models.Telemetry.Enums;

namespace Pubg.Net.Models.Telemetry.Events;

public class LogPlayerKillV2 : PubgTelemetryEvent
{
    [JsonProperty]
    public int AttackId { get; set; }

    [JsonProperty]
    public int DBNOId { get; set; }
    
    [JsonProperty]
    public PubgGameResult VictimGameResult { get; set; }
    
    [JsonProperty]
    public PubgCharacter Victim { get; set; }
    
    [JsonProperty]
    public string VictimWeapon { get; set; }
    
    [JsonProperty]
    public List<string> VictimWeaponAdditionalInfo { get; set; }
    
    [JsonProperty]
    public PubgCharacter DBNOMaker { get; set; }
    
    [JsonProperty]
    public DamageInfo DBNODamageInfo { get; set; }
    
    [JsonProperty]
    public PubgCharacter Finisher { get; set; }
    
    [JsonProperty]
    public DamageInfo FinishDamageInfo { get; set; }
    
    [JsonProperty]
    public PubgCharacter Killer { get; set; }
    
    [JsonProperty]
    public DamageInfo KillerDamageInfo { get; set; }
    
    [JsonProperty]
    public List<string> Assists_AccountId { get; set; }
    
    [JsonProperty]
    public List<string> TeamKillers_AccountId { get; set; }
    
    [JsonProperty]
    public bool IsSuicide { get; set; }
}