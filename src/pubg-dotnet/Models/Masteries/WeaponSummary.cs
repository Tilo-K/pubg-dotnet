using System.Collections.Generic;

namespace Pubg.Net.Models.Masteries;

public class CompetitiveStatsTotal
{
    public int MostDefeatsInAGame { get; set; }
    public int Defeats { get; set; }
    public int DamagePlayer { get; set; }
    public int HeadShots { get; set; }
    public int Kills { get; set; }
    public int MostKillsInAGame { get; set; }
    public int Groggies { get; set; }
    public int LongestKill { get; set; }
}

public class Medal
{
    public string MedalId { get; set; }
    public int Count { get; set; }
}

public class OfficialStatsTotal
{
    public int MostDefeatsInAGame { get; set; }
    public int Defeats { get; set; }
    public int DamagePlayer { get; set; }
    public int HeadShots { get; set; }
    public int Kills { get; set; }
    public int MostKillsInAGame { get; set; }
    public int Groggies { get; set; }
    public int LongestKill { get; set; }
}

public class WeaponSummary
{
    public int XPTotal { get; set; }
    public int LevelCurrent { get; set; }
    public int TierCurrent { get; set; }
    public StatsTotal StatsTotal { get; set; }
    public OfficialStatsTotal OfficialStatsTotal { get; set; }
    public CompetitiveStatsTotal CompetitiveStatsTotal { get; set; }
    public List<Medal> Medals { get; set; }
}

public class StatsTotal
{
    public int MostDefeatsInAGame { get; set; }
    public int Defeats { get; set; }
    public int MostDamagePlayerInAGame { get; set; }
    public int DamagePlayer { get; set; }
    public int MostHeadShotsInAGame { get; set; }
    public int HeadShots { get; set; }
    public int LongestDefeat { get; set; }
    public int LongRangeDefeats { get; set; }
    public int Kills { get; set; }
    public int MostKillsInAGame { get; set; }
    public int Groggies { get; set; }
    public int MostGroggiesInAGame { get; set; }
}