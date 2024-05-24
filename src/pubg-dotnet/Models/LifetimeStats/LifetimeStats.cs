using System.Collections.Generic;
using Pubg.Net.Models.Base;

namespace Pubg.Net.Models.LifetimeStats;

public class LifetimeStats : PubgEntity
{
    public Dictionary<PubgGameMode, GameModeStat> GameModeStats { get; set; }
}