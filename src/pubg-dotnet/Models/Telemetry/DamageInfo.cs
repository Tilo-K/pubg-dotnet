using System.Collections.Generic;
using Newtonsoft.Json;
using Pubg.Net.Models.Base;

namespace Pubg.Net.Models.Telemetry;

public class DamageInfo : PubgEntity
{
    [JsonProperty]
    public string DamageReason { get; set; }
    
    [JsonProperty]
    public string DamageTypeCategory { get; set; }
    
    [JsonProperty]
    public string DamageCauserName { get; set; }
    
    [JsonProperty]
    public List<string> AdditionalInfo { get; set; }
    
    [JsonProperty]
    public double Distance { get; set; }
    
    [JsonProperty]
    public bool IsThroughPenetrableWall { get; set; }
}