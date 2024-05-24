using System.Collections.Generic;
using Pubg.Net.Models.Base;

namespace Pubg.Net.Models.Masteries;

public class WeaponMastery : PubgShardedEntity
{
    public Dictionary<string, WeaponSummary> WeaponSummaries { get; set; }
}