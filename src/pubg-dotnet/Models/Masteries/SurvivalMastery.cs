using System.Collections.Generic;
using Pubg.Net.Models.Base;

namespace Pubg.Net.Models.Masteries;

public class SurvivalMastery : PubgEntity
{
    public int Xp { get; set; }
    public int Tier { get; set; }
    public int Level { get; set; }
    public int TotalMatchesPlayed { get; set; }
    public string LatestMatchId { get; set; }
    public Dictionary<string, Stat> Stats { get; set; }
}

public class Stat
{
    public string Statid { get; set; }
    public int Total { get; set; }
    public int Average { get; set; }
    public int CareerBest { get; set; }
    public int LastMatchValue { get; set; }
}