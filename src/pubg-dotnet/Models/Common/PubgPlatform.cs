using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Pubg.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PubgPlatform
    {
        [EnumMember(Value = "steam")]
        Steam,
        
        [Obsolete("The Xbox shard is obsolete use Console instead.")]
        [EnumMember(Value = "xbox")]
        Xbox,
        
        [EnumMember(Value = "psn")]
        [Obsolete("The PlayStation shard is obsolete use Console instead.")]
        PlayStation,
        [EnumMember(Value = "kakao")]
        Kakao,
        [EnumMember(Value = "tournament")]
        Tournament,
        [EnumMember(Value = "console")]
        Console
    }
}
